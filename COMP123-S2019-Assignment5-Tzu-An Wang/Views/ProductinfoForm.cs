using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_Tzu_An_Wang.Views
{
    public partial class ProductinfoForm : Form
    {
        public ProductinfoForm()
        {
            InitializeComponent();
        }

        private void SelectAnotherButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
 
  
        
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductinfoForm_Activated(object sender, EventArgs e)
        {
            //try
            //{
            //    using (StreamReader inputStream = new StreamReader(File.Open("Product.txt", FileMode.Open)))
            //    {

                    
            //        Program.productClass.ProductId = int.Parse(inputStream.ReadLine());
            //        Program.productClass.Condition = inputStream.ReadLine();
            //        Program.productClass.Cost = double.Parse(inputStream.ReadLine());
            //        Program.productClass.Platform = inputStream.ReadLine();
            //        Program.productClass.OS = inputStream.ReadLine();
            //        Program.productClass.Manufactur = inputStream.ReadLine();
            //        Program.productClass.Model = inputStream.ReadLine();
            //        Program.productClass.RAMsize = inputStream.ReadLine();
            //        Program.productClass.CPUBrand = inputStream.ReadLine();
            //        Program.productClass.CPUType = inputStream.ReadLine();
            //        Program.productClass.Screensize = inputStream.ReadLine();
            //        Program.productClass.CPUNumber = inputStream.ReadLine();
            //        Program.productClass.CPUspeed = inputStream.ReadLine();
            //        Program.productClass.HDDSize = inputStream.ReadLine();
            //        Program.productClass.GPUType = inputStream.ReadLine();
            //        Program.productClass.WebCam = inputStream.ReadLine();

            //        inputStream.Close();
            //        inputStream.Dispose();
            //    }
            //}
            //catch (IOException exception)
            //{

            //    Debug.WriteLine("ERROR: " + exception.Message);

            //    //MessageBox.Show("ERROR"+exception .Message, "Error",MessageBoxButtons.OK,MessageBoxIcon )
            //}

            ProductBox.Text = Program.productClass.ProductId .ToString();
            ConditionTextBox.Text = Program.productClass.Condition;
            CostTextBox.Text = Program.productClass.Cost.ToString();
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

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputStream = new StreamWriter(
               File.Open("Product.txt", FileMode.Create)))
            {
                outputStream.WriteLine(Program.productClass.ProductId.ToString());
                outputStream.WriteLine(Program.productClass.Condition);
                outputStream.WriteLine(Program.productClass.Cost.ToString());
                outputStream.WriteLine(Program.productClass.Platform);
                outputStream.WriteLine(Program.productClass.OS);
                outputStream.WriteLine(Program.productClass.Manufactur);
                outputStream.WriteLine(Program.productClass.Model);
                outputStream.WriteLine(Program.productClass.RAMsize);
                outputStream.WriteLine(Program.productClass.CPUBrand);
                outputStream.WriteLine(Program.productClass.CPUType);
                outputStream.WriteLine(Program.productClass.Screensize);
                outputStream.WriteLine(Program.productClass.CPUNumber);
                outputStream.WriteLine(Program.productClass.CPUspeed);
                outputStream.WriteLine(Program.productClass.HDDSize);
                outputStream.WriteLine(Program.productClass.GPUType);
                outputStream.WriteLine(Program.productClass.WebCam);
                outputStream.Close();
                outputStream.Dispose();
                NextButton.Enabled = true;

                MessageBox.Show("File Saved Successfully!", "Saving...",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
