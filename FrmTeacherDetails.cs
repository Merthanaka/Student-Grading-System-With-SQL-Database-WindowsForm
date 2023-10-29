using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Grading_System
{
    public partial class FrmTeacherDetails : Form
    {
        public FrmTeacherDetails()
        {
            InitializeComponent();
        }
        SqlConnection connecton = new SqlConnection(@"Data Source=Win11\SQLEXPRESS;Initial Catalog=DbGrade;Integrated Security=True");

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FrmTeacherDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbGradeDataSet.TBLSTD' table. You can move, or remove it, as needed.
            this.tBLSTDTableAdapter.Fill(this.dbGradeDataSet.TBLSTD);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connecton.Open();
            SqlCommand command = new SqlCommand("insert into TBLSTD(STDNUM,STDN,STDSN )values (@P1,@P2,@P3)",connecton);
            command.Parameters.AddWithValue("@P1", msknum.Text);
            command.Parameters.AddWithValue("@P2", txtname.Text);
            command.Parameters.AddWithValue("@P3", txtsname.Text);
            command.ExecuteNonQuery();
            connecton.Close();
            MessageBox.Show("Student Sucsesfully Added!");
            this.tBLSTDTableAdapter.Fill(this.dbGradeDataSet.TBLSTD);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            msknum.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txtname.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            txtsname.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            txtex1.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            txtex2.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
            txtex3.Text = dataGridView1.Rows[choosen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, ex1, ex2, ex3;
            string status;
            ex1=Convert.ToDouble(txtex1.Text);
            ex2 = Convert.ToDouble(txtex2.Text);
            ex3 = Convert.ToDouble(txtex3.Text);


            average = (ex1 + ex2 + ex3) / 3;
            if (average >= 50)
            {
                status = "True";
            }
            else
            {
                status = "False";
            }
            lblclassavg.Text = average.ToString();
            connecton.Open();
            SqlCommand cmd = new SqlCommand("update TBLSTD set STDEX1=@P1,STDEX2=@P2,STDEX3=@P3,AVG=@P4,STATUS=@P5 WHERE STDNUM=@P6", connecton);
            cmd.Parameters.AddWithValue("@P1", txtex1.Text);
            cmd.Parameters.AddWithValue("@P2", txtex2.Text);
            cmd.Parameters.AddWithValue("@P3", txtex3.Text);
            cmd.Parameters.AddWithValue("@P4", decimal.Parse(lblclassavg.Text));
            cmd.Parameters.AddWithValue("@P5", status);
            cmd.Parameters.AddWithValue("@P6", msknum.Text);
            cmd.ExecuteNonQuery();
            connecton.Close();
            MessageBox.Show("Student Grades Are Updated");
            this.tBLSTDTableAdapter.Fill(this.dbGradeDataSet.TBLSTD);

        }
    }
}
