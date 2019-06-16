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
    public partial class formReceiver : Form
    {
       
        public formReceiver()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DAL.Receiver receiver = new Receiver();
            receiver.Search = textBoxSearch.Text;
            dataGridViewShowReceiver.DataSource = receiver.Select().Tables[0];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridViewShowReceiver.SelectedRows.Count <= 0)
                return;

            formReceiverUpdate receiverUpdate = new formReceiverUpdate(Convert.ToInt32(dataGridViewShowReceiver.SelectedRows[0].Cells["ColId"].Value));
            receiverUpdate.ShowDialog();
            buttonSearch.PerformClick();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewShowReceiver.SelectedRows.Count <= 0)
                return;

            DialogResult confrmDelete = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (confrmDelete != DialogResult.Yes)
                return;

            DAL.Receiver receiver = new Receiver();
            string ids = "";
            for (int i = 0; i < dataGridViewShowReceiver.SelectedRows.Count; i++)
            {
                ids += dataGridViewShowReceiver.SelectedRows[i].Cells["ColId"].Value.ToString() + ", ";
            }

            ids = ids.Substring(0, ids.Length - 2);

            if (receiver.Delete(ids))
            {
                MessageBox.Show("Receiver is deleted");
                buttonSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(receiver._Error);
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DAL.Receiver receiver = new Receiver();
            receiver.Search = textBoxSearch.Text;
            dataGridViewShowReceiver.DataSource = receiver.Select().Tables[0];
            buttonSearch.PerformClick();
        }

        private void formReceiver_Load(object sender, EventArgs e)
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
            formReceiverAdd receiverAdd = new formReceiverAdd();
            receiverAdd.ShowDialog();
            buttonSearch.PerformClick();
        }

        private void dataGridViewShowReceiver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
