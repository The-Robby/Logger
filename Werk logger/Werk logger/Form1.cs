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


namespace Werk_logger
{
    public partial class Form1 : Form
    {
        private class TimeEntry
        {
            public DateTime date { get; set; }
            public string Order { get; set; }
            public string Actie { get; set; }
            public string Glans { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //open login form
            Form2login login = new Form2login();
            //open modal
            login.ShowDialog();

        }
        private void dateDatum_ValueChanged(object sender, EventArgs e)
        {
            //Global.s_Datum = dateDatum.Value.ToString();
        }
        private void dateUur_ValueChanged(object sender, EventArgs e)
        {
            //Global.s_Uur = dateUur.Value.ToString();
        }
        private void txtOrder_TextChanged(object sender, EventArgs e)
        {
            //Order = txtOrder.Text.ToString();
            
        }
        private void txtActie_TextChanged(object sender, EventArgs e)
        {
            //Global.s_Actie = txtActie.Text.ToString();
        }
        private void txtGlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Global.s_Glans = txtGlans.Text.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newEntryToSave = new TimeEntry() {
                date = dateUur.Value,
                Order = txtOrder.Text,
                Actie = txtActie.Text,
                Glans = txtGlans.Text,
            };
            var path = "log.txt";
            var newTextEntry = string.Format("Op {0} deed {1}: Order {2}, Actie: {3}, Glans: {4}. \n", newEntryToSave.date, Properties.Settings.Default.s_Voornaam + " " + Properties.Settings.Default.s_Achternaam, newEntryToSave.Order, newEntryToSave.Actie, newEntryToSave.Glans);
            File.AppendAllText(path, newTextEntry);
        }
    }
}
