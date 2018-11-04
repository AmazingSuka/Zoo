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
    public partial class ZooInsertForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-9JL7RPV;Initial Catalog=Zoopark;Integrated Security=True";
        private DataContext context;

        public ZooInsertForm()
        {
            InitializeComponent();
            context = new DataContext(connectionString);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Zoo zoo = new Zoo
            {
                Name = NameTb.Text,
                Address = AddressTb.Text,
                Phone = PhoneTb.Text,
                INN = InnTb.Text
            };
            context.GetTable<Zoo>().InsertOnSubmit(zoo);
            context.SubmitChanges();
            this.Close();
        }
    }
}
