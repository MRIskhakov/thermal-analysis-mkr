using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тепловой_анализ_МКР
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chartMain.Visible = false;
            comboBoxSwitchChart.Visible = false;
            dataGridViewSurfaceTemp.Visible = false;
        }



        private void toolStripButtonOpenDataBase_Click(object sender, EventArgs e)
        {

            openFileDialogDataBase.ShowDialog();
            
        }

        private void toolStripButtonStartTA_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + openFileDialog1.FileName;
            Data_ElectronicMeans.DB_path = openFileDialog1.FileName;
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "SELECT * FROM Data_ElectronicMeans";
            command.Connection = connection;
            try
            {
                connection.Open();
                OleDbDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Data_ElectronicMeans.dx = ((double)dr.GetInt32(1));
                    Data_ElectronicMeans.dy = ((double)dr.GetInt32(2));
                    Data_ElectronicMeans.dz = ((double)dr.GetInt32(3));
                    Data_ElectronicMeans.alx = ((double)dr.GetInt32(4));
                    Data_ElectronicMeans.aly = ((double)dr.GetInt32(5));
                    Data_ElectronicMeans.alz = ((double)dr.GetInt32(6));
                    Data_ElectronicMeans.cr = ((double)dr.GetInt32(7));
                    Data_ElectronicMeans.ro = ((double)dr.GetInt32(8));
                    Data_ElectronicMeans.qv = ((double)dr.GetInt32(9));
                    Data_ElectronicMeans.t0 = ((double)dr.GetInt32(10));
                    Data_ElectronicMeans.kof = ((double)dr.GetInt32(11));
                    Data_ElectronicMeans.alf0 = ((double)dr.GetInt32(12));
                    Data_ElectronicMeans.alf1 = ((double)dr.GetInt32(13));
                    Data_ElectronicMeans.alf2 = ((double)dr.GetInt32(14));
                    Data_ElectronicMeans.alf3 = ((double)dr.GetInt32(15));
                    Data_ElectronicMeans.alf4 = ((double)dr.GetInt32(16));
                    Data_ElectronicMeans.alf5 = ((double)dr.GetInt32(17));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка получения данных " /*+ ex.ToString()*/);
                return;
            }
            finally
            {
                connection.Close();
            }

            command.CommandText = "SELECT * FROM Data_TA";
            command.Connection = connection;
            try
            {
                connection.Open();
                OleDbDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Data_TA.tau = (double)dr.GetInt32(1);
                    Data_TA.tmax = (double)dr.GetInt32(2);
                    Data_TA.nx = dr.GetInt32(3);
                    Data_TA.ny = dr.GetInt32(4);
                    Data_TA.nz = dr.GetInt32(5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка получения данных "/* + ex.ToString()*/);
            }
            finally
            {
                connection.Close();
            }
            chartMain.Visible = true;
            comboBoxSwitchChart.Visible = true;
            dataGridViewSurfaceTemp.Visible = true;
            comboBoxSwitchChart.Text = "Ось X";
            if ((comboBoxSwitchChart.Text == "Ось X") && (Data_TA.nx != 0))
            {
                ThermalAnalysis TA = new ThermalAnalysis();
                Tuple<double[], double[], double[], double[], int> result = TA.start();

                this.chartMain.Series["Ось X"].Points.Clear();
                this.chartMain.Series["Ось Y"].Points.Clear();
                this.chartMain.Series["Ось Z"].Points.Clear();
                for (int i = 0; i < result.Item5 + 1; i++)
                {
                    this.chartMain.Series["Ось X"].Points.AddXY(i, result.Item1[i]);
                }

                dataGridViewSurfaceTemp.Columns.Add("index", "Поверхность №");
                dataGridViewSurfaceTemp.Columns.Add("value", "Температура");
                dataGridViewSurfaceTemp.Rows.Add(6);
                for (int i = 0; i < 6; i++)
                {
                    dataGridViewSurfaceTemp.Rows[i].Cells["index"].Value = i + 1;
                    dataGridViewSurfaceTemp.Rows[i].Cells["value"].Value = result.Item4[i + 1];
                }
            }
            else
                MessageBox.Show("Исходные данные не введены, либо некорректны");
        }

        private void toolStripButtonQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", Application.ProductName, MessageBoxButtons.YesNo) != DialogResult.No)
                Application.Exit();
        }

        private void ToolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            toolStripButtonQuit_Click(sender, e);
        }

        private void ToolStripMenuItemOpenDataBase_Click(object sender, EventArgs e)
        {
            toolStripButtonOpenDataBase_Click(sender, e);
        }

        private void ToolStripMenuItemStartTA_Click(object sender, EventArgs e)
        {
            toolStripButtonStartTA_Click(sender, e);
        }

        private void ToolStripMenuItemChangeProperties_Click(object sender, EventArgs e)
        {
            if (Data_TA.nx != 0)
            {
                PropertiesForm PropertiesForm = new PropertiesForm();
                PropertiesForm.Show();
            }
            else
            {
                MessageBox.Show("База данных не открыта");
                return;
            }
        }

        private void comboBoxSwitchChart_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                if ((comboBoxSwitchChart.Text == "Ось X") && (Data_TA.nx != 0))
            {
                ThermalAnalysis TA = new ThermalAnalysis();
                Tuple<double[], double[], double[], double[], int> result = TA.start();

                this.chartMain.Series["Ось X"].Points.Clear();
                this.chartMain.Series["Ось Y"].Points.Clear();
                this.chartMain.Series["Ось Z"].Points.Clear();
                for (int i = 0; i < result.Item5 + 1; i++)
                {
                    this.chartMain.Series["Ось X"].Points.AddXY(i, result.Item1[i]);
                }
                return;
            }

            if ((comboBoxSwitchChart.Text == "Ось Y") && (Data_TA.nx != 0))
            {
                ThermalAnalysis TA = new ThermalAnalysis();
                Tuple<double[], double[], double[], double[], int> result = TA.start();

                this.chartMain.Series["Ось X"].Points.Clear();
                this.chartMain.Series["Ось Y"].Points.Clear();
                this.chartMain.Series["Ось Z"].Points.Clear();
                for (int i = 0; i < result.Item5 + 1; i++)
                {
                    this.chartMain.Series["Ось Y"].Points.AddXY(i, result.Item2[i]);
                }
            }

            if ((comboBoxSwitchChart.Text == "Ось Z") && (Data_TA.nx != 0))
            {
                ThermalAnalysis TA = new ThermalAnalysis();
                Tuple<double[], double[], double[], double[], int> result = TA.start();

                this.chartMain.Series["Ось X"].Points.Clear();
                this.chartMain.Series["Ось Y"].Points.Clear();
                this.chartMain.Series["Ось Z"].Points.Clear();
                for (int i = 0; i < result.Item5 + 1; i++)
                {
                    this.chartMain.Series["Ось Z"].Points.AddXY(i, result.Item3[i]);
                }
            }

        }

        private void toolStripButtonChangeProperties_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemChangeProperties_Click(sender, e);
        }
    }
}
