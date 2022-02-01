using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtFocus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pContainer.Controls)
            {
                if(ctrl is PictureBox && ctrl.Name == "pb" + txt.Name)
                {
                    ctrl.BackColor = Color.DodgerBlue;
                }
            }
        }
        private void txt_Enter1(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pContainer.Controls)
            {
                if (ctrl is Panel && ctrl.Name == "p" + txt.Name) 
                {
                    ctrl.BackColor = Color.DodgerBlue;
                }
            }
        }
        private void txt_Leave1(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pContainer.Controls)
            {
                if (ctrl is Panel && ctrl.Name == "p" + txt.Name)
                    if (txt.Text == string.Empty)
                        ctrl.BackColor = Color.Red;
                    else
                        ctrl.BackColor = Color.DarkGray;
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pContainer.Controls)
            {
                if (ctrl is PictureBox && ctrl.Name == "pb" + txt.Name)
                    if (txt.Text == string.Empty)
                        ctrl.BackColor = Color.Red;
                    else
                        ctrl.BackColor = Color.DarkGray;
            }
        }
    }
}
