using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Models
{
    public class SpecialSubject
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
        public ICollection<Scdedule> Scdedules { get; set; }
    }
}
