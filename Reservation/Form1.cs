using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            ReservationModel model = new ReservationModel(Convert.ToInt32(numberOfPepoleTB.Text), dateTB.Text, timeTB.Text);
        }

    }
}
