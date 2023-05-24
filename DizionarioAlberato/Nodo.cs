using System;
using System.Collections.Generic;

namespace DizionarioAlberato
{
    public class Nodo : IComparable<Nodo>
    {
        // --- Variabili ---
        List<Nodo> _figlio;
        private Parola _parola;
        private int _livello;
        public List<Nodo> figlio { get {return _figlio;} set {_figlio = value;} }
        public Parola parola { get {return _parola;} set {_parola = value;} }
        public int livello { get {return _livello;} set {_livello = value;} }

        // --- Costruttori ---
        public Nodo(List<Nodo> figlio, Parola parola, int livello)
        {
            _figlio = figlio;
            _parola = parola;
            _livello = livello;
        }
        public Nodo(): this(new List<Nodo>(), null, 0){}
        
        // --- Funzioni ---
        // Funzione per aggiungere una traduzione alla parola
        public void aggiungiTraduzione(string traduzione)
        {
            parola.traduzioni.Add(traduzione);
            parola.traduzioni.Sort();
        }
        
        // funzione che elimina una traduzione specifica
        public void distruggiTraduzione(string traduzione)
        {
            if (parola.traduzioni != null)
                for (int i = 0; i < parola.traduzioni.Count; i++)
                    if (parola.traduzioni[i].Equals(traduzione))
                    {
                        //parola.traduzioni.RemoveAt(i);
                        parola.traduzioni[i] = null;
                        return;
                    }
        }
        
        // Funzione per aggiungere un figlio
        public void aggiungiFiglio(Nodo figlio)
        {
            _figlio.Add(figlio);
            _figlio.Sort();
        }

        // Funzione per compararlo ad un altro nodo
        public int CompareTo(Nodo other)
        {
            return this.parola.parola.CompareTo(other._parola.parola);
        }
    }
}