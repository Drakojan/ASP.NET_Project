namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System.ComponentModel.DataAnnotations;

    public class Client
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

        [Required]
        public Address Address { get; set; }

        [RegularExpression(@"^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$")]
        public string SSN { get; set; }

        // TODO: passwords should be saved as hashed value
        public string Password { get; set; }

        public int CaseId { get; set; }
    }
}
