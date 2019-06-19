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
    public partial class formReceiverAdd : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public formReceiverAdd()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
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

            if (error > 0)
                return;

            DAL.Receiver receiver = new  DAL.Receiver();
            receiver.Name = textBoxName.Text;
            receiver.BloodGroup = Convert.ToString(comboBoxBlood.Text);
            receiver.FbId = textBoxFacebook.Text;
            receiver.Mobile = textBoxMobile.Text;
            receiver.Address = textBoxAddress.Text;

            if (receiver.Insert())
            {
                MessageBox.Show("Donar is saved");
                textBoxName.Text = "";
                comboBoxBlood.Text = "";
                textBoxFacebook.Text = "";
                textBoxMobile.Text = "";
                textBoxAddress.Text = "";
                textBoxName.Focus();
            }
            else
            {
                MessageBox.Show(receiver._Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxFacebook_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void FormReceiverAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
