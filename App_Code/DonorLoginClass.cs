using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DonorLoginClass
/// </summary>
public class DonorLoginClass
{
    private SqlConnection connect;

	public DonorLoginClass()
	{
        connect = new SqlConnection(@"Data Source=localhost;initial catalog=communityAssist;user=DonorsLogin;password=P@ssw0rd1");
	}

    public int Login(string userName, string password)
    {
        int pKey=0;
        string sql = "Select personkey, Lastname, DonorPassword From DonorLogin where Lastname=@user and DonorPassword=@Password";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@user", userName);
        cmd.Parameters.AddWithValue("@Password", password);
        SqlDataReader reader = null;

        connect.Open();
        reader=cmd.ExecuteReader();
        while (reader.Read())
        {
            if (reader["personKey"] != null)
            {
                pKey = (int)reader["personKey"];
            }
        }
        reader.Close();
        connect.Close();

        return pKey;
    }


}