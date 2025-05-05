using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SpecialS { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<SpecialSubject> SpecialSubjects { get; set; }
        public ICollection<Journal> Journals { get; set; }
    }
}
