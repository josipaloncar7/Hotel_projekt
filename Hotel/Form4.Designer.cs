namespace Hotel
{
    partial class Form4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ime_Hotela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad_Hotela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zvjezdice_Hotela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime_Hotela,
            this.Grad_Hotela,
            this.Zvjezdice_Hotela});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(432, 183);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ime_Hotela
            // 
            this.Ime_Hotela.Text = "Ime";
            this.Ime_Hotela.Width = 100;
            // 
            // Grad_Hotela
            // 
            this.Grad_Hotela.Text = "Grad";
            this.Grad_Hotela.Width = 100;
            // 
            // Zvjezdice_Hotela
            // 
            this.Zvjezdice_Hotela.Text = "Zvjezdice";
            this.Zvjezdice_Hotela.Width = 100;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Odaberi hotel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ime_Hotela;
        private System.Windows.Forms.ColumnHeader Grad_Hotela;
        private System.Windows.Forms.ColumnHeader Zvjezdice_Hotela;
    }
}