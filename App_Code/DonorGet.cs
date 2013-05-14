using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DonorGet
/// </summary>
public class DonorGet
{
    int pKey;
    SqlConnection connect;

	public DonorGet(int personKey)
	{
        pKey = personKey;
        connect = new SqlConnection("Data Source=localhost;initial catalog=communityassist;user=RegisteredDonorsLogin;password=P@ssw0rd1");

	}

    public DataSet GetDonation()
    {
        DataSet ds = new DataSet();
        string sql = "Select lastName, firstName from Person Where personKey = @PersonKey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@PersonKey", pKey);
        SqlDataReader reader = null;

        connect.Open();
        reader = cmd.ExecuteReader();
        ds.Load(reader, LoadOption.OverwriteChanges,"Donor");
        reader.Close();
        connect.Close();


        return ds;
    }

    public DataSet GetDonationAmount()
    {
        DataSet ds = new DataSet();
        string sql = "Select DonationDate, '$' + Cast(Cast(DonationAmount as decimal(8,2)) as nvarchar) as DonationAmount  from Donation where PersonKey=@personKey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@personKey", pKey);
        SqlDataReader reader = null;

        connect.Open();
        reader = cmd.ExecuteReader();
        ds.Load(reader, LoadOption.OverwriteChanges, "Donations");
        reader.Close();
        connect.Close();
        return ds;
       
    }
}