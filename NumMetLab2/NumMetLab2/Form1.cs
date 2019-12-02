using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using TheMainTask;

namespace NumMetLab2
{
    public partial class Form1 : Form
    {
        private MainTask task;
        private int n = 10000;
        private double xPoint;
        private double xdifference;

        public Color[] colors = {
            Color.FromArgb (45, 45, 48), //main color ///BALCK///
            Color.FromArgb (239, 139, 81), ///ORANGE///
            Color.FromArgb (241,241,241), ///WHITE///
            Color.FromArgb (113,48,20)
        };

        public Form1()
        {
            InitializeComponent();
            textBoxDiv.Text = n.ToString();

            buttonBackUpBar.Visible = false;
            SetColors(zedGraphControl1.GraphPane);
            SetColors(zedGraphControl2.GraphPane);
            SetColors(dataGridView1);

        }

        void DrawSolve(List<double> xi, List<double> ui, List<double> vi)
        {
            ZedGraph.PointPairList v_list = new ZedGraph.PointPairList();
            ZedGraph.PointPairList u_list = new ZedGraph.PointPairList();

            for (int i = 0; i < xi.Count; i++)
            {
                v_list.Add(xi[i], vi[i]);
                u_list.Add(xi[i], ui[i * 2]);
                dataGridView1.Rows.Add(i, xi[i], vi[i], ui[i * 2], Math.Abs(vi[i] - ui[i * 2]));
            }

            zedGraphControl2.GraphPane.XAxis.Min = -0.01;
            zedGraphControl2.GraphPane.XAxis.Max = 1.0;

            zedGraphControl2.GraphPane.CurveList.Clear();

            zedGraphControl2.GraphPane.Title = "Решение";

            ZedGraph.LineItem CurveV = zedGraphControl2.GraphPane.AddCurve("v(x)", v_list, colors[1], ZedGraph.SymbolType.None);
            ZedGraph.LineItem CurveU = zedGraphControl2.GraphPane.AddCurve("v2(x)", u_list, colors[3], ZedGraph.SymbolType.None);

            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();
        }

        void DrawError(List<double> xi, List<double> dif)
        {
            ZedGraph.PointPairList err_list = new ZedGraph.PointPairList();
            xdifference = xi[1];
            xPoint = xi[1];
            for (int i = 1; i < xi.Count; i++)
            {
                err_list.Add(xi[i], dif[i]);
                if(xdifference < dif[i])
                {
                    xdifference = dif[i];
                    xPoint = xi[i];
                }
            }

            zedGraphControl1.GraphPane.XAxis.Min = -0.01;
            zedGraphControl1.GraphPane.XAxis.Max = 1.0;

            zedGraphControl1.GraphPane.CurveList.Clear();

            zedGraphControl1.GraphPane.Title = "Ошибка";

            ZedGraph.LineItem CurveV = zedGraphControl1.GraphPane.AddCurve("error in scheme`s values", err_list, colors[1], ZedGraph.SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
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
            labelInfo.Visible = true;


        }

        private void buttonBackUpBar_Click(object sender, EventArgs e)
        {
            labelInfo.Visible = false;
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

        private void SetColors(GraphPane pane)
        {
            pane.FontSpec.FontColor = colors[2];

            pane.PaneBorder.Color = colors[0];

            pane.AxisBorder.Color = colors[2];

            pane.PaneFill.Type = FillType.Solid;
            pane.PaneFill.Color = colors[0];

            pane.AxisFill.Type = FillType.Solid;
            pane.AxisFill.Color = colors[0];

            pane.XAxis.IsZeroLine = true;
            pane.YAxis.IsZeroLine = true;
            pane.XAxis.Color = colors[2];
            pane.YAxis.Color = colors[2];

            pane.XAxis.IsShowGrid = true;
            pane.YAxis.IsShowGrid = true;
            pane.XAxis.GridColor = colors[2];
            pane.YAxis.GridColor = colors[2];

            pane.XAxis.ScaleFontSpec.FontColor = colors[2];
            pane.YAxis.ScaleFontSpec.FontColor = colors[2];

            pane.XAxis.TitleFontSpec.FontColor = colors[2];
            pane.YAxis.TitleFontSpec.FontColor = colors[2];

        }

        private void SetColors(DataGridView grid)
        {
            grid.ForeColor = colors[0];
        }

        private void buttonMainSolve_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBoxDiv.Text);

            Column3.HeaderText = "v(xi)";
            Column4.HeaderText = "v2(x2i)";
            Column5.HeaderText = "|v(xi) - v2(x2i)|";

            task = new MainTask();

            List<double> ai;
            List<double> di;
            List<double> phi;
            List<double> vi;
            List<double> ai2;
            List<double> di2;
            List<double> phi2;
            List<double> vi2;
            List<double> dif;
            List<double> xi = new List<double>();
            List<double> xi2 = new List<double>();
            List<double> x2i = new List<double>();
            List<double> x2i2 = new List<double>();

            List<List<double>> matrix;
            List<List<double>> matrix2;

            double h = 1.0 / n;
            task.GetGrids(ref xi, ref xi2, h);

            ai = task.GetAi(h, n, xi);
            di = task.GetDi(h, xi2);
            phi = task.GetPhi(h, xi2);
            matrix = task.GetMatrix(n, h, ai, di, phi);
            vi = task.GetDifSceme(n, matrix);

            int n2 = n * 2;
            double h2 = 1.0 / n2;
            task.GetGrids(ref x2i, ref x2i2, h2);

            ai2 = task.GetAi(h2, n2, x2i);
            di2 = task.GetDi(h2, x2i2);
            phi2 = task.GetPhi(h2, x2i2);
            matrix2 = task.GetMatrix(n2, h2, ai2, di2, phi2);
            vi2 = task.GetDifSceme(n2, matrix2);
            dif = task.GetAbsDif(vi, vi2);

            DrawSolve(xi, vi2, vi);
            DrawError(xi, dif);

            labelInfo.Text = "Для решения задачи использована равномерная сетка с числом разбиений n = " +
            n.ToString() + "\n \n" + "Задача решена с погрешностью max(|v(xi) - v2(x2i)|) = " +
            xdifference.ToString() +
            "\n \n" + "Mаксимальная разность численных решений в общих узлах сетки наблюдается в точке x = " +
            xPoint.ToString();
        }

        private void buttonTestSolve_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBoxDiv.Text);

            Column3.HeaderText = "v(xi)";
            Column4.HeaderText = "u(xi)";
            Column5.HeaderText = "|u(xi) - v(xi)|";
        }
    }
}
