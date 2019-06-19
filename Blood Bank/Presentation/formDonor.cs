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
    public partial class formDonor : Form
    {
       
        public formDonor()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DAL.Doner doner = new Doner();
            doner.Search = textBoxSearch.Text;
            dataGridViewShowDonar.DataSource = doner.Select().Tables[0];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShowDonar.SelectedRows.Count <= 0)
                return;

            formDonrUpdate donerUpdate = new formDonrUpdate(Convert.ToInt32(dataGridViewShowDonar.SelectedRows[0].Cells["ColId"].Value));
            donerUpdate.ShowDialog();
            buttonSearch.PerformClick();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewShowDonar.SelectedRows.Count <= 0)
                return;

            DialogResult confrmDelete = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if(confrmDelete != DialogResult.Yes)
                return;

            DAL.Doner doner = new Doner();
            string ids = "";
            for (int i = 0; i < dataGridViewShowDonar.SelectedRows.Count; i++)
            {
                ids += dataGridViewShowDonar.SelectedRows[i].Cells["ColId"].Value.ToString() + ", ";
            }

            ids = ids.Substring(0, ids.Length - 2);

            if (doner.Delete(ids))
            {
                MessageBox.Show("Donar is deleted");
                buttonSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(doner._Error);
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DAL.Doner doner = new Doner();
            doner.Search = textBoxSearch.Text;
            dataGridViewShowDonar.DataSource = doner.Select().Tables[0];
            buttonSearch.PerformClick();
        }

        private void formDoner_Load(object sender, EventArgs e)
        {
            buttonSearch.PerformClick();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formDonorAdd donarAdd = new formDonorAdd();
            donarAdd.ShowDialog();
            buttonSearch.PerformClick();
        }

        private void DataGridViewShowDonar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
