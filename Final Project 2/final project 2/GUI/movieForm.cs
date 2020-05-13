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

namespace Final_Project_2
{
    public partial class movieForm : Form
    {
        public movieForm()
        {
            InitializeComponent();
        }

        private void Reload_Data()
        {
            List<Movie> movieList = new List<Movie>();
            movieList = MovieDB.GetMovie();
            dataGridView1.DataSource = movieList;
        }

        private void SelectionFill()
        {

            txtMovieNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYear.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbGenre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbRating.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbMediaType.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtRetailCost.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtRentalCost.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtCopies.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtImage.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtTrailer.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movieForm_Load(object sender, EventArgs e)
        {
            Reload_Data();

            List<Genre> GenreList = GenreDB.GetGenres();
            foreach (Genre genre in GenreList)
            {
                cmbGenre.Items.Add(genre.Name);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            foreach (Control textBox in this.Controls)
            {
                if (textBox.GetType() != label1.GetType())
                    textBox.Text = string.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != dataGridView1.GetType())
                {
                    if (string.IsNullOrEmpty(control.Text.Trim()))
                    {
                        MessageBox.Show("Please enter a value for " + control.Name.ToString());
                        control.Focus();
                        return;
                    }
                }
            }

            List<Genre> genreList = GenreDB.GetGenres();

            int genreid = 0;
            foreach (Genre genre in genreList)
            {
                if(genre.Name == cmbGenre.Text.Trim())
                {
                    genreid = genre.ID;
                }
            }

            

            Movie objMovie = new Movie();
            objMovie.movie_number = Convert.ToInt32(txtMovieNumber.Text);
            objMovie.movie_title = txtTitle.Text.ToString();
            objMovie.Description = txtDescription.Text.ToString();
            objMovie.movie_year_made = Convert.ToInt32(txtYear.Text);
            objMovie.genre_id = genreid;
            objMovie.movie_rating = cmbRating.Text;
            objMovie.media_type = cmbMediaType.Text;
            objMovie.movie_retail_cost = returnDecimal(txtRetailCost.Text);
            objMovie.movie_rental_cost = returnDecimal(txtRentalCost.Text);
            objMovie.copies_on_hand = Convert.ToInt32(txtCopies.Text);
            objMovie.image = txtImage.Text;
            objMovie.trailer = txtTrailer.Text;

            //if(lblPicture.Text != string.Empty)
            //{
            //    objMember.photo = lblPicture.Text;
            //}


            try
            {
                bool status = MovieDB.AddMovie(objMovie);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Movieadded to the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Movie was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal returnDecimal(string value)
        {
            decimal convert = Convert.ToDecimal(value);
            decimal d = 1.00m;
            d = d * convert;

            return d;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validate the UI
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != dataGridView1.GetType())
                {
                    if (string.IsNullOrEmpty(control.Text.Trim()))
                    {
                        MessageBox.Show("Please enter a value for " + control.Name.ToString());
                        control.Focus();
                        return;
                    }
                }
            }

            List<Genre> genreList = GenreDB.GetGenres();

            int genreid = 0;
            foreach (Genre genre in genreList)
            {
                if (genre.Name == cmbGenre.Text)
                {
                    genreid = genre.ID;
                }
            }

            Movie objMovie = new Movie();
            objMovie.movie_number = Convert.ToInt16(txtMovieNumber.Text);
            objMovie.movie_title = txtTitle.Text.ToString();
            objMovie.Description = txtDescription.Text.ToString();
            objMovie.movie_year_made = Convert.ToInt16(txtYear.Text);
            objMovie.genre_id = genreid;
            objMovie.movie_rating = cmbRating.Text;
            objMovie.media_type = cmbMediaType.Text;
            objMovie.movie_retail_cost = returnDecimal(txtRetailCost.Text);
            objMovie.movie_rental_cost = returnDecimal(txtRentalCost.Text);
            objMovie.copies_on_hand = Convert.ToInt16(txtCopies.Text);
            objMovie.image = txtImage.Text;
            objMovie.trailer = txtTrailer.Text;


            try
            {
                bool status = MovieDB.UpdateMovie(objMovie);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Movie has been updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Movie was not updated in database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectionFill();
        }
    }
}
