using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace VaccineReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-8O3T91G;Initial Catalog=VaccineRegistration;Integrated Security=True");
            String query = "select * from data";

            SqlCommand cmd = new SqlCommand("insert into RegistationDetails(ID, Surname, Firstname, Gender, Province) values(@ID, @Surname, @Firstname, @Gender, @Province)", cnn);
            cmd.Parameters.AddWithValue("@ID", IDtextBox.Text);
            cmd.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
            cmd.Parameters.AddWithValue("@Firstname", FirstnameTextBox.Text);
            cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
            cmd.Parameters.AddWithValue("@Province", ProvinceComboBox.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
