namespace NeighboursCommunitySystem.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class User : IdentityUser
    {
        private HashSet<Tax> taxes;
        private HashSet<Proposal> proposals;

        public User()
        {
            this.taxes = new HashSet<Tax>();
            this.proposals = new HashSet<Proposal>();
        }

        public User(string userName)
            : base(userName)
        {
            this.taxes = new HashSet<Tax>();
            this.proposals = new HashSet<Proposal>();
        }

        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public byte AppartmentNumber { get; set; }

        public virtual ICollection<Tax> Taxes
        {
            get { return this.taxes; }
            set { this.taxes = (HashSet<Tax>)value; }
        }

        public virtual ICollection<Proposal> Proposals
        {
            get { return this.proposals; }
            set { this.proposals = (HashSet<Proposal>)value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

            // Add custom user claims here
            return userIdentity;
        }
    }
}