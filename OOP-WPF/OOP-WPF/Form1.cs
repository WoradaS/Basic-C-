using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // Property ระดับ obj ต้องสร้าง obj ขึ้นมาก่อน
            Empolyee emp1 = new Empolyee();
            emp1.Id = 1;
            emp1.Name = "Frist";
            emp1.Lastname = "L";
            emp1.Position = "CEO";

            Empolyee emp2 = new Empolyee();
            emp2.Id = 2;
            emp2.Name = "song";
            emp2.Lastname = "L";
            emp2.Position = "Engineer";

            List<Empolyee> list = new List<Empolyee>();
            list.Add(emp1);
            list.Add(emp2);

            // loop for Array,list C#
            foreach (Empolyee obj in list)
            {
                if (obj.Id == int.Parse(employeeidTextbox.Text))
                {
                    MessageBox.Show("id: " + obj.Id + "Name: " + obj.Name + "LastName: " + obj.Lastname + "Position: " + obj.Position);
                    break;
                }

            }
        }
    }
}
