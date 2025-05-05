using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public int ScdeduleId { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        [ForeignKey("ScdeduleId")]
        public Scdedule Scdedule { get; set; }
    }
}
