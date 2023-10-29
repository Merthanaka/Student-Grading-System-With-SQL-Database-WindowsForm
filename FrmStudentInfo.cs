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
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connecton = new SqlConnection(@"Data Source=Win11\SQLEXPRESS;Initial Catalog=DbGrade;Integrated Security=True");
        public string number;
        //Data Source=Win11\SQLEXPRESS;Initial Catalog=DbGrade;Integrated Security=True
        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            lblNumber.Text = number;
            connecton.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBLSTD where STDNUM=@p1", connecton);
            sqlCommand.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[2].ToString() +" "+ dr[3].ToString();
                lblEx1.Text = dr[4].ToString();
                lblEx2.Text = dr[5].ToString();
                lblx3.Text = dr[6].ToString();
                lblAvg.Text = dr[7].ToString();
                lblStat.Text = dr[8].ToString();
            }
            connecton.Close();
        }
    }
}
