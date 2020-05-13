using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2.Genre_Form;

namespace Final_Project_2.GUI
{
    public partial class genre : Form
    {
        public genre()
        {
            InitializeComponent();
        }

        private void Reload_Data()
        {
            try
            {
                List<Genre> genreList = new List<Genre>();
                genreList = GenreDB.GetGenres();
                dataGridView1.DataSource = genreList;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void genre_Load(object sender, EventArgs e)
        {
            try
            {
                List<Genre> genreList = new List<Genre>();
                genreList = GenreDB.GetGenres();
                dataGridView1.DataSource = genreList;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate the UI
            if (string.IsNullOrEmpty(txtGenreID.Text.Trim()))
            {
                try
                {
                    List<Genre> genreList = new List<Genre>();
                    genreList = GenreDB.GetGenres();
                    int num = 1;
                    foreach (Genre genre in genreList)
                    {
                        if(num <= genre.ID)
                        {
                            num = genre.ID + 1;
                        }  
                    }

                    txtGenreID.Text = num.ToString();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

            if (string.IsNullOrEmpty(txtGenreName.Text.Trim()))
            {
                MessageBox.Show("Please enter a genre name.");
                txtGenreID.Focus();
                return;
            }

            Genre objGenre = new Genre();
            objGenre.ID = Convert.ToInt32(txtGenreID.Text.Trim());
            objGenre.Name = txtGenreName.Text.Trim();
            try
            {
                bool status = GenreDB.AddGenre(objGenre);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Genre added to the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Genre was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //Validate the UI
            if (string.IsNullOrEmpty(txtGenreID.Text.Trim()))
            {
                MessageBox.Show("Please enter a genre id.");
                txtGenreID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtGenreName.Text.Trim()))
            {
                MessageBox.Show("Please enter a genre name.");
                txtGenreID.Focus();
                return;
            }

            Genre objGenre = new Genre();
            objGenre.ID = Convert.ToInt32(txtGenreID.Text.Trim());
            objGenre.Name = txtGenreName.Text.Trim();
            try
            {
                bool status = GenreDB.UpdateGenre(objGenre);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Genre has been updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Genre was not updated in database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                List<Genre> genreList = new List<Genre>();
                genreList = GenreDB.GetGenres();
                dataGridView1.DataSource = genreList;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Validate the UI
            if (string.IsNullOrEmpty(txtGenreID.Text.Trim()))
            {
                MessageBox.Show("Please enter a genre id.");
                txtGenreID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtGenreName.Text.Trim()))
            {
                MessageBox.Show("Please enter a genre name.");
                txtGenreID.Focus();
                return;
            }

            Genre objGenre = new Genre();
            objGenre.ID = Convert.ToInt32(txtGenreID.Text.Trim());
            objGenre.Name = txtGenreName.Text.Trim();
            try
            {
                bool status = GenreDB.DeleteGenre(objGenre);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Genre was deleted from the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Genre was not deleted from the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGenreID.ReadOnly = false;
            txtGenreID.Text = String.Empty;
            txtGenreName.Text = String.Empty;
            dataGridView1.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGenreID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtGenreName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
