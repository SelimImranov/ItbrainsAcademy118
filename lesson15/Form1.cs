using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ww._118
{
    public partial class Form1 : Form
    {
        List<student> list = new List<student>();
        public Form1()
        {
            InitializeComponent();
        }

     

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string name=txtname.Text;  
            string surname=txtname2.Text;

            student student = new student();
            student.Name = name;
            student.Surname = surname;
            list.Add(student);
            MessageBox.Show($"{name} student add");
            txtname.Text = "";
            txtname2.Text = "";


        }
    }
}
