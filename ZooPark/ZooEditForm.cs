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
    public partial class ZooEditForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-9JL7RPV;Initial Catalog=Zoopark;Integrated Security=True";
        private DataContext context;
        private Zoo zoo;
        public ZooEditForm()
        {
            InitializeComponent();
            context = new DataContext(connectionString);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            zoo.Address = AddressTb.Text;
            zoo.Phone = PhoneTb.Text;
            zoo.INN = InnTb.Text;
            context.SubmitChanges();
            Dispose();
        }

        private void ZooEditForm_Load(object sender, EventArgs e)
        {
            foreach (var zoo in context.GetTable<Zoo>())
            {
                NameBox.Items.Add(zoo.Name);
            }
        }

        private void NameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoo = context.GetTable<Zoo>().Where(z => z.Name == NameBox.Text).Single();
            AddressTb.Text = zoo.Address;
            PhoneTb.Text = zoo.Phone;
            InnTb.Text = zoo.INN;
        }
    }
}
