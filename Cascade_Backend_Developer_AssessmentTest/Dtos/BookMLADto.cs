using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cascade_Backend_Developer_AssessmentTest.Dtos
{
    public class BookMLADto
    {
        public string Publisher { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public string TitleOfSource { get; set; }
        public string TitleOfContainer { get; set; }
        public string PublicationDate { get; set; }
        public string Location { get; set; }
    }
}
