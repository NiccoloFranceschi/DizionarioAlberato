using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizionarioAlberato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // --- Variabili ---
        Albero dizionarioItaliano = new Albero();
        Albero dizionarioInglese = new Albero();
        Nodo parolaItaliana;
        Nodo parolaInglese;

        // --- Start Form ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Carico tutto il dizionario
            FileStream fs = new FileStream("Dizionario.txt", FileMode.OpenOrCreate);
            caricaDizionario(fs);
        }

        // --- Pulsanti ---

        // ++ ITALIANO ++
        // Pulsante per cercare una parola italiana
        private void btnCercaItaliano_Click(object sender, EventArgs e)
        {
            if (txtCercaItaliano.Text != "")
            {
                parolaItaliana = ricerca(txtCercaItaliano.Text, lbxInglese, dizionarioItaliano);
                if (parolaItaliana == null)
                {
                    MessageBox.Show("La parola cercata non esiste!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblParola.Text = "Dizionario";
                }
                lblParola.Text = txtCercaItaliano.Text;
            }
            else
            {
                MessageBox.Show("Non hai inserito nessuna parola!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtCercaItaliano.Text = "";
        }

        // Pulsante per eliminare una parola
        private void btnEliminaParola_Click(object sender, EventArgs e)
        {
            if (eliminaParola(parolaItaliana, dizionarioItaliano))
            {
                parolaItaliana = null;
                MessageBox.Show("La parola è stata eliminata!", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La parola non esiste!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtCercaItaliano.Text = "";
        }

        // ++ INGLESE ++
        // Pulsante per cercare una parola inglese
        private void btnCercaInglese_Click(object sender, EventArgs e)
        {
            if (txtCercaInglese.Text != "")
            {
                parolaInglese = ricerca(txtCercaInglese.Text, lbxItaliano, dizionarioInglese);
                if (parolaInglese == null)
                {
                    MessageBox.Show("La parola cercata non esiste!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblParola.Text = "Dizionario";
                }
                lblParola.Text = txtCercaInglese.Text;
            }
            else
            {
                MessageBox.Show("Non hai inserito nessuna parola!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtCercaInglese.Text = "";
        }

        // Bottone per eliminare la traduzione
        private void btnEliminaTraduzione_Click_1(object sender, EventArgs e)
        {
            string traduzioneSelezionata = lbxInglese.Text.ToString();

            if (eliminaTraduzione(parolaItaliana, dizionarioInglese, traduzioneSelezionata))
            {
                MessageBox.Show("La traduzione è stata eliminata!", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La parola non esiste!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtCercaItaliano.Text = "";
        }

        // ++ Inserimento Parole ++
        // Bottone per inserire le parole
        private void btnAggiungiParola_Click(object sender, EventArgs e)
        {
            if (txtAggiungiItaliano.Text != "" && txtAggiungiInglese.Text != "")
            {
                aggiungiParola(txtAggiungiItaliano, txtAggiungiInglese);
                MessageBox.Show("La parola è stata aggiunta!", "Aggiunta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAggiungiItaliano.Text = "";
                txtAggiungiInglese.Text = "";
            }
            else
            {
                MessageBox.Show("Completa tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // --- Funzioni ---
        // Funzione per aggiungere una parola
        private Parola aggiungiParola(TextBox tbxParolaItaliana, TextBox tbxParolaInglese)
        {
            Parola parola = new Parola();
            parola.parola = tbxParolaItaliana.Text;
            parola.traduzioni.Add(tbxParolaInglese.Text);
            dizionarioItaliano.aggiungiParola(parola);

            Parola word = new Parola();
            word.parola = tbxParolaInglese.Text;
            word.traduzioni.Add(tbxParolaItaliana.Text);
            dizionarioInglese.aggiungiParola(parola);

            return parola;
        }
        
        // Funzione per cercare una parola
        private Nodo ricerca(string parola, ListBox lista, Albero albero)
        {
            Nodo nodo = albero.cercaParola(parola);
            aggiornaListbox(nodo, lista);
            return nodo;
        }
        
        // Funzione per eliminare una parola
        private bool eliminaParola(Nodo parola, Albero albero)
        {
            if (parola != null)
            {
                albero.eliminaParola(parola);
                return true;
            }
            return false;
        }

        private bool eliminaTraduzione(Nodo parola, Albero albero, String traduzione) 
        {
            if (parola != null)
            {
                albero.cancellaTraduzione(parola, traduzione);
                return true;
            }
            return false;
        }
        
        // Funzione per aggiurnare le ListBox
        private void aggiornaListbox(Nodo nodo, ListBox lbx)
        {
            lbx.Items.Clear();
            if (nodo != null)
            {
                if (nodo.parola.traduzioni != null)
                {
                    foreach (string traduzione in nodo.parola.traduzioni)
                    {
                        lbx.Items.Add(traduzione);
                    }
                }
            }
        }

        // Carica il dizionario da file
        private void caricaDizionario(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string[] traduzioniPaola = sr.ReadLine().Trim(';').Split(':');
                Parola parola = new Parola();
                parola.parola = traduzioniPaola[0];
                if (traduzioniPaola.Length > 1)
                {
                    string[] traduzioni = traduzioniPaola[1].Split(';');
                    for (int i = 0; i < traduzioni.Length; i++)
                    {
                        parola.traduzioni.Add(traduzioni[i]);
                    }  
                }
                foreach (string traduzione in parola.traduzioni)
                {
                    Parola nuovaParola = new Parola();
                    nuovaParola.parola = traduzione;
                    nuovaParola.traduzioni.Add(parola.parola);
                    if (nuovaParola.parola != "")
                    {
                        dizionarioInglese.aggiungiParola(nuovaParola);
                    } 
                }
                if (parola.parola != "")
                {
                    dizionarioItaliano.aggiungiParola(parola);
                }                    
            }
            fs.Close();
        }

        // Funzione per salvare le parole nel file
        private void salva(List<Parola> parole)
        {
            FileStream fs = new FileStream("Dizionario.txt", FileMode.OpenOrCreate);
            StreamWriter salva = new StreamWriter(fs);
            
            foreach (Parola parola in parole)
            {
                salva.WriteLine(parola.stampaSelezione());
            }
            salva.Close();
            fs.Close();
        }

        // Funzione per salvare tutto quando chiudo il programma
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show(this, "Vuoi salvare le modifiche?", "Uscita", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    List<Parola> parole = new List<Parola>();
                    foreach (Nodo root in dizionarioItaliano.lettere)
                    {
                        dizionarioItaliano.stampaAlbero(root, parole);
                    }
                    salva(parole);
                    MessageBox.Show("File salvato!", "Confermato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}