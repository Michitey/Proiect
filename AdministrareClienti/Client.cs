
using System;
using System.Collections;


namespace AdministrareClienti
{
    public class Client
    {
        public static int IdUltimClient { get; set; }
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string NrTelefon { get; set; }
        public string EMail { get; set; }
        public string locatie { get; set; }
        public string DataLivrarii { get; set; }
        public string DataPredarii { get; set; }
        public string Serie { get; set; }
        static void Main(string[] args)
        {
        }
        public Client(string _nume, string _prenume, string _CNP, string _NrTelefon, string _EMail,string _Serie,string _Locatie,string _DataLivrarii,string _DataPredarii)
        {
            Nume = _nume;
            Prenume = _prenume;
            CNP = _CNP;
            NrTelefon = _NrTelefon;
            EMail = _EMail;
            locatie = _Locatie;
            Serie = _Serie;
            DataPredarii = _DataPredarii;
            DataLivrarii = _DataLivrarii;
            IdUltimClient++;
            Id = IdUltimClient;

        }
        public string ConversieLaSir()
        {
            
            string c = string.Format("Id: {0}, Nume: {1} {2}, CNP: {3}, NrTelefon: {4},  " +
                " E-Mail: {5},  Serie masina: {6}  Locatie: {7},  DataLivrarii: {8},  DataPredarii: {9}", Id.ToString(),
                (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "),(CNP ?? " NECUNOSCUT "), 
                (NrTelefon ?? " NECUNOSCUT "), (EMail ?? " NECUNOSCUT "),Serie,locatie,DataLivrarii,DataPredarii);

            return c;
        }
    }
}
