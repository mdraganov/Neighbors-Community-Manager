namespace NeighboursCommunitySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Community
    {
        private ICollection<User> users;
        private ICollection<Tax> taxes;

        public Community()
        {
            this.users = new HashSet<User>();
            this.taxes = new HashSet<Tax>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name cannot be shorthan then 3 characters.")]
        [MaxLength(30, ErrorMessage = "Name cannot be shorthan then 30 characters.")]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [MinLength(3)]
        [MaxLength(300)]
        public string Description { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public virtual ICollection<Tax> Taxes
        {
            get { return this.taxes; }
            set { this.taxes = value; }
        }
    }
}
