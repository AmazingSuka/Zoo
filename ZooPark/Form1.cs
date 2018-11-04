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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void ZooButton_Click(object sender, EventArgs e)
        {
            new ZooForm().ShowDialog();
        }

        private void EmployerButton_Click(object sender, EventArgs e)
        {
            new EmployerForm().ShowDialog();
        }

        private void AnimalButton_Click(object sender, EventArgs e)
        {
            new AnimalForm().ShowDialog();
        }

        private void CellButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
