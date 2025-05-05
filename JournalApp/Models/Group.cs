using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Scdedule> Scdedules { get; set; }
    }
}
