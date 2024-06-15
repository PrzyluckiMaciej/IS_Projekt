namespace Server_app.Entities
{
    public class ExamResult
    {
        public string rodzaj_egzaminu { get; set; }
        public string poziom_egzaminu { get; set; }
        public string przedmiot { get; set; }
        public string plec { get; set; }
        public int rok { get; set; }
        public double wartosc { get; set; }
    }
}
