using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SúlyozottAtlag2
{
    public partial class NewClass : Form
    {
        public NewClass()
        {
            InitializeComponent();
        }

        private void NewClass_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBoxClass;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool isError = false;
            try
            {
                MainForm.table.Rows.Add( txtBoxClass.Text,
                                         Convert.ToInt32(txtBoxCredit.Text),
                                         Convert.ToInt32(txtBoxGrade.Text)
                                         );
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
                isError = true;
            }
            if (!isError)
            {
                this.Close();
            }

            //InputString(txtBoxClass.Text, txtBoxClass, 1, 10);
        }

        private string InputString(string input, object sender, int min, int max)
        {
            bool isError = false;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("A mező nem lehet üres!");
                isError = true;
            }
            else if (!Regex.IsMatch(input, @"^\d+$"))
            {
                MessageBox.Show("Nem számot adott meg!");
                isError = true;
            }
            else if
           (Convert.ToInt32(input) < min || Convert.ToInt32(input) > max)
            {
                MessageBox.Show("Érvénytelen szám!");
                isError = true;
            }
            if (!isError)
            {
                return input;
            }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
