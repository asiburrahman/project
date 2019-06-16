using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Blood_Bank.Presentation
{
    public partial class formReceiverUpdate : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        DAL.Receiver receiver = new Receiver();
        public formReceiverUpdate(int id)
        {
            InitializeComponent();

            receiver.Id = id;
            if (receiver.SelectById())
            {
                textBoxName.Text = receiver.Name;
                comboBoxBlood.Text = receiver.BloodGroup;
                textBoxFacebook.Text = receiver.FbId;
                textBoxMobile.Text = receiver.Mobile;
                textBoxAddress.Text = receiver.Address;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
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


            receiver.Name = textBoxName.Text;
            receiver.BloodGroup = Convert.ToString(comboBoxBlood.Text);
            receiver.FbId = textBoxFacebook.Text;
            receiver.Mobile = textBoxMobile.Text;
            receiver.Address = textBoxAddress.Text;

            if (receiver.Update())
            {
                MessageBox.Show("Receiver is Update");
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
    }
}
