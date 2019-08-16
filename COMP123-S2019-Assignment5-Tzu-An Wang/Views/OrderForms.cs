using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace COMP123_S2019_Assignment5_Tzu_An_Wang.Views
{
    public partial class OrderForms : Form
    {
        public OrderForms()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productinfoForm.Show();
            this.Hide();
        }

        private void OrderForms_Activated(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader inputStream = new StreamReader(File.Open("Product.txt", FileMode.Open)))
                {


                    Program.productClass.ProductId = int.Parse(inputStream.ReadLine());
                    Program.productClass.Condition = inputStream.ReadLine();
                    Program.productClass.Cost = double.Parse(inputStream.ReadLine());
                    Program.productClass.Platform = inputStream.ReadLine();
                    Program.productClass.OS = inputStream.ReadLine();
                    Program.productClass.Manufactur = inputStream.ReadLine();
                    Program.productClass.Model = inputStream.ReadLine();
                    Program.productClass.RAMsize = inputStream.ReadLine();
                    Program.productClass.CPUBrand = inputStream.ReadLine();
                    Program.productClass.CPUType = inputStream.ReadLine();
                    Program.productClass.Screensize = inputStream.ReadLine();
                    Program.productClass.CPUNumber = inputStream.ReadLine();
                    Program.productClass.CPUspeed = inputStream.ReadLine();
                    Program.productClass.HDDSize = inputStream.ReadLine();
                    Program.productClass.GPUType = inputStream.ReadLine();
                    Program.productClass.WebCam = inputStream.ReadLine();

                    inputStream.Close();
                    inputStream.Dispose();
                }
            }
            catch (IOException exception)
            {

                Debug.WriteLine("ERROR: " + exception.Message);

                //MessageBox.Show("ERROR"+exception .Message, "Error",MessageBoxButtons.OK,MessageBoxIcon )
            }

            ManufactursTextBox.Text = Program.productClass.ProductId.ToString();
            ConditionTextBox.Text = Program.productClass.Condition;
            CostTextBox.Text = "$"+Program.productClass.Cost.ToString();
            PlatformTextBox.Text = Program.productClass.Platform;
            OSTextBox.Text = Program.productClass.OS;
            ManufactursTextBox.Text = Program.productClass.Manufactur;
            ModelTextBox.Text = Program.productClass.Model;
            MemoryTextBox.Text = Program.productClass.RAMsize;
            CPUBrandTextBox.Text = Program.productClass.CPUBrand;
            CPUTypeTextBox.Text = Program.productClass.CPUType;
            LCDSizeTextBox.Text = Program.productClass.Screensize;
            CPUNumberTextBox.Text = Program.productClass.CPUNumber;
            CPUSeedTextBox.Text = Program.productClass.CPUspeed;
            HDDTextBox.Text = Program.productClass.HDDSize;
            GPUTypeTextBox.Text = Program.productClass.GPUType;
            WebCamTextBox.Text = Program.productClass.WebCam;

            SalesTaxTextBox.Text = ("$"+Program.productClass.Cost * 0.13).ToString();
            TotalTextBox.Text = ("$"+Program.productClass.Cost * 1.13).ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Complete ");
            Application.Exit();
        }
    }
}
