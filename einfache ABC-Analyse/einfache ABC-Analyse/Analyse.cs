using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataTable Daten = Table();
            Daten = Datenbankzugriff.Server_zum_verbinden(Daten);
            Daten_eintragen(Daten);
            Spalten_hinzufügen();
            einfache_Berechnungen();
            sortierbar_machen();
            dataGridView_sortieren();
        }

        private DataTable Table()
        {
            DataTable Daten = new DataTable();
            return Daten;
        }

        private void Daten_eintragen(DataTable Daten)
        {
            dgv_Anzeige.DataSource = Daten;
        }

        private void einfache_Berechnungen()
        {
            double Gesamtmenge = 0;
            double Gesamtwert = 0;

            for (int a = 0; a < dgv_Anzeige.RowCount; a++)
            {
                //Gesamtmenge berechnen
                Gesamtmenge = Gesamtmenge + Convert.ToDouble(dgv_Anzeige.Rows[a].Cells[2].Value);
            }

            for (int c = 0; c < dgv_Anzeige.RowCount; c++)
            {
                //absoluten Wert berechnen
                dgv_Anzeige.Rows[c].Cells[4].Value = Convert.ToDouble(dgv_Anzeige.Rows[c].Cells[2].Value) * Convert.ToDouble(dgv_Anzeige.Rows[c].Cells[3].Value);
            }

            for (int d = 0; d < dgv_Anzeige.RowCount; d++)
            {
                //Menge in Prozent berechnen
                dgv_Anzeige.Rows[d].Cells[5].Value = Math.Round((Convert.ToDouble(dgv_Anzeige.Rows[d].Cells[2].Value) / Gesamtmenge) * 100);
            }

            for (int b = 0; b < dgv_Anzeige.RowCount; b++)
            {
                //Gesamtwert berechnen
                Gesamtwert += Convert.ToDouble(dgv_Anzeige.Rows[b].Cells[4].Value);
            }

            for (int e = 0; e < dgv_Anzeige.RowCount; e++)
            {
                //Wert in Prozent berechnen
                dgv_Anzeige.Rows[e].Cells[6].Value = Math.Round(Convert.ToDouble(dgv_Anzeige.Rows[e].Cells[4].Value) *100 / Gesamtwert);
            }
        }

        public void sortierbar_machen()
        {

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv_Anzeige.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv_Anzeige.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            dgv_Anzeige.Columns.Clear();
            dgv_Anzeige.DataSource = dt;

        }

        private void dataGridView_sortieren()
        {
            dgv_Anzeige.Sort(dgv_Anzeige.Columns[4], ListSortDirection.Descending);
        }

        private void Kategorien_errechnen()
        {

        }

        private void Spalten_hinzufügen()
        {
            //Spalten hinzufügen
            dgv_Anzeige.Columns.Add("absolute_Werte", "absolute Werte");
            dgv_Anzeige.Columns.Add("Menge_in_Prozent", "Menge in %");
            dgv_Anzeige.Columns.Add("Wert_in_Prozent", "Wert in %");
            dgv_Anzeige.Columns.Add("Kategorie", "Kategorie");
        }
    }
}
