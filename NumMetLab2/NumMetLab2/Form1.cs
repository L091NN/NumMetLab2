using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumMetLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonBackUpBar.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            buttonMainSolve.BackgroundImage = null;
            buttonTestSolve.BackgroundImage = null;
            buttonInfo.BackgroundImage = null;
            panelBar.Width = 300;
            buttonMenu.Visible = false;
            panelBarUpBack.Height = 100;
            buttonBackUpBar.Visible = true;
            buttonMainSolve.Height = 100;
            buttonTestSolve.Height = 100;
            buttonInfo.Height = 100;
            buttonMainSolve.Text = "Решить основную задачу";
            buttonTestSolve.Text = "Решить тестовую задачу";
            buttonInfo.Text = "Информация о задачах";


        }

        private void buttonBackUpBar_Click(object sender, EventArgs e)
        {
            buttonMainSolve.Text = "";
            buttonTestSolve.Text = "";
            buttonInfo.Text = "";
            buttonMainSolve.Height = 150;
            buttonTestSolve.Height = 150;
            buttonInfo.Height = 150;
            buttonBackUpBar.Visible = false;
            panelBarUpBack.Height = 31;
            buttonMenu.Visible = true;
            panelBar.Width = 100;
            buttonMainSolve.BackgroundImage = global::NumMetLab2.Properties.Resources.playwithcircularbuttonwithrightarrowofboldroundedfilledtriangle_80162;
            buttonTestSolve.BackgroundImage = global::NumMetLab2.Properties.Resources._3700408_archive_document_education_exam_file_test_108771;
            buttonInfo.BackgroundImage = global::NumMetLab2.Properties.Resources.round_info_button_icon_icons_com_72584;
        }

    }
}
