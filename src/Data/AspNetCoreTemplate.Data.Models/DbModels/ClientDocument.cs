namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ClientDocument
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public DateTime DateIssued { get; set; }

        [Required]
        public byte[] Picture { get; set; }
    }
}
