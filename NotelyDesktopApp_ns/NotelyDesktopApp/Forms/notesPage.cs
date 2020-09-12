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
    public partial class notesPage : Form
    {
        public notesPage()
        {
            InitializeComponent();
        }

        private void notesPage_Load(object sender, EventArgs e)
        {

        }
        public Form RefToNotesPage { get; set; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            specificNote c = new specificNote();
            c.RefToSpecificNote = this;
            this.Visible = false;
            c.Show();
        }

        private void newNote_Click(object sender, EventArgs e)
        {
            createNote a = new createNote();
            a.RefToMainApp = this;
            this.Visible = false;
            a.Show();
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
            notesPage b = new notesPage();
            b.RefToNotesPage = this;
            this.Visible = false;
            b.Show();
        }
    }
}
