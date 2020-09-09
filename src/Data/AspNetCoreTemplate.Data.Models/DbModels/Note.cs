namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Note
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime OriginalNoteDate { get; set; }

        [Required]
        public string OriginalPoster { get; set; }

        public DateTime? RedactionDate { get; set; }

        public string RedactionPoster { get; set; }
    }
}
