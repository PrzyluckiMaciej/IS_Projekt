using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_app.ORM_classes
{
    public class ExamResult
    {
        public string rodzaj_egzaminu {  get; set; }
        public string poziom_egzaminu { get; set; }
        public string przedmiot { get; set; }
        public string plec { get; set; }
        public int rok { get; set; }
        public double wartosc { get; set; }
    }
}
