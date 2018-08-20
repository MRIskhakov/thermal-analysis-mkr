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
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
            textBox4.Text = Convert.ToString(Data_ElectronicMeans.alx);
            textBox5.Text = Convert.ToString(Data_ElectronicMeans.aly);
            textBox6.Text = Convert.ToString(Data_ElectronicMeans.alz);
            textBox7.Text = Convert.ToString(Data_ElectronicMeans.cr);
            textBox8.Text = Convert.ToString(Data_ElectronicMeans.ro);
            textBox9.Text = Convert.ToString(Data_ElectronicMeans.qv);
            textBox1.Text = Convert.ToString(Data_ElectronicMeans.dx);
            textBox2.Text = Convert.ToString(Data_ElectronicMeans.dy);
            textBox3.Text = Convert.ToString(Data_ElectronicMeans.dz);
            textBox20.Text = Convert.ToString(Data_ElectronicMeans.t0);
            textBox21.Text = Convert.ToString(Data_TA.tau);
            textBox22.Text = Convert.ToString(Data_TA.tmax);
            textBox16.Text = Convert.ToString(Data_TA.nx);
            textBox11.Text = Convert.ToString(Data_ElectronicMeans.alf0);
            textBox13.Text = Convert.ToString(Data_ElectronicMeans.alf1);
            textBox10.Text = Convert.ToString(Data_ElectronicMeans.alf2);
            textBox12.Text = Convert.ToString(Data_ElectronicMeans.alf3);
            textBox14.Text = Convert.ToString(Data_ElectronicMeans.alf4);
            textBox15.Text = Convert.ToString(Data_ElectronicMeans.alf5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Data_ElectronicMeans.DB_path;
            OleDbCommand command = new OleDbCommand();

            try
            {
                connection.Open();
                command.Connection = connection;
                string query = "update Data_ElectronicMeans set dx='" + (Convert.ToDouble(textBox1.Text) * 10) + "' ,dy='" + (Convert.ToDouble(textBox2.Text) * 10) + "' ,dz='"
                + (Convert.ToDouble(textBox3.Text) * 10) + "' ,alx='" + (Convert.ToDouble(textBox4.Text) * 10) + "' ,aly='" + (Convert.ToDouble(textBox5.Text) * 10) + "' ,alz='"
                + (Convert.ToDouble(textBox6.Text) * 10) + "' ,cr='" + (Convert.ToDouble(textBox7.Text)) + "' ,ro='" + (Convert.ToDouble(textBox8.Text)) + "' ,qv='"
                + (Convert.ToDouble(textBox9.Text)) + "' ,t0='" + (Convert.ToDouble(textBox20.Text)) + "' ,alf0='" + (Convert.ToDouble(textBox11.Text)) + "' ,alf1='"
                + (Convert.ToDouble(textBox13.Text)) + "' ,alf2='" + (Convert.ToDouble(textBox10.Text)) + "' ,alf3='" + (Convert.ToDouble(textBox12.Text)) + "' ,alf4='"
                + (Convert.ToDouble(textBox14.Text)) + "' ,alf5='" + (Convert.ToDouble(textBox15.Text)) + "' where id=1";
                //MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                command.Connection = connection;
                query = "update Data_TA set tau='" + (Convert.ToDouble(textBox21.Text)) + "' ,tmax='"
                    + (Convert.ToDouble(textBox22.Text)) + "' ,nx='" + (Convert.ToDouble(textBox16.Text)) + "' where id=1";
                //MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                //MessageBox.Show("Сохранение выполнено успешно!");
                connection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти без сохранеия?", Application.ProductName, MessageBoxButtons.YesNo) != DialogResult.No)
                this.Close();
        }
    }
}
