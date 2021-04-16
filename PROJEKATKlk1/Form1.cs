using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROJEKATKlk1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOtvoriFajl_Click(object sender, EventArgs e)
        {
            try
            { 
                openFileDialog1.Filter = "Tekst fajlovi|*.txt|CSV fajlovi|*.csv";

                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

                string imeFajla = openFileDialog1.FileName;

                txtSadrzajFajla.Text = OtvoriFajl(imeFajla);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        public string OtvoriFajl(string imeFajla)
        {
            try
            { 
                System.IO.StreamReader fajl = new System.IO.StreamReader(imeFajla);
                string tekst = fajl.ReadToEnd();
                fajl.Close();
                return tekst;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return "Greska u citanju fajla!";
            }
            
        }

        private void btnPronadjiZameni_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtSadrzajFajla.Text.Trim().Length == 0) throw new Exception("Nema teksta u glavnoj TextBox kontroli!");
                if (txtPronadji.Text.Trim().Length == 0) throw new Exception("Niste uneli tekst koji pretrazujete!");
                if (txtZameni.Text.Trim().Length == 0) throw new Exception("Tekst za zamenu ne postoji!");


                txtSadrzajFajla.Text = txtSadrzajFajla.Text.Replace(txtPronadji.Text, txtZameni.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        public bool SacuvajFajl(string imeFajla, string tekst)
        {
            try
            {
                StreamWriter sw = new StreamWriter(imeFajla, false);
                sw.Write(tekst);
                sw.Flush();
                sw.Close();
                return true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void btnZavrsiProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSnimiFajl_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtSadrzajFajla.Text.Trim().Length == 0) throw new Exception("Nema teksta u glavnoj TextBox kontroli!");

                saveFileDialog1.Filter = "Tekst fajlovi|*.txt|CSV fajlovi|*.csv";

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;    

                string imeFajla = saveFileDialog1.FileName;

                if(SacuvajFajl(imeFajla, txtSadrzajFajla.Text) == true)
                {
                    MessageBox.Show("Fajl je uspesno snimljen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fajl nije snimljen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
