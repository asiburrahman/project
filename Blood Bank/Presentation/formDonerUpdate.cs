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
    public partial class formDonerUpdate : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        DAL.Doner doner = new Doner();
        public formDonerUpdate(int id)
        {
            InitializeComponent();
            doner.Id = id;
            if (doner.SelectById())
            {
                textBoxName.Text = doner.Name;
                comboBoxBlood.Text = doner.BloodGroup;
                textBoxFacebook.Text = doner.FbId;
                textBoxMobile.Text = doner.Mobile;
                textBoxAddress.Text = doner.Address;
                dateTimePickerDateUpdate.Text = Convert.ToString(doner.LastDonate);
            }
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

            if (dateTimePickerDateUpdate.Text == "")
            {
                error++;
                errorProvider.SetError(dateTimePickerDateUpdate, "Required Date");
            }

            if (error > 0)
                return;

            
            doner.Name = textBoxName.Text;
            doner.BloodGroup = Convert.ToString(comboBoxBlood.Text);
            doner.FbId = textBoxFacebook.Text;
            doner.Mobile = textBoxMobile.Text;
            doner.Address = textBoxAddress.Text;
            doner.LastDonate = Convert.ToDateTime(dateTimePickerDateUpdate.Text);

            if (doner.Update())
            {
                MessageBox.Show("Donar is Update");
                textBoxName.Text = "";
                comboBoxBlood.Text = "";
                textBoxFacebook.Text = "";
                textBoxMobile.Text = "";
                textBoxAddress.Text = "";
                textBoxName.Focus();
            }
            else
            {
                MessageBox.Show(doner._Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formDonerUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
