using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2.MemberFile;

namespace Final_Project_2
{
    public partial class memberForm : Form
    {
        public memberForm()
        {
            InitializeComponent();
        }

        private void Reload_Data()
        {
            try
            {
                List<Member> memberList = new List<Member>();
                memberList = MemberDB.GetMembers();
                //dataGridView1.ColumnCount = 6;
                dataGridView1.DataSource = memberList;

                //dataGridView1.Columns.Add("number", "Member ID");
                //dataGridView1.Columns.Add("joindate", "Join Date");
                //dataGridView1.Columns.Add("status", "Member Status");
                //dataGridView1.Columns.Add()

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void memberForm_Load(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberNumber.Text.Trim()))
            {
                try
                {
                    List<Member> memberList = new List<Member>();
                    memberList = MemberDB.GetMembers();
                    int num = 1;
                    foreach (Member member in memberList)
                    {
                        if (num <= member.memberNumber)
                        {
                            num = member.memberNumber + 1;
                        }
                    }
                    txtMemberNumber.Text = num.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            foreach (Control control in groupBoxMemberData.Controls)
            {
                if (string.IsNullOrEmpty(control.Text.Trim()))
                {
                    MessageBox.Show("Please enter a value for " + control.Name.ToString());
                    control.Focus();
                    return;
                }
            }

            Member objMember = new Member();
            objMember.memberNumber = Convert.ToInt32(txtMemberNumber.Text);
            objMember.joinDate = txtJoinDate.Text;
            objMember.firstName = txtFirstName.Text;
            objMember.lastName = txtLastName.Text;
            objMember.address = txtAddress.Text;
            objMember.city = txtCity.Text;
            objMember.state = txtState.Text;
            objMember.zipcode = Convert.ToInt32(txtZipCode.Text);
            objMember.phoneNumber = txtPhoneNumber.Text.ToString();
            objMember.status = RadioStatus();
            objMember.login = txtLogin.Text;
            objMember.password = txtPassword.Text;
            objMember.email = txtEmail.Text;
            objMember.contact_method = ContactMethod();
            objMember.subscription_id = 1;
            objMember.photo = "Photo";
            

            //if(lblPicture.Text != string.Empty)
            //{
            //    objMember.photo = lblPicture.Text;
            //}
            

            try
            {
                bool status = MemberDB.AddMember(objMember);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Member added to the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Member was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ContactMethod()
        {
            int contact_method = 0;
            if (rdEmail.Checked)
                contact_method = 1;
            if (rdFacebook.Checked)
                contact_method = 2;
            if (rdTwitter.Checked)
                contact_method = 3;
            if (rdPhone.Checked)
                contact_method = 4;

            return contact_method;
        }

        private string RadioStatus()
        {
            string status;
            if (rdActive.Checked)
            {
                status = "A";
            }
            else
            {
                status = "O";
            }
            return status;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            string fileString = openFile.FileName;
            lblPicture.Text = fileString;
            pictureBox1.Image = Image.FromFile(fileString);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        private void rdActive_Click(object sender, EventArgs e)
        {
            rdInactive.Checked = false;
        }

        private void rdInactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdInactive_Click(object sender, EventArgs e)
        {
            rdActive.Checked = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Fill all values with data if time permits

            foreach (Control control in groupBoxMemberData.Controls)
            {
                if (string.IsNullOrEmpty(control.Text.Trim()))
                {
                    MessageBox.Show("Please enter a value for " + control.Name.ToString());
                    control.Focus();
                    return;
                }
            }

            Member objMember = new Member();
            objMember.memberNumber = Convert.ToInt32(txtMemberNumber.Text);
            objMember.joinDate = txtJoinDate.Text;
            objMember.firstName = txtFirstName.Text;
            objMember.lastName = txtLastName.Text;
            objMember.address = txtAddress.Text;
            objMember.city = txtCity.Text;
            objMember.state = txtState.Text;
            objMember.zipcode = Convert.ToInt32(txtZipCode.Text);
            objMember.phoneNumber = txtPhoneNumber.Text.ToString();
            objMember.status = RadioStatus();
            objMember.login = txtLogin.Text;
            objMember.password = txtPassword.Text;
            objMember.email = txtEmail.Text;
            objMember.contact_method = ContactMethod();
            objMember.subscription_id = 1;
            objMember.photo = "Photo";

            try
            {
                bool status = MemberDB.UpdateMember(objMember);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Member has been updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Member was not updated in database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBoxMemberData.Controls)
            {
                if (string.IsNullOrEmpty(control.Text.Trim()))
                {
                    MessageBox.Show("Please enter a value for " + control.Name.ToString());
                    control.Focus();
                    return;
                }
            }

            Member objMember = new Member();
            objMember.memberNumber = Convert.ToInt32(lblSelected.Text);

            try
            {
                bool status = MemberDB.DeleteMember(objMember);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    Reload_Data();
                    MessageBox.Show("Member was deleted from the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Member was not deleted from the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control textBox in groupBoxMemberData.Controls)            
            {
                if(textBox.GetType() != label1.GetType())
                    textBox.Text = string.Empty;
            }

            foreach (RadioButton radio in gbMemberStatus.Controls)
            {
                radio.Checked = false;
            }

            foreach (RadioButton radio in gbPrefContact.Controls)
            {
                radio.Checked = false;
            }

            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Member objMember = new Member();
            objMember.memberNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            lblSelected.Text = objMember.memberNumber.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
