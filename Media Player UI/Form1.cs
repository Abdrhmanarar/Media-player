using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Media_Player_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizDesign();
        }
        private void CustomizDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            PanelToolsSubMenu.Visible = false;
            //..
        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (PanelToolsSubMenu.Visible == true)
                PanelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void panelPlaylistSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
         private void button8_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void btnEqu_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelToolsSubMenu);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //Your Code
            //..
            hideSubMenu();
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
