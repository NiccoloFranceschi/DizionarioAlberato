using System;
using System.Collections.Generic;

namespace DizionarioAlberato
{
    public class Albero
    {
        // --- Variabili ---
        private List<Nodo> _lettere;
        public List<Nodo> lettere { get {return _lettere;} set {_lettere = value;} }
        
        // --- Costruttori ---
        public Albero()
        {
            this.lettere = new List<Nodo>();
            lettere = new List<Nodo>();
            string[] alfabeto = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            foreach (string lettera in alfabeto)
            {
                Nodo nuovoNodo = new Nodo();
                Parola nuovaParola = new Parola(lettera, null);
                nuovoNodo.parola = nuovaParola;
                nuovoNodo.livello = 1;
                lettere.Add(nuovoNodo);
            }
        }

        // --- Funzioni ---
        // Funzione per aggiungere una parola
        public void aggiungiParola(Parola parola)
        {
            char lettera = parola.parola[0];

            foreach (Nodo principale in lettere)
            {
                if (principale.parola.parola[0].Equals(lettera))
                {
                    Nodo nodo = principale;
                    int lunghezzaParola = parola.parola.Length;
                    // Ciclo gli altri livelli
                    for (int livello = 2; livello <= 5; livello++)
                    {
                        int lunghezza = Math.Min(livello * 2 - 1, lunghezzaParola);
                        string sottostr = parola.parola.Substring(0, lunghezza);
                        
                        bool trovato = false;
                        // Cerco il figlio
                        foreach (Nodo figlio in nodo.figlio)
                        {
                            if (figlio.parola.parola.Equals(sottostr))
                            {
                                nodo = figlio;
                                trovato = true;
                                break;
                            }
                        }
                        // Se non ho trovato il figlio, lo creo
                        if (!trovato)
                        {
                            Nodo nuovoFiglio = new Nodo();
                            nuovoFiglio.parola = new Parola(sottostr, null);
                            nuovoFiglio.livello = livello;

                            if (lunghezza > 7 || lunghezza == lunghezzaParola)
                            {
                                nuovoFiglio.parola = parola;
                                nodo.aggiungiFiglio(nuovoFiglio);
                                
                                nodo = nuovoFiglio;
                                return;
                            }
                            nodo.aggiungiFiglio(nuovoFiglio);
                            nodo = nuovoFiglio;
                        }
                    }
                }
            }
        }
        
        // Funzione per cercare una parola
        public Nodo cercaParola(string parola)
        {
            char lettera = parola[0];
            foreach (Nodo principale in lettere)
            {
                if (principale.parola.parola[0].Equals(lettera))
                {
                    Nodo nodo = principale;
                    int lunghezzaParola = parola.Length;
                    // Ciclo gli altri livelli
                    for (int livello = 2; livello <= 5; livello++)
                    {
                        int lunghezza = Math.Min(livello * 2 - 1, lunghezzaParola);
                        string sottostr;

                        if (livello == 5)
                        {
                            sottostr = parola;
                        }
                        else
                        {
                            sottostr = parola.Substring(0, lunghezza);
                        }

                        bool trovato = false;
                        // Cerco il figlio
                        foreach (Nodo figlio in nodo.figlio)
                        {
                            if (figlio.parola.parola.Equals(sottostr))
                            {
                                nodo = figlio;
                                trovato = true;
                                break;
                            }
                        }
                        if (sottostr.Length == lunghezzaParola)
                        {
                            return nodo;
                        }
                        if (!trovato)
                        {
                            return null;
                        }
                    }
                }
            }
            return null;
        }
        
        // Funzione per rimuovere una parola
        public Nodo eliminaParola(Nodo brutto)
        {
            if (brutto != null)
            {
                brutto.parola.distruggiTraduzioni();
            }
            return brutto;
        }
        
        // Funzione per rimuovere una traduzione
        public Nodo cancellaTraduzione(Nodo brutto, string parola)
        {
            if (parola != null)
            {
                brutto.distruggiTraduzione(parola);
            }
            return brutto;
        }
        
        // Funzione per stampare l'albero
        public void stampaAlbero(Nodo nodoCorrente, List<Parola> parole)
        {
            if (nodoCorrente == null)
            {
                return;  
            }
            foreach (Nodo figlio in nodoCorrente.figlio)
            {
                if (figlio.parola.traduzioni != null)
                {
                    parole.Add(figlio.parola);  
                }
                stampaAlbero(figlio, parole);
            }
        }
        
    }
}