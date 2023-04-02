using System;
using System.Device.Location;
using System.Windows.Forms;



namespace Cansat_HMI
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            CustomDesign();
            OpenChildFrom(new Inicio());



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            bool started = watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
            if (!started)
            {
                Console.WriteLine("GeoCoordinateWatcher timed out on start.");
            }

            watcher.PositionChanged += (S, E) =>
            {
                CargaSecundaria.latitudEstacion = E.Position.Location.Latitude.ToString();
                CargaSecundaria.longitudEstacion = E.Position.Location.Longitude.ToString();
                //var oCoordinate = E.Position.Location;
                Console.WriteLine(CargaSecundaria.latitudEstacion + CargaSecundaria.longitudEstacion);

            };

        }

        #region Design Private Functions
        private void CustomDesign()
        {
            dataPanel.Visible = false;
        }

        private void HideSubMenu()
        {
            if (dataPanel.Visible)
            {
                dataPanel.Visible = false;
            }

        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region Start
        private void startButton_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Inicio());
            //TODO
            HideSubMenu();
        }
        #endregion

        #region Data
        private void dataButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(dataPanel);
        }

        private void primaryDataButton_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new CargaPrimaria());
            //TODO
            HideSubMenu();
        }

        private void secondaryDataButton_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new CargaSecundaria());
            //TODO
            HideSubMenu();
        }
        #endregion

        #region Config
        private void configButton_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Configuracion());
            //TODO
            HideSubMenu();
        }
        #endregion

        #region Exit
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private Form activeForm = null;

        private void OpenChildFrom(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
