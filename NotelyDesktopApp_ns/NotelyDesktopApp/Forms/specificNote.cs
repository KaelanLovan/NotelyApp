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
    public partial class specificNote : Form
    {
        public specificNote()
        {
            InitializeComponent();
        }
        public Form RefToSpecificNote { get; set; }
        private void editNote_Click(object sender, EventArgs e)
        {
            editNote d = new editNote();
            d.RefToEditNote = this;
            this.Visible = false;
            d.Show();
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            notesPage b = new notesPage();
            b.RefToNotesPage = this;
            this.Visible = false;
            b.Show();
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            MainApp c = new MainApp();
            c.RefToMainApp = this;
            this.Visible = false;
            c.Show();
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
