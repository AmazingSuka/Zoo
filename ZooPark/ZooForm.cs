using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace ZooPark
{
    public partial class ZooForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-9JL7RPV;Initial Catalog=Zoopark;Integrated Security=True";
        private DataContext context;

        public ZooForm()
        {
            context = new DataContext(connectionString);
            InitializeComponent();
            new Design().DataGridDesign(dataGridView1);
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void ZooForm_Load(object sender, EventArgs e)
        {
            ZooFill();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Zoo zoo = context.GetTable<Zoo>().Where(z => z.Name == toolStripDeleteBox.Text).Single();
            context.GetTable<Zoo>().DeleteOnSubmit(zoo);
            context.SubmitChanges();
            ZooFill();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            new ZooInsertForm().ShowDialog();
            ZooFill();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new ZooEditForm().ShowDialog();
            ZooFill();
        }

        private void ZooFill()
        {
            dataGridView1.Rows.Clear();
            toolStripDeleteBox.Text = "";
            toolStripDeleteBox.Items.Clear();
            int i = 0;
            foreach (var zoo in new DataContext(connectionString).GetTable<Zoo>())
            {
                toolStripDeleteBox.Items.Add(zoo.Name);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = zoo.Id;
                dataGridView1.Rows[i].Cells[1].Value = zoo.Name;
                dataGridView1.Rows[i].Cells[2].Value = zoo.Address;
                dataGridView1.Rows[i].Cells[3].Value = zoo.Phone;
                dataGridView1.Rows[i].Cells[4].Value = zoo.INN;
                i++;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ZooFill();
        }
    }
}
