using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Access;

namespace einfache_ABC_Analyse
{
    public partial class Analyse : Form
    {
        public Analyse()
        {
            InitializeComponent();
        }

        private void Analyse_Load(object sender, EventArgs e)
        {
            Datenbankzugriff.Server_zum_verbinden();
            Daten_eintragen();
            Spalten_hinzufügen();
            Berechnungen();
        }

        private void Daten_eintragen()
        {
            dgv_Anzeige.DataSource = Access.Daten;
        }

        private void Berechnungen()
        {
            double Gesamtmenge = 0;
            double Gesamtwert = 0;

            for (int b = 0; b < dgv_Anzeige.RowCount; b++)
            {
                //Gesamtmenge berechnen
                Gesamtmenge = Gesamtmenge + Convert.ToDouble(dgv_Anzeige.Rows[b].Cells[2].Value);
                //Gesamtwert berechnen
                Gesamtwert = Gesamtwert + Convert.ToDouble(dgv_Anzeige.Rows[b].Cells[3].Value);
            }

            for (int a = 0; a < dgv_Anzeige.RowCount; a++)
            {
                //absoluten Wert berechnen
                dgv_Anzeige.Rows[a].Cells[4].Value = Convert.ToDouble(dgv_Anzeige.Rows[a].Cells[2].Value) * Convert.ToDouble(dgv_Anzeige.Rows[a].Cells[3].Value);
                //Menge in Prozent berechnen
                dgv_Anzeige.Rows[a].Cells[5].Value = Math.Round((Convert.ToDouble(dgv_Anzeige.Rows[a].Cells[2].Value) / Gesamtmenge) * 100);
            }
        }

        private void Spalten_hinzufügen()
        {
            //Spalten hinzufügen
            dgv_Anzeige.Columns.Add("absolute_Werte", "absolute Werte");
            dgv_Anzeige.Columns.Add("Menge_in_Prozent", "Menge in %");
            dgv_Anzeige.Columns.Add("Wert_in_Prozent", "Wert in %");
        }
    }
}
