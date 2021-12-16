using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cascade_Backend_Developer_AssessmentTest.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public string TitleOfSource { get; set; }
        public string TitleOfContainer { get; set; }        
        public DateTime? PublicationDate { get; set; }
        public string Location { get; set; }

        public string VolumeNo { get; set; }
        public string IssueNo { get; set; }
        public string URL { get; set; }
    }
}
