using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Data.Models.DbModels
{
    public class Creditor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }

        [MaxLength(30)]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}