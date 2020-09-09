namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Attorney
    {
        public Attorney()
        {
            this.Cases = new HashSet<Case>();
            this.Hearings = new HashSet<Hearing>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Case> Cases { get; set; }

        public ICollection<Hearing> Hearings { get; set; }
    }
}
