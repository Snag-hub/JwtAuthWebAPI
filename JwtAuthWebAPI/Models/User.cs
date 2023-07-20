using System.Configuration;
using System.Data.SqlClient;
namespace JwtAuthWebAPI.Models
{
    public class User
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public void Login(string username, string password)
        {
			try
			{
				string query = "select * from UserTable where username = @username and password = @password";
				using (SqlConnection con = new SqlConnection())
				{
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        //Session["username"] = username;
                        //Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        //lblError.Text = "Invalid Username or Password";
                    }
                    con.Close();
                }
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
