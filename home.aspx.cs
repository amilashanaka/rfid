using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class home : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("Data Source=TELERIK\\SQLEXPRESS;Initial Catalog=RFID;Integrated Security=True");


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void tagRead_Tick(object sender, EventArgs e)
    {
        SqlDataReader rdr;
        String sqlread = "";

        sqlread = "select TOP 1  receivedTagId from dbo.RNID_T_tagEvents order by  id desc";

        SqlCommand cmd = new SqlCommand(sqlread, con);

        

        //txtName.Text = "Search";
        try
        {
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtTagID.Text = rdr.GetString(0);

            rdr.Close();
            con.Close();

        }
        catch (Exception)
        {

            
        }


        


        




    }
}