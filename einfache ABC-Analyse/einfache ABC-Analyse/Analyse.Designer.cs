namespace einfache_ABC_Analyse
{
    partial class Analyse
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Container = new System.Windows.Forms.SplitContainer();
            this.dgv_Anzeige = new System.Windows.Forms.DataGridView();
            this.b_berechnen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            this.Container.Panel1.SuspendLayout();
            this.Container.Panel2.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Anzeige)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Container.Panel1
            // 
            this.Container.Panel1.Controls.Add(this.dgv_Anzeige);
            // 
            // Container.Panel2
            // 
            this.Container.Panel2.Controls.Add(this.b_berechnen);
            this.Container.Size = new System.Drawing.Size(926, 537);
            this.Container.SplitterDistance = 451;
            this.Container.TabIndex = 0;
            // 
            // dgv_Anzeige
            // 
            this.dgv_Anzeige.AllowUserToAddRows = false;
            this.dgv_Anzeige.AllowUserToDeleteRows = false;
            this.dgv_Anzeige.AllowUserToResizeColumns = false;
            this.dgv_Anzeige.AllowUserToResizeRows = false;
            this.dgv_Anzeige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Anzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Anzeige.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Anzeige.Location = new System.Drawing.Point(0, 0);
            this.dgv_Anzeige.Name = "dgv_Anzeige";
            this.dgv_Anzeige.ReadOnly = true;
            this.dgv_Anzeige.Size = new System.Drawing.Size(926, 451);
            this.dgv_Anzeige.TabIndex = 0;
            // 
            // b_berechnen
            // 
            this.b_berechnen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_berechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_berechnen.Location = new System.Drawing.Point(0, 0);
            this.b_berechnen.Name = "b_berechnen";
            this.b_berechnen.Size = new System.Drawing.Size(926, 82);
            this.b_berechnen.TabIndex = 0;
            this.b_berechnen.Text = "Berechnen";
            this.b_berechnen.UseVisualStyleBackColor = true;
            // 
            // Analyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 537);
            this.Controls.Add(this.Container);
            this.Name = "Analyse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Analyse_Load);
            this.Container.Panel1.ResumeLayout(false);
            this.Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Anzeige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Container;
        private System.Windows.Forms.DataGridView dgv_Anzeige;
        private System.Windows.Forms.Button b_berechnen;
    }
}

