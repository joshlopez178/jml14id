using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            monthgroupBox.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            searchTxt.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            monthgroupBox.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
