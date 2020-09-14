namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Trustee
    {
        public Trustee()
        {
            this.Cases = new HashSet<Case>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LasttName { get; set; }

        public Address Address { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Case> Cases { get; set; }
    }
}
