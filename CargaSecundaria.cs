using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Cansat_HMI
{
    
    public partial class CargaSecundaria : Form, IDisposable
    {
        public static String latitudEstacion, longitudEstacion, latitudSecundaria, longitudSecundaria;
        Thread thread;
        public CargaSecundaria()
        {
            
            InitializeComponent();
            //thread = new Thread(new ThreadStart(map));
            //thread.Start();
            map();
            //thread.Join();
            
        }

        void CargaSecundaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            webBrowser.Dispose();
            panelWebBrowser.Dispose();
            
        }
       

        private void CargaSecundaria_Load(object sender, EventArgs e)
        {
            

            
        }

        private void map ()
        {
            webBrowser.AllowNavigation = true;

            //Thread.Sleep(000);
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("https://www.google.com/maps/dir/");

            latitudSecundaria = "21.1483941";
            longitudSecundaria = "-100.9387494";

            if ((latitudEstacion != string.Empty) && (longitudEstacion != string.Empty))
            {
                queryAddress.Append(latitudEstacion + ',' + longitudEstacion + '/' + latitudSecundaria + ',' + longitudSecundaria + "/@" 
                    + latitudEstacion + ',' + longitudEstacion + ",19z");
                Console.WriteLine(queryAddress.ToString());

                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.Navigate(queryAddress.ToString());
            }


        //https://www.google.com/maps/dir/21.1489445803406,-100.936569587868/21.1489445803406,-100.936569587868/@21.1483941,-100.9387494,19z/data=!4m2!4m1!3e0
        //https://www.google.com/maps/dir/21.1489444,-100.9365556/21.1480989,-100.9359599/@21.14884,-100.9366788,18.17z/data=!4m2!4m1!3e0






        }
    }
}
