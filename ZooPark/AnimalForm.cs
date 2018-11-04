using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark
{
    public partial class AnimalForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-9JL7RPV;Initial Catalog=Zoopark;Integrated Security=True";
        private Animal animal;
        private Cell cell;
        private AnimalKind kind;

        public AnimalForm()
        {
            InitializeComponent();
            new Design().DataGridDesign(dataGridView1, dataGridView2, dataGridView3);
        }
        // Элементы управления кнопки "Добавить"
        private void AnimalForm_Load(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Table<Animal> animals = context.GetTable<Animal>();
                Table<AnimalKind> kinds = context.GetTable<AnimalKind>();
                Table<Cell> cells = context.GetTable<Cell>();
                Table<Zoo> zoos = context.GetTable<Zoo>();
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                
                int i = 0;
                foreach (var animal in animals)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = animal.Id;
                    dataGridView1.Rows[i].Cells[1].Value = kinds.Where(k => k.Id == animal.KindID).Single().Kind;
                    dataGridView1.Rows[i].Cells[2].Value = cells.Where(c => c.Id == animal.CellID).Single().Name;
                    i++;
                }
                i = 0;
                foreach (var kind in kinds)
                {
                    AnimalKindEditKindBox.Items.Add(kind.Kind);
                    AnimalEditKindBox.Items.Add(kind.Kind);
                    AnimalInsertKindBox.Items.Add(kind.Kind);
                    dataGridView3.Rows.Add();
                    dataGridView3.Rows[i].Cells[0].Value = kind.Id;
                    dataGridView3.Rows[i].Cells[1].Value = kind.Kind;
                    i++;
                }
                i = 0;
                foreach (var cell in cells)
                {
                    CellEditNameBox.Items.Add(cell.Name);
                    AnimalEditCellBox.Items.Add(cell.Name);
                    AnimalInsertCellBox.Items.Add(cell.Name);
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[0].Value = cell.Id;
                    dataGridView2.Rows[i].Cells[1].Value = cell.Name;
                    dataGridView2.Rows[i].Cells[2].Value = cell.Places;
                    dataGridView2.Rows[i].Cells[3].Value = zoos.Where(z => z.Id == cell.ZooID).Single().Name;
                    i++;
                }
                foreach (var zoo in zoos)
                {
                    CellInsertZooBox.Items.Add(zoo.Name);
                    CellEditZooBox.Items.Add(zoo.Name);
                }
            }
        }

        private void AnimalInsertButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Animal animal = new Animal
                {
                    KindID = context.GetTable<AnimalKind>().Where(k => k.Kind == AnimalInsertKindBox.Text).Single().Id,
                    CellID = context.GetTable<Cell>().Where(c => c.Name == AnimalInsertCellBox.Text).Single().Id
                };
                context.GetTable<Animal>().InsertOnSubmit(animal);
                context.SubmitChanges();
            }
        }

        private void AnimalKindInsertButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                AnimalKind kind = new AnimalKind { Kind = AnimalKindInsertTb.Text };
                context.GetTable<AnimalKind>().InsertOnSubmit(kind);
                context.SubmitChanges();
            }
            
        }

        private void CellInsertButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                Cell cell = new Cell
                {
                    Name = CellInsertNameTb.Text,
                    Places = Convert.ToByte(CellInsertPlacesTb.Text),
                    ZooID = context.GetTable<Zoo>().Where(z => z.Name == CellInsertZooBox.Text).Single().Id
                };
                context.GetTable<Cell>().InsertOnSubmit(cell);
                context.SubmitChanges();
            }
        }

        // Элементы управления кнопки "Редактировать"
        private void AnimalEditButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                
            }
        }

        private void AnimalKindEditButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {
                
            }
        }

        private void CellEditButtonConf_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext(connectionString))
            {

            }
        }

        private void AnimalEditKindBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
