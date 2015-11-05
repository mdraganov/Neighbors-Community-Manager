namespace NeighboursCommunitySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tax
    {
        private HashSet<User> users;

        public Tax()
        {
            this.users = new HashSet<User>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public bool IsPaid { get; set; }

        // TODO: Set restriction for deadline to range from (DateTime.Now to DateTime.SomeDateInTheFuture(DateTime.Now.AddDays(60).Date for example)
        [Required]
        public DateTime Deadline { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = (HashSet<User>)value; }
        }
    }
}