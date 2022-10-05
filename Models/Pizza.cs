public class Pizza
{
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Immagine { get; set; }
        public double Prezzo { get; set; }

        public Pizza()
        {

        }
        public Pizza(string nome, string descrizione, string immagine, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Immagine = immagine;
            Prezzo = prezzo;
        }
}
