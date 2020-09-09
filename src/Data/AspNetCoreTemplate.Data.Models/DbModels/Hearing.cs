namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using AspNetCoreTemplate.Data.Models.Enums;

    public class Hearing
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public Address Address { get; set; }

        public HearingOutcome Outcome { get; set; }

        // TODO: see if this works fine as a FK
        public int? HearingId { get; set; }
    }
}
