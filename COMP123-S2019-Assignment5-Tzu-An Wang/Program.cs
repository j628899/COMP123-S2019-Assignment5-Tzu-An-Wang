using COMP123_S2019_Assignment5_Tzu_An_Wang.Models;
using COMP123_S2019_Assignment5_Tzu_An_Wang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace COMP123_S2019_Assignment5_Tzu_An_Wang
{
    public static class Program
    {
        public static SelectForm selectForm;
        public static StartForm startForm;
        public static SplashForm splashForm;
        public static OrderForms orderForm;
        public static ProductinfoForm productinfoForm;
        public static AboutForm aboutForm;
        public static Splash_Screen splash_Screen;
        public static Product product;
        public static ProductClass productClass;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            orderForm = new OrderForms();
            productinfoForm = new ProductinfoForm();
            aboutForm = new AboutForm();
            splash_Screen = new Splash_Screen();
            product = new Product();
            productClass = new ProductClass();
            Application.Run(splash_Screen);
        }
    }
}
