namespace PROJEKATKlk1
{
    partial class Form1
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
            this.btnOtvoriFajl = new System.Windows.Forms.Button();
            this.btnPronadjiZameni = new System.Windows.Forms.Button();
            this.btnSnimiFajl = new System.Windows.Forms.Button();
            this.btnZavrsiProgram = new System.Windows.Forms.Button();
            this.txtPronadji = new System.Windows.Forms.TextBox();
            this.txtZameni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSadrzajFajla = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOtvoriFajl
            // 
            this.btnOtvoriFajl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOtvoriFajl.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOtvoriFajl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtvoriFajl.Location = new System.Drawing.Point(26, 32);
            this.btnOtvoriFajl.Name = "btnOtvoriFajl";
            this.btnOtvoriFajl.Size = new System.Drawing.Size(102, 52);
            this.btnOtvoriFajl.TabIndex = 0;
            this.btnOtvoriFajl.Text = "Otvori Fajl";
            this.btnOtvoriFajl.UseVisualStyleBackColor = false;
            this.btnOtvoriFajl.Click += new System.EventHandler(this.btnOtvoriFajl_Click);
            // 
            // btnPronadjiZameni
            // 
            this.btnPronadjiZameni.Location = new System.Drawing.Point(387, 32);
            this.btnPronadjiZameni.Name = "btnPronadjiZameni";
            this.btnPronadjiZameni.Size = new System.Drawing.Size(102, 52);
            this.btnPronadjiZameni.TabIndex = 1;
            this.btnPronadjiZameni.Text = "Pronadji i zameni";
            this.btnPronadjiZameni.UseVisualStyleBackColor = true;
            this.btnPronadjiZameni.Click += new System.EventHandler(this.btnPronadjiZameni_Click);
            // 
            // btnSnimiFajl
            // 
            this.btnSnimiFajl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSnimiFajl.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSnimiFajl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnimiFajl.Location = new System.Drawing.Point(562, 32);
            this.btnSnimiFajl.Name = "btnSnimiFajl";
            this.btnSnimiFajl.Size = new System.Drawing.Size(102, 52);
            this.btnSnimiFajl.TabIndex = 2;
            this.btnSnimiFajl.Text = "Snimi fajl (Save As...)";
            this.btnSnimiFajl.UseVisualStyleBackColor = false;
            this.btnSnimiFajl.Click += new System.EventHandler(this.btnSnimiFajl_Click);
            // 
            // btnZavrsiProgram
            // 
            this.btnZavrsiProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZavrsiProgram.BackColor = System.Drawing.Color.IndianRed;
            this.btnZavrsiProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZavrsiProgram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZavrsiProgram.Location = new System.Drawing.Point(686, 32);
            this.btnZavrsiProgram.Name = "btnZavrsiProgram";
            this.btnZavrsiProgram.Size = new System.Drawing.Size(102, 52);
            this.btnZavrsiProgram.TabIndex = 3;
            this.btnZavrsiProgram.Text = "Zavrsi program";
            this.btnZavrsiProgram.UseVisualStyleBackColor = false;
            this.btnZavrsiProgram.Click += new System.EventHandler(this.btnZavrsiProgram_Click);
            // 
            // txtPronadji
            // 
            this.txtPronadji.Location = new System.Drawing.Point(281, 34);
            this.txtPronadji.Name = "txtPronadji";
            this.txtPronadji.Size = new System.Drawing.Size(100, 22);
            this.txtPronadji.TabIndex = 4;
            // 
            // txtZameni
            // 
            this.txtZameni.Location = new System.Drawing.Point(281, 62);
            this.txtZameni.Name = "txtZameni";
            this.txtZameni.Size = new System.Drawing.Size(100, 22);
            this.txtZameni.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pronadji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zameni:";
            // 
            // txtSadrzajFajla
            // 
            this.txtSadrzajFajla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSadrzajFajla.Location = new System.Drawing.Point(26, 106);
            this.txtSadrzajFajla.Multiline = true;
            this.txtSadrzajFajla.Name = "txtSadrzajFajla";
            this.txtSadrzajFajla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSadrzajFajla.Size = new System.Drawing.Size(762, 315);
            this.txtSadrzajFajla.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZavrsiProgram;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSadrzajFajla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZameni);
            this.Controls.Add(this.txtPronadji);
            this.Controls.Add(this.btnZavrsiProgram);
            this.Controls.Add(this.btnSnimiFajl);
            this.Controls.Add(this.btnPronadjiZameni);
            this.Controls.Add(this.btnOtvoriFajl);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Radovan Vukovic s20/18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtvoriFajl;
        private System.Windows.Forms.Button btnPronadjiZameni;
        private System.Windows.Forms.Button btnSnimiFajl;
        private System.Windows.Forms.Button btnZavrsiProgram;
        private System.Windows.Forms.TextBox txtPronadji;
        private System.Windows.Forms.TextBox txtZameni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSadrzajFajla;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

