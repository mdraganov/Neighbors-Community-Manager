﻿namespace NeighboursCommunitySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Tax
    {
        private ICollection<User> users;
        private DateTime deadline;

        public Tax()
        {
            this.users = new HashSet<User>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public bool IsPaid { get; set; }

        [Required]
        public DateTime Deadline
        {
            get
            {
                return this.deadline;
            }
            set
            {
                if (value.Date.CompareTo(DateTime.Now.AddDays(1).Date) <= 0)
                {
                    throw new ArgumentOutOfRangeException("The deadline must be atleast 24 hours further in the future counting from the current day.");
                }

                this.deadline = value;
            }
        }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = (HashSet<User>)value; }
        }
    }
}