using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewTest
{

    public class User
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Id1 { get; set; }
        public string Id2 { get; set; }
        public string Id3 { get; set; }
        public string Id4 { get; set; }
    }



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<User> mls = new List<User>();
            mls.Add(new User() { Name = "Test1", Id = "1" });
            mls.Add(new User() { Name = "Test2", Id = "2" });
            mls.Add(new User() { Name = "Test3", Id = "3" });
            mls.Add(new User() { Name = "Test4", Id = "4" });
            mls.Add(new User() { Name = "Test5", Id = "5" });
            mls.Add(new User() { Name = "Test6", Id = "6" });
            mls.Add(new User() { Name = "Test7", Id = "7" });
            mls.Add(new User() { Name = "Test8", Id = "8" });

            dataGridView1.DataSource = mls;
            dataGridView1.FirstDisplayedCell = dataGridView1[5, 3];
        }
    }
}
