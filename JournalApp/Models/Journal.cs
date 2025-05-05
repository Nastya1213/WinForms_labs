using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Models
{
    public class Journal
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Value { get; set; }
        public int ScdeduleId { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        [ForeignKey("ScdeduleId")]
        public Scdedule Scdedule { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
    }
}
