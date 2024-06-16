namespace Hotel
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView2 = new System.Windows.Forms.ListView();
            this.Broj_Sobe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta_Sobe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena_Sobe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status_Sobe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj_Osoba_Sobe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Broj_Sobe,
            this.Vrsta_Sobe,
            this.Cijena_Sobe,
            this.Status_Sobe,
            this.Broj_Osoba_Sobe});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(482, 183);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Broj_Sobe
            // 
            this.Broj_Sobe.Text = "Broj";
            this.Broj_Sobe.Width = 50;
            // 
            // Vrsta_Sobe
            // 
            this.Vrsta_Sobe.Text = "Vrsta";
            this.Vrsta_Sobe.Width = 90;
            // 
            // Cijena_Sobe
            // 
            this.Cijena_Sobe.DisplayIndex = 3;
            this.Cijena_Sobe.Text = "Cijena";
            this.Cijena_Sobe.Width = 80;
            // 
            // Status_Sobe
            // 
            this.Status_Sobe.DisplayIndex = 4;
            this.Status_Sobe.Text = "Status";
            this.Status_Sobe.Width = 90;
            // 
            // Broj_Osoba_Sobe
            // 
            this.Broj_Osoba_Sobe.DisplayIndex = 2;
            this.Broj_Osoba_Sobe.Text = "Broj osoba";
            this.Broj_Osoba_Sobe.Width = 100;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 183);
            this.Controls.Add(this.listView2);
            this.Name = "Form6";
            this.Text = "Odaberi sobu:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Broj_Sobe;
        private System.Windows.Forms.ColumnHeader Vrsta_Sobe;
        private System.Windows.Forms.ColumnHeader Cijena_Sobe;
        private System.Windows.Forms.ColumnHeader Status_Sobe;
        private System.Windows.Forms.ColumnHeader Broj_Osoba_Sobe;
    }
}