using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.Presentation
{
    public partial class formDonerAdd : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public formDonerAdd()
        {
            InitializeComponent();
        }

        private void formDonerAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int error = 0;
            errorProvider.Clear();

            if (textBoxName.Text == "")
            {
                error++;
                errorProvider.SetError(textBoxName, "Required Name");
            }

            if (comboBoxBlood.Text == "")
            {
                error++;
                errorProvider.SetError(comboBoxBlood, "Required Blood");
            }

            if (textBoxFacebook.Text == "")
            {
                error++;
                errorProvider.SetError(textBoxFacebook, "Required Facebook Id");
            }

            if (textBoxMobile.Text == "")
            {
                error++;
                errorProvider.SetError(textBoxMobile, "Required Mobile");
            }

            if (textBoxAddress.Text == "")
            {
                error++;
                errorProvider.SetError(textBoxAddress, "Required Address");
            }

            if (dateTimePickerDate.Text == "")
            {
                error++;
                errorProvider.SetError(dateTimePickerDate, "Required Date");
            }

            if (error > 0)
                return;

            DAL.Doner doner = new DAL.Doner();
            doner.Name = textBoxName.Text;
            doner.BloodGroup = Convert.ToString(comboBoxBlood.Text);
            doner.FbId = textBoxFacebook.Text;
            doner.Mobile = textBoxMobile.Text;
            doner.Address = textBoxAddress.Text;
            doner.LastDonate = Convert.ToDateTime(dateTimePickerDate.Text);

            if (doner.Insert())
            {
                MessageBox.Show("Donar is saved");
                textBoxName.Text = "";
                comboBoxBlood.Text = "";
                textBoxFacebook.Text = "";
                textBoxMobile.Text = "";
                textBoxAddress.Text = "";
                dateTimePickerDate.Text = "";
                textBoxName.Focus();
            }
            else
            {
                MessageBox.Show(doner._Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
