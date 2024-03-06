using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemt_4._3
{
    public partial class LMS : Form
    {
        List<Student>student = new List<Student> ();

        public LMS()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewLMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudID.Text != String.Empty && txtStudName.Text != String.Empty && txtGPA.Text != String.Empty)

            {
                Student newstudent = new Student();
                newstudent.ID = Int32.Parse(txtStudID.Text);
                newstudent.Name = txtStudName.Text;
                newstudent.GPA = Convert.ToInt32(txtGPA.Text);
                student.Add(newstudent);
                MessageBox.Show("Record added!");
                RefreshData();
            }

        }

        private void RefreshData()
        {
            txtStudID.Clear();
            txtStudName.Clear();
            txtGPA.Clear();
            dataGridViewLMS.DataSource = null;
            dataGridViewLMS.DataSource = student;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                student.RemoveAt(dataGridViewLMS.CurrentRow.Index);
                RefreshData();
            }

        }

        private void LMS_Load(object sender, EventArgs e)
        {
            student.Add(new Student() { ID = 1, Name="John", GPA=3});
            dataGridViewLMS.DataSource=student;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            student.Sort();
            student.ForEach (student => Console.WriteLine(student.GPA));
            File.WriteAllLines(@"I:\1. Documents\Microsoft Software & Systems Academy_MSSA\1. Technical Development\Assignments\Week 4\Assignment 4.3\Assignemt 4.3\bin\Debug\StudentGPA.txt",student.Select(student =>$"Student GPA:{student.GPA},  Student Name:  {student.Name},  Student ID: {student.ID}"));
            MessageBox.Show("File Saved");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }





