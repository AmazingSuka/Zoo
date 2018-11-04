using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark
{
    public partial class EmployerInsertForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-9JL7RPV;Initial Catalog=Zoopark;Integrated Security=True";

        public EmployerInsertForm()
        {
            InitializeComponent();
        }

        private void EmployerInsertForm_Load(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                foreach (var post in context.GetTable<Post>())
                {
                    PostBox.Items.Add(post.Name);
                }

                foreach (var zoo in context.GetTable<Zoo>())
                {
                    ZooBox.Items.Add(zoo.Name);
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Employer employer = new Employer
                {
                    Fio = FioTb.Text,
                    Age = Convert.ToByte(AgeTb.Text),
                    PostID = context.GetTable<Post>().Where(p => p.Name == PostBox.Text).Single().Id,
                    ZooID = context.GetTable<Zoo>().Where(z => z.Name == ZooBox.Text).Single().Id,
                    Phone = PhoneTb.Text,
                    Email = EmailTb.Text,
                    INN = InnTb.Text,
                    JoinDate = Convert.ToDateTime(JoinDateTb.Text)
                };
                context.GetTable<Employer>().InsertOnSubmit(employer);
                context.SubmitChanges();
            }
            Dispose();
        }
    }
}
