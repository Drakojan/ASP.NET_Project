namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string StreetAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(30)]
        public string State { get; set; }

        [Required]
        [MaxLength(30)]
        public int ZipCode { get; set; }
    }
}
