using COMP123_S2019_Assignment5_Tzu_An_Wang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_Tzu_An_Wang.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        public bool HasLoadedDataSource()
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                if (productBindingSource.DataSource !=null)
                {
                    return true;
                }
            }
            return false;
        }
        private void SelectForm_Load(object sender, EventArgs e)
        {

            if(!HasLoadedDataSource())
            {
                MessageBox.Show("DataSource Not Loaded", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productinfoForm.Show();
            this.Hide();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductDataGridView.CurrentCell != null)
            { 
            var currentCell = ProductDataGridView.CurrentCell;
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = currentRow.Cells;

            currentRow.Selected = true;

            string outputString = string.Empty;

            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value + " ";
            }

            SelectionTextBox.Text = outputString;


                Program.productClass.ProductId = int.Parse(cells[0].Value.ToString());
                Program.productClass.Cost = double.Parse(cells[1].Value.ToString());
                Program.productClass.Manufactur = cells[2].Value.ToString();
                Program.productClass.Model = cells[3].Value.ToString();
                Program.productClass.RAMsize = cells[4].Value.ToString();
                Program.productClass.Displatype = cells[5].Value.ToString();
                Program.productClass.Screensize = cells[6].Value.ToString();
                Program.productClass.Resolution = cells[7].Value.ToString();
                Program.productClass.CPUClass = cells[8].Value.ToString();
                Program.productClass.CPUBrand = cells[9].Value.ToString();
                Program.productClass.CPUType = cells[10].Value.ToString();
                Program.productClass.CPUspeed = cells[11].Value.ToString();
                Program.productClass.CPUNumber = cells[12].Value.ToString();
                Program.productClass.Condition = cells[13].Value.ToString();
                Program.productClass.OS = cells[14].Value.ToString();
                Program.productClass.Platform = cells[15].Value.ToString();
                Program.productClass.HDDSize = cells[16].Value.ToString();
                Program.productClass.HDDSpeed = cells[17].Value.ToString();
                Program.productClass.GPUType = cells[18].Value.ToString();
                Program.productClass.OpticalDrive = cells[19].Value.ToString();
                Program.productClass.AudoType = cells[20].Value.ToString();
                Program.productClass.LAN = cells[21].Value.ToString();
                Program.productClass.WiFi = cells[22].Value.ToString();
                Program.productClass.Width = cells[23].Value.ToString();
                Program.productClass.Heigh = cells[24].Value.ToString();
                Program.productClass.Depth = cells[25].Value.ToString();
                Program.productClass.Weight = cells[26].Value.ToString();
                Program.productClass.MoustType = cells[27].Value.ToString();
                Program.productClass.Power = cells[28].Value.ToString();
                Program.productClass.WebCam = cells[29].Value.ToString();


            }

        }
    }
}
