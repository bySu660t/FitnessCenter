using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            CustomerForm custF = new CustomerForm(this);
            custF.Show();
            this.Hide();
        }

        private void coachesButton_Click(object sender, EventArgs e)
        {
            TrainerForm trF = new TrainerForm(this);
            trF.Show();
            this.Hide();
        }
    }
}
