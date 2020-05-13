using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2.GUI;

namespace Final_Project_2
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            genre newForm = new genre();
            newForm.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Credentials newForm = new Credentials();
            newForm.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            memberForm newForm = new memberForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movieForm newForm = new movieForm();
            newForm.Show();
        }
    }
}
