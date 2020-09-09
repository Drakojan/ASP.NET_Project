namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System.ComponentModel.DataAnnotations;

    public class Judge
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LasttName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string CourtRoom { get; set; }
    }
}
