using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark
{
    public partial class EmployerEditForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-9JL7RPV;Initial Catalog=Zoopark;Integrated Security=True";

        public EmployerEditForm()
        {
            InitializeComponent();
        }

        private void EmployerEditForm_Load(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Table<Employer> employers = context.GetTable<Employer>();
                Table<Zoo>zoos = context.GetTable<Zoo>();
                Table<Post> posts = context.GetTable<Post>();
                foreach (var emp in employers)
                {
                    FioBox.Items.Add(emp.Fio);
                }
                foreach (var zoo in zoos)
                {
                    ZooBox.Items.Add(zoo.Name);
                }
                foreach (var post in posts)
                {
                    PostBox.Items.Add(post.Name);
                }
            }
        }

        private void FioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Employer employer = context.GetTable<Employer>().Where(emp => emp.Fio == FioBox.Text).Single();
                AgeTb.Text = employer.Age.ToString();
                PostBox.Text = context.GetTable<Post>().Where(p => p.Id == employer.PostID).Single().Name;
                ZooBox.Text = context.GetTable<Zoo>().Where(z => z.Id == employer.ZooID).Single().Name;
                PhoneTb.Text = employer.Phone;
                EmailTb.Text = employer.Email;
                InnTb.Text = employer.INN;
                JoinDateTb.Text = employer.JoinDate.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Employer employer = context.GetTable<Employer>().Where(emp => emp.Fio == FioBox.Text).Single();
                employer.Fio = FioBox.Text;
                employer.Age = Convert.ToByte(AgeTb.Text);
                employer.ZooID = context.GetTable<Zoo>().Where(z => z.Name == ZooBox.Text).Single().Id;
                employer.PostID = context.GetTable<Post>().Where(p => p.Name == PostBox.Text).Single().Id;
                employer.Phone = PhoneTb.Text;
                employer.Email = EmailTb.Text;
                employer.INN = InnTb.Text;
                employer.JoinDate = Convert.ToDateTime(JoinDateTb.Text);
                context.SubmitChanges();
                Dispose();
            }
        }
    }
}
