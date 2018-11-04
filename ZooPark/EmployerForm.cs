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
    public partial class EmployerForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-9JL7RPV;Initial Catalog=Zoopark;Integrated Security=True";

        public EmployerForm()
        {
            InitializeComponent();
            new Design().DataGridDesign(EmployerDataGrid, DutyDataGrid, PostDataGrid);
        }

        // Элементы управления кнопки "Таблица"
        // Заполнение Таблиц
        private void EmployerGrid_Fill(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                DutyDataGrid.Visible = false;
                PostDataGrid.Visible = false;
                EmployerDataGrid.Visible = true;
                int i = 0;
                EmployerDataGrid.Rows.Clear();
                foreach (var emp in context.GetTable<Employer>())
                {
                    EmployerDataGrid.Rows.Add();
                    EmployerDataGrid.Rows[i].Cells[0].Value = emp.Id;
                    EmployerDataGrid.Rows[i].Cells[1].Value = emp.Fio;
                    EmployerDataGrid.Rows[i].Cells[2].Value = emp.Age;
                    EmployerDataGrid.Rows[i].Cells[3].Value = context.GetTable<Post>().Where(p => p.Id == emp.PostID).Single().Name;
                    EmployerDataGrid.Rows[i].Cells[4].Value = context.GetTable<Zoo>().Where(z => z.Id == emp.ZooID).Single().Name;
                    EmployerDataGrid.Rows[i].Cells[5].Value = emp.Phone;
                    EmployerDataGrid.Rows[i].Cells[6].Value = emp.Email;
                    EmployerDataGrid.Rows[i].Cells[7].Value = emp.INN;
                    EmployerDataGrid.Rows[i].Cells[8].Value = emp.JoinDate;
                    i++;
                }
            }
        }

        private void DutyGrid_Fill(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                EmployerDataGrid.Visible = false;
                PostDataGrid.Visible = false;
                DutyDataGrid.Visible = true;
                int i = 0;
                DutyDataGrid.Rows.Clear();
                foreach (var item in context.GetTable<Duty>())
                {
                    DutyDataGrid.Rows.Add();
                    DutyDataGrid.Rows[i].Cells[0].Value = context.GetTable<Employer>().Where(emp => emp.Id == item.EmployerID).Single().Fio;
                    DutyDataGrid.Rows[i].Cells[1].Value = item.Date;
                    i++;
                }
            }
        }

        private void PostGrid_Fill(object sender, EventArgs e)
        {
            EmployerDataGrid.Visible = false;
            DutyDataGrid.Visible = false;
            PostDataGrid.Visible = true;
            int i = 0;
            PostDataGrid.Rows.Clear();
            foreach (var post in new DataContext(connectionString).GetTable<Post>())
            {
                PostDataGrid.Rows.Add();
                PostDataGrid.Rows[i].Cells[0].Value = post.Id;
                PostDataGrid.Rows[i].Cells[1].Value = post.Name;
                PostDataGrid.Rows[i].Cells[2].Value = post.Salary;
                i++;
            }
        }

        // Элементы управления кнопки "Добавить"
        // Открывает модальное окно добавления сотрудника (EmployerInsertForm)
        private void EmployerInsertButton_Click(object sender, EventArgs e)
        {
            new EmployerInsertForm().ShowDialog();
        }
        // Заполняет КомбоБокс именами для добавления записи дежурства
        private void DutyInsertButton_Click(object sender, EventArgs e)
        {
            EmployerNameBox_Fill(DutyBox);
        }
        // Добавляет запись дежурства в Базу Даннаых
        private void DutyInsertButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                var employer = context.GetTable<Employer>().Where(emp => emp.Fio == DutyBox.Text).Single();
                Duty duty = new Duty { EmployerID = employer.Id, Date = Convert.ToDateTime(DutyDateTb.Text) };
                context.GetTable<Duty>().InsertOnSubmit(duty);
                context.SubmitChanges();
            }
        }
        // Добавляет должность в Базу Данных
        private void PostInsertButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Post post = new Post { Name = PostNameTb.Text, Salary = Convert.ToInt32(PostSalaryTb.Text) };
                context.GetTable<Post>().InsertOnSubmit(post);
                context.SubmitChanges();
            }
        }
        
        private void DutyDateTb_Click(object sender, EventArgs e)
        {
            DutyDateTb.Text = "";
        }       //
        private void PostNameTb_Click(object sender, EventArgs e)
        {
            PostNameTb.Text = "";
        }       // Убирают текст в текстбосах
        private void PostSalaryTb_Click(object sender, EventArgs e)
        {
            PostSalaryTb.Text = "";
        }     //

        // Элементы уплавления кнопки "Редактировать"
        // Открывает модальное окно редактирования сотрудника (EmployerEditForm)
        private void EmployerEditButton_Click(object sender, EventArgs e)
        {
            new EmployerEditForm().ShowDialog();
        }
        // Заполяет КомбоБоксы Сотрудника и Даты для редактирования.
        private void DutyEditButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                DutyEditDateBox.Items.Clear();
                foreach (var duty in context.GetTable<Duty>())
                {
                    DutyEditDateBox.Items.Add(duty.Date);
                }

                DutyEditEmployerBox.Items.Clear();
                foreach (var emp in context.GetTable<Employer>())
                {
                    DutyEditEmployerBox.Items.Add(emp.Fio);
                }
            }
        }
        // Редактирует запись дежурства в Базе Данных
        private void DutyEditButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                context.GetTable<Duty>().
                    Where(d => d.Date == Convert.ToDateTime(DutyEditDateBox.Text)).
                        Single().EmployerID = context.GetTable<Employer>().Where(emp => emp.Fio == DutyEditEmployerBox.Text).Single().Id;
                context.SubmitChanges();
            }
        }
        // Подставляет ФИО сотрудника в КомбоБокс при выборе Даты
        private void DutyEditDateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                //DutyEditEmployerBox.Items.Clear();
                //foreach (var emp in context.GetTable<Employer>())
                //{
                //    DutyEditEmployerBox.Items.Add(emp.Fio);
                //}

                //var EmployerId = context.GetTable<Duty>().
                //    Where(d => d.Date == Convert.ToDateTime(DutyEditDateBox.Text)).Single().EmployerID;
                //DutyEditEmployerBox.Text = context.GetTable<Employer>().Where(emp => emp.Id == EmployerId).Single().Fio;
            }
        }

        // Элементы управления кнопки "Удалить"
        // Заполняет КомбоБокс с ФИО сотрудников для удаления
        private void DeleteEmployerButton_Click(object sender, EventArgs e)
        {
            EmployerNameBox_Fill(DeleteEmployerBox);
        }
        // Заполняет КомбоБокс с должностями для удаления
        private void DeletePostButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                foreach (var post in context.GetTable<Post>())
                {
                    DeletePostBox.Items.Add(post.Name);
                }
            }
        }
        // Удаляет сотрудника из Базы Данных
        private void DeleteEmployerButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Table<Employer> employers = context.GetTable<Employer>();
                var employer = employers.Where(emp => emp.Fio == DeleteEmployerBox.Text).Single();
                employers.DeleteOnSubmit(employer);
                context.SubmitChanges();
            }
        }
        // Удаляет должность из Базы Данных
        private void DeletePostButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Table<Post> posts = context.GetTable<Post>();
                var post = posts.Where(p => p.Name == DeletePostBox.Text).Single();
                posts.DeleteOnSubmit(post);
                context.SubmitChanges();
            }
        }

        private void DeleteDutyButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                MessageBox.Show("Не работать, пока что");
            }
        } // не работает
        // Общая функция для заполнения ФИО сотрудников в КомбоБокс
        private void EmployerNameBox_Fill(ToolStripComboBox box)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                box.Items.Clear();
                foreach (var emp in context.GetTable<Employer>())
                {
                    box.Items.Add(emp.Fio);
                }
            }
        }
    }
}
