using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class Default : System.Web.UI.Page
{

    String strSQLconnection = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public DataTable GetEmployee(string query)
    {

        SqlDataAdapter ada = new SqlDataAdapter(query, strSQLconnection);
        DataTable dtEmp = new DataTable();
        ada.Fill(dtEmp);
        return dtEmp;
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {

        using (SqlConnection conn = new SqlConnection(strSQLconnection))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT id,image, rank, name,appointment ,countryName,countryImage FROM RNID_M_members INNER JOIN RNID_T_tagEvents ON RNID_T_tagEvents.receivedTagId = RNID_M_members.receivedTagId  INNER JOIN HRIS_M_country ON HRIS_M_country.countryCode = RNID_M_members.countryCode GROUP BY id,image, rank, name,appointment ,countryName,countryImage order by id asc", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    RadListView1.DataSource = reader;
                    RadListView1.DataBind();
                    reader.Close();
                }
            }

            using (SqlCommand cmd = new SqlCommand("select count(*) from RNID_T_tagEvents", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    int numRec1 = Convert.ToInt32(reader[0]);
                    lblCount.Text = numRec1.ToString();
                    reader.Close();
                }
            }
        }
    }

    protected void RadListView1_ItemDeleting(object sender, ListViewDeleteEventArgs e)
    {
        string empid = "";
        Label lbl = (RadListView1.Items[e.ItemIndex].FindControl("eventID")) as Label;
        if (lbl != null)
            empid = lbl.Text;
        string DeleteQuery = "Delete from RNID_T_tagEvents WHERE id = '" + empid + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();
        SqlCommand com = new SqlCommand(DeleteQuery, con);
        com.ExecuteNonQuery();
        con.Close();
    }




}
