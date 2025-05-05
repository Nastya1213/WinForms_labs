using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int HourAll { get; set; }
        public DateTime? Endind { get; set; }
        public string Period { get; set; }

        public ICollection<SpecialSubject> SpecialSubjects { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
