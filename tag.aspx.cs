using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
 

public partial class tag : System.Web.UI.Page
{
    // connection string 
    SqlConnection con = new SqlConnection("Data Source=TELERIK\\SQLEXPRESS;Initial Catalog=RFID;Integrated Security=True");


    public String idb = "0";
    public String ida = "0";
    public String idc = "0";
    public String idd = "0";
    public String current_time;


    protected void Page_Load(object sender, EventArgs e)
    {
         

        ida = Request.QueryString["A"];
        idb = Request.QueryString["B"];
        idc = Request.QueryString["C"];
        idd = Request.QueryString["D"];


        current_time = System.DateTime.Now.ToString().Trim();

        String sql = String.Empty;
        String sqlselect = String.Empty;
      int count = 0;

      sqlselect = "select *   from [dbo].[RNID_T_tagEvents] where [receivedTagId] = '" + ida + idb + idc + idd + "'";
        sql = "INSERT INTO [RFID].[dbo].[RNID_T_tagEvents] ([receivedTagId] ,[receivedTime]) VALUES ('" + ida + idb + idc + idd + "','" + current_time + "')";

        SqlCommand cmd2 = new SqlCommand(sqlselect, con);
        SqlDataReader rd;

        SqlCommand cmd = new SqlCommand(sql, con);
        

        try
        {
            con.Open();
            rd = cmd2.ExecuteReader();

               while (rd.Read())
               {
                   count++;
               }

        }
        catch (Exception)
        {

        }
 
        con.Close();


        txtTagID.Text = count.ToString();

        if (count==0)
        {
            try
            {
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

            }

            catch
            {

            }


        }

       
    }
}