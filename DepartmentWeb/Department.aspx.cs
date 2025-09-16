using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DepartmentWeb
{
    public partial class Department : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["Company"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDepartments();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                string query = "INSERT INTO Departments (DepartmentName, DepartmentID,Location) VALUES (@name, @ID, @location)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtDeptName.Text);
                cmd.Parameters.AddWithValue("@ID", txtDeptID.Text);
                cmd.Parameters.AddWithValue("@location", txtLocation.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                lblMessage.Text = "Department Added Successfully!";

            }


        }

        private void BindDepartments()
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Departments", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}
