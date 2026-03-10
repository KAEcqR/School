using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_EF_Sqlite.Models
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Grupa")]
        public string Group { get; set; }

        [DisplayName("Data utworzenia")]
        public DateTime CreatedAt { get; set; }
    }
}