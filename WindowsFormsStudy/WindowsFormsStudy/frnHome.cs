using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStudy
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            var data = new List<MyClass>() { 
            new MyClass{ Name="Select One"},
            new MyClass{ Id=1,Name="Reja"},
            new MyClass{ Id=2,Name="Sabet"},
            new MyClass{ Id=3,Name="Shihab"},
            new MyClass{ Id=4,Name="Mahfuz"},
            new MyClass{ Id=5,Name="Mansur"},
            new MyClass{ Id=6,Name="Ullah"},
            new MyClass{ Id=7,Name="Gouri"},
            new MyClass{ Id=8,Name="Nisa"}            
            };
            
            cboData.DataSource = data;
            cboData.DisplayMember = "Name"; // Column Name
            cboData.ValueMember = "Id";  // Column Name
        }
    }


    public class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}
