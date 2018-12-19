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
using System.Security.Cryptography;
using System.IO;

namespace SúlyozottAtlag2
{
    public partial class MainForm : Form
    {
        public static DataTable table = new DataTable();
        int clickCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //SetupSampleData();
            //SetupCollumns();
            dataGrid.DataSource = table;
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //dataGrid.Columns[0].ReadOnly = true;
            //dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[0].Width = 255;
            CalculateWeightedAverage();
        }

        private void SetupCollumns()
        {
            table.TableName = "SulyozottAtlag";

            table.Columns.Add("Tantárgyak", typeof(string));
            table.Columns["Tantárgyak"].ReadOnly = true;
            table.Columns.Add("Kreditek", typeof(int));
            table.Columns["Kreditek"].ReadOnly = true;
            table.Columns.Add("Osztályzatok", typeof(int));
        }

        private void SetupSampleData()
        {
            table.Columns.Add("Tantárgyak", typeof(string));
            table.Columns.Add("Kreditek", typeof(int));
            table.Columns.Add("Osztályzatok", typeof(int));

            table.Rows.Add("Formális Nyelvek", 5, 2);
            table.Rows.Add("Elemi Programozás", 5, 2);
            table.Rows.Add("Kalkulus 1", 5, 2);
        }

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if ("NewClass" == form.Name)
                {
                    isOpen = true;
                }
            }

            if (!isOpen)
            {
                NewClass newClass = new NewClass();
                newClass.Owner = this;
                newClass.StartPosition = FormStartPosition.CenterParent;
                newClass.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGrid.CurrentCell.RowIndex;
            dataGrid.Rows.RemoveAt(rowIndex);
            CalculateWeightedAverage();
        }

        private void CalculateWeightedAverage()
        {
            float sumGrades = 0;
            float sumCredits = 0;
            float average = 0.00f;
            try
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    sumCredits += Convert.ToSingle(row.Cells[1].Value);
                    sumGrades += (Convert.ToSingle(row.Cells[2].Value) * Convert.ToSingle(row.Cells[1].Value));
                }
                average = sumGrades / sumCredits;
                labelAtlag.Text = average.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CalculateWeightedAverage();
        }

        private void dataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dataGrid.Columns[e.ColumnIndex].HeaderText;

            if (!headerText.Equals("Osztályzatok")) return;

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGrid.Rows[e.RowIndex].ErrorText = "Nem lehet üres!";
                e.Cancel = true;
            }else if( !Regex.IsMatch(e.FormattedValue.ToString(), @"^\d+$"))
            {
                dataGrid.Rows[e.RowIndex].ErrorText = "Nem számot adott meg!";
                e.Cancel = true;
            }else if
            (Convert.ToInt32(e.FormattedValue) < 1 || Convert.ToInt32(e.FormattedValue) > 5 )
            {
                dataGrid.Rows[e.RowIndex].ErrorText = "Érvénytelen osztályzat!";
                e.Cancel = true;
            }
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void SaveData()
        {
            try
            {
                table.WriteXml("..\\data.xml", XmlWriteMode.WriteSchema);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                table.ReadXml("..\\data.xml");
            }
            catch (FileNotFoundException)
            {
                SetupCollumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelSulyozott_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 5 == 0)
            {
                MessageBox.Show("HA ELOLVASOD BUZI VAGY!!!");
            }
        }
    }
}
