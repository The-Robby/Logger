using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Werk_logger
{
    public partial class Form2login : Form
    {
        public Form2login()
        {
            InitializeComponent();

            //settings saven
            Properties.Settings.Default.Save();
        }

        private void txtVoornaam_TextChanged(object sender, EventArgs e)    
        {
            //voornaam in settings steken
            Properties.Settings.Default.s_Voornaam = txtVoornaam.Text.ToString();
        }

        private void txtAchternaam_TextChanged(object sender, EventArgs e)
        {
            //achternaam in settings steken
            Properties.Settings.Default.s_Achternaam = txtAchternaam.Text.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //form2 dicht
            this.Close();
        }
    }
}
