using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Models
{
    public class Scdedule
    {
        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int ClassId { get; set; }
        public int? SpecialSubjectId { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        [ForeignKey("SpecialSubjectId")]
        public SpecialSubject SpecialSubject { get; set; }
        public ICollection<Journal> Journals { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
