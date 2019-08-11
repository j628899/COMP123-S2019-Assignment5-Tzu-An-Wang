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
using System.Diagnostics;

namespace COMP123_S2019_Assignment5_Tzu_An_Wang.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void OpenButton_Click(object sender, EventArgs e)
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

            Program.productinfoForm.Show();
            this.Hide();
        }
    }
}
