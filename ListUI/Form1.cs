using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> people = new List<Person>();
        BindingSource newpeople = new BindingSource();
        List<string> outContents = new List<string>();
        List<Person1> savePeople = new List<Person1>();
        private void Form1_Load(object sender, EventArgs e)
        {
            newpeople.DataSource = people;
            listBox1.DataSource = newpeople;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person(tbFirstName.Text, tbLastName.Text, tbURL.Text);
            Person1 sp = new Person1(tbFirstName.Text, tbLastName.Text, tbURL.Text);
            newpeople.Add(p);
            savePeople.Add(sp);
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbURL.Text = "";

            listBox1.Refresh();
            this.ActiveControl = this.Controls[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Person1 sp in savePeople)
            {
                Console.WriteLine(sp);
                outContents.Add(sp.ToString());
            }
            string outFile = @"C:\Users\kayan\OneDrive\Desktop\CST-250\Week 6\outFile.txt";
            File.WriteAllLines(outFile, outContents);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            string filePath = @"C:\Users\kayan\OneDrive\Desktop\CST-250\Week 6\outFile.txt";

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Person p = new Person(items[0], items[1], items[2]);
                newpeople.Add(p);
            }
            listBox1.Refresh();
        }
    }
}
