using System.Collections.Generic;

namespace DizionarioAlberato
{
    public class Parola
    {
        // --- Variabili ---
        private string _parola;
        private List<string> _traduzioni;
        public string parola { get { return _parola; } set { _parola = value; } }
        public List<string> traduzioni { get { return _traduzioni; } set { _traduzioni = value; } }
        
        // --- Costruttori ---
        public Parola(string parola, List<string> traduzioni)
        {
            this.parola = parola;
            this.traduzioni = traduzioni;
        }
        public Parola(): this("Roberto", new List<string>()){}
        
        // --- Funzioni ---
        // funzione per stampare una parola e traduzioni
        public string stampaSelezione()
        {
            string selezione = parola + ":";
            foreach (string traduzione in traduzioni)
            {
                selezione += traduzione + ";";  
            }
            return selezione;
        }
        
        // Funzione per eliminare una parola completa
        public void distruggiTraduzioni()
        {
            parola = null;
            traduzioni = null;
        }
    }
}