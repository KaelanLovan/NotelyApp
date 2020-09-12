using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotelyDesktopApp
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        public Form RefToMainApp { get; set; }
        private void newNote_Click(object sender, EventArgs e)
        {
            createNote a = new createNote();
            a.RefToMainApp = this;
            this.Visible = false;
            a.Show();
        }
        
        private void noteLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            createNote a = new createNote();
            a.RefToMainApp = this;
            this.Visible = false;
            a.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MainApp c = new MainApp();
            c.RefToMainApp = this;
            this.Visible = false;
            c.Show();
        }
    }
}
