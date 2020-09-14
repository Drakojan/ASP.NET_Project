namespace AspNetCoreTemplate.Data.Models.DbModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using AspNetCoreTemplate.Data.Models.Enums;

    public class Case
    {
        public Case()
        {
            this.CaseStatus = CaseStatus.Active;
            this.CourtDocuments = new HashSet<CourtDocument>();
            this.ClientDocuments = new HashSet<ClientDocument>();
            this.Creditors = new HashSet<Creditor>();
            this.Hearings = new HashSet<Hearing>();
            this.Notes = new HashSet<Note>();
        }

        public int Id { get; set; }

        [ForeignKey("Clients")]
        public int ClientId { get; set; }

        public int AttorneyId { get; set; }

        public int JudgeId { get; set; }

        public int TrusteeId { get; set; }

        public string CaseNumber { get; set; }

        public DateTime DateFiled { get; set; }

        public CaseStatus CaseStatus { get; set; }

        public virtual ICollection<CourtDocument> CourtDocuments { get; set; }

        public virtual ICollection<ClientDocument> ClientDocuments { get; set; }

        public virtual ICollection<Note> Notes { get; set; }

        public virtual ICollection<Creditor> Creditors { get; set; }

        public virtual ICollection<Hearing> Hearings { get; set; }
    }
}
