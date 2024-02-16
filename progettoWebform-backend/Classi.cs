namespace progettoWebform_backend
{
    public class Articolo
    {
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string ImmagineUrl { get; set; }

        public int Quantita { get; set; }
    }
}