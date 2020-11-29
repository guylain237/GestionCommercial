using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelArticle.Visible = false;
            panelAchat.Visible = false;
            panelVente.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelVente.Visible == false)
                panelVente.Visible = true;
            if (panelArticle.Visible == true)
                panelArticle.Visible = false;
            if (panelAchat.Visible == true)
                panelAchat.Visible = false;
        }

        private void showGest(Panel Gest)
        {
            if (Gest.Visible == false)
            {
                hideSubmenu();
                Gest.Visible = true;
            }
            else
                Gest.Visible = false;
        }

        private void btnVente_Click(object sender, EventArgs e)
        {
            showGest(panelVente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnAchat_Click(object sender, EventArgs e)
        {
            showGest(panelAchat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            showGest(panelArticle);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChilForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
