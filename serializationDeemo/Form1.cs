using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serializationDeemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"A:\DotNet20DecBatch\deptBinary.dat", FileMode.Create, FileAccess.Write);
                Student student = new Student(12,"Amit",55);
                student.rollno = Convert.ToInt32(txtroll.Text);
                student.name = txtname.Text;
                student.percentage = Convert.ToInt32(txtroll.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, student);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"A:\DotNet20DecBatch\deptBinary.dat", FileMode.Open, FileAccess.Read);
                Student student = new Student(2,"AJ",98);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
               student = (Student)binaryFormatter.Deserialize(fs);
                txtroll.Text = student.rollno.ToString();
                txtname.Text = student.name;
                txtper.Text = student.percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
