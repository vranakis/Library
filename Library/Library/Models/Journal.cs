using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Journal(string author, string title, string publisher, int issueNo, DateTime publicationDate) : Publication(author, title, publisher)
    {
        public int IssueNo { get; set; } = issueNo;
        public DateTime PublicationDate { get; set; } = publicationDate;
    }
}
