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
using System.Collections.Generic;
using System.Drawing;


public partial class Tablestructure : System.Web.UI.Page
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

    protected void Timer1_Tick1(object sender, EventArgs e)
    {

        String strSQLconnection = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;



        SqlConnection sqlConnection = new SqlConnection(strSQLconnection);

        //   SqlCommand sqlCommand = new SqlCommand("SELECT top 1 id,image, rank, name,appointment ,countryName,countryImage,position FROM RNID_M_members INNER JOIN RNID_T_tagEvents ON RNID_T_tagEvents.receivedTagId = RNID_M_members.receivedTagId  INNER JOIN HRIS_M_country ON HRIS_M_country.countryCode = RNID_M_members.countryCode GROUP BY id,image, rank, name,appointment ,countryName,countryImage,position order by id desc", sqlConnection);


        //  SqlDataReader reader = sqlCommand.ExecuteReader();


        // SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        DataSet dst = new DataSet();
        sqlConnection.Open();
        // sqlcmd.CommandType = CommandType.Text;

        SqlCommand sqlCommand = new SqlCommand("SELECT top 1 id,image, rank, name,appointment ,countryName,countryImage,position FROM RNID_M_members INNER JOIN RNID_T_tagEvents ON RNID_T_tagEvents.receivedTagId = RNID_M_members.receivedTagId  INNER JOIN HRIS_M_country ON HRIS_M_country.countryCode = RNID_M_members.countryCode GROUP BY id,image, rank, name,appointment ,countryName,countryImage,position order by id desc", sqlConnection);

        //sqlcmd.CommandText = "SELECT top 1 id,image, rank, name,appointment ,countryName,countryImage,position FROM RNID_M_members INNER JOIN RNID_T_tagEvents ON RNID_T_tagEvents.receivedTagId = RNID_M_members.receivedTagId  INNER JOIN HRIS_M_country ON HRIS_M_country.countryCode = RNID_M_members.countryCode GROUP BY id,image, rank, name,appointment ,countryName,countryImage,position order by id desc";

        // sqlcmd.ExecuteNonQuery();
        sqlda.SelectCommand = sqlCommand;
        sqlda.Fill(dst);

        TextBox2.Text = dst.Tables[0].Rows[0]["position"].ToString();
        string position = TextBox2.Text;
        lbltable.Text = TextBox2.Text;

        if (position != "---")
        {
            A1.ForeColor = Color.White;
            A2.ForeColor = Color.White;
            A3.ForeColor = Color.White;
            A4.ForeColor = Color.White;
            A5.ForeColor = Color.White;
            A6.ForeColor = Color.White;
            A7.ForeColor = Color.White;
            A8.ForeColor = Color.White;
            A9.ForeColor = Color.White;
            A10.ForeColor = Color.White;
            A11.ForeColor = Color.White;
            A12.ForeColor = Color.White;
            A13.ForeColor = Color.White;
            A14.ForeColor = Color.White;

            B1.ForeColor = Color.White;
            B2.ForeColor = Color.White;
            B3.ForeColor = Color.White;
            B4.ForeColor = Color.White;
            B5.ForeColor = Color.White;
            B6.ForeColor = Color.White;
            B7.ForeColor = Color.White;
            B8.ForeColor = Color.White;
            B9.ForeColor = Color.White;
            B10.ForeColor = Color.White;
            B11.ForeColor = Color.White;
            B12.ForeColor = Color.White;
            B13.ForeColor = Color.White;
            B14.ForeColor = Color.White;

            C1.ForeColor = Color.White;
            C2.ForeColor = Color.White;
            C3.ForeColor = Color.White;
            C4.ForeColor = Color.White;
            C5.ForeColor = Color.White;
            C6.ForeColor = Color.White;
            C7.ForeColor = Color.White;
            C8.ForeColor = Color.White;
            C9.ForeColor = Color.White;
            C10.ForeColor = Color.White;
            C11.ForeColor = Color.White;
            C12.ForeColor = Color.White;
            C13.ForeColor = Color.White;
            C14.ForeColor = Color.White;

            D1.ForeColor = Color.White;
            D2.ForeColor = Color.White;
            D3.ForeColor = Color.White;
            D4.ForeColor = Color.White;
            D5.ForeColor = Color.White;
            D6.ForeColor = Color.White;
            D7.ForeColor = Color.White;
            D8.ForeColor = Color.White;
            D9.ForeColor = Color.White;
            D10.ForeColor = Color.White;
            D11.ForeColor = Color.White;
            D12.ForeColor = Color.White;
            D13.ForeColor = Color.White;
            D14.ForeColor = Color.White;
        }
        if (position != "A1")
        {

        }
        else
        {

            A1.ForeColor = Color.Red;
            A2.ForeColor = Color.White;
            A3.ForeColor = Color.White;
            A4.ForeColor = Color.White;
            A5.ForeColor = Color.White;
            A6.ForeColor = Color.White;
            A7.ForeColor = Color.White;
            A8.ForeColor = Color.White;
            A9.ForeColor = Color.White;
            A10.ForeColor = Color.White;
            A11.ForeColor = Color.White;
            A12.ForeColor = Color.White;
            A13.ForeColor = Color.White;
            A14.ForeColor = Color.White;

            B1.ForeColor = Color.White;
            B2.ForeColor = Color.White;
            B3.ForeColor = Color.White;
            B4.ForeColor = Color.White;
            B5.ForeColor = Color.White;
            B6.ForeColor = Color.White;
            B7.ForeColor = Color.White;
            B8.ForeColor = Color.White;
            B9.ForeColor = Color.White;
            B10.ForeColor = Color.White;
            B11.ForeColor = Color.White;
            B12.ForeColor = Color.White;
            B13.ForeColor = Color.White;
            B14.ForeColor = Color.White;

            C1.ForeColor = Color.White;
            C2.ForeColor = Color.White;
            C3.ForeColor = Color.White;
            C4.ForeColor = Color.White;
            C5.ForeColor = Color.White;
            C6.ForeColor = Color.White;
            C7.ForeColor = Color.White;
            C8.ForeColor = Color.White;
            C9.ForeColor = Color.White;
            C10.ForeColor = Color.White;
            C11.ForeColor = Color.White;
            C12.ForeColor = Color.White;
            C13.ForeColor = Color.White;
            C14.ForeColor = Color.White;

            D1.ForeColor = Color.White;
            D2.ForeColor = Color.White;
            D3.ForeColor = Color.White;
            D4.ForeColor = Color.White;
            D5.ForeColor = Color.White;
            D6.ForeColor = Color.White;
            D7.ForeColor = Color.White;
            D8.ForeColor = Color.White;
            D9.ForeColor = Color.White;
            D10.ForeColor = Color.White;
            D11.ForeColor = Color.White;
            D12.ForeColor = Color.White;
            D13.ForeColor = Color.White;
            D14.ForeColor = Color.White;
        }
        if (position != "B1")
        {


        }
        else
        {

            A1.ForeColor = Color.White;
            A2.ForeColor = Color.White;
            A3.ForeColor = Color.White;
            A4.ForeColor = Color.White;
            A5.ForeColor = Color.White;
            A6.ForeColor = Color.White;
            A7.ForeColor = Color.White;
            A8.ForeColor = Color.White;
            A9.ForeColor = Color.White;
            A10.ForeColor = Color.White;
            A11.ForeColor = Color.White;
            A12.ForeColor = Color.White;
            A13.ForeColor = Color.White;
            A14.ForeColor = Color.White;

            B1.ForeColor = Color.Red;
            B2.ForeColor = Color.White;
            B3.ForeColor = Color.White;
            B4.ForeColor = Color.White;
            B5.ForeColor = Color.White;
            B6.ForeColor = Color.White;
            B7.ForeColor = Color.White;
            B8.ForeColor = Color.White;
            B9.ForeColor = Color.White;
            B10.ForeColor = Color.White;
            B11.ForeColor = Color.White;
            B12.ForeColor = Color.White;
            B13.ForeColor = Color.White;
            B14.ForeColor = Color.White;

            C1.ForeColor = Color.White;
            C2.ForeColor = Color.White;
            C3.ForeColor = Color.White;
            C4.ForeColor = Color.White;
            C5.ForeColor = Color.White;
            C6.ForeColor = Color.White;
            C7.ForeColor = Color.White;
            C8.ForeColor = Color.White;
            C9.ForeColor = Color.White;
            C10.ForeColor = Color.White;
            C11.ForeColor = Color.White;
            C12.ForeColor = Color.White;
            C13.ForeColor = Color.White;
            C14.ForeColor = Color.White;

            D1.ForeColor = Color.White;
            D2.ForeColor = Color.White;
            D3.ForeColor = Color.White;
            D4.ForeColor = Color.White;
            D5.ForeColor = Color.White;
            D6.ForeColor = Color.White;
            D7.ForeColor = Color.White;
            D8.ForeColor = Color.White;
            D9.ForeColor = Color.White;
            D10.ForeColor = Color.White;
            D11.ForeColor = Color.White;
            D12.ForeColor = Color.White;
            D13.ForeColor = Color.White;
            D14.ForeColor = Color.White;
        }
        if (position != "C1")
        {

        }
        else
        {
            A1.ForeColor = Color.White;
            A2.ForeColor = Color.White;
            A3.ForeColor = Color.White;
            A4.ForeColor = Color.White;
            A5.ForeColor = Color.White;
            A6.ForeColor = Color.White;
            A7.ForeColor = Color.White;
            A8.ForeColor = Color.White;
            A9.ForeColor = Color.White;
            A10.ForeColor = Color.White;
            A11.ForeColor = Color.White;
            A12.ForeColor = Color.White;
            A13.ForeColor = Color.White;
            A14.ForeColor = Color.White;

            B1.ForeColor = Color.White;
            B2.ForeColor = Color.White;
            B3.ForeColor = Color.White;
            B4.ForeColor = Color.White;
            B5.ForeColor = Color.White;
            B6.ForeColor = Color.White;
            B7.ForeColor = Color.White;
            B8.ForeColor = Color.White;
            B9.ForeColor = Color.White;
            B10.ForeColor = Color.White;
            B11.ForeColor = Color.White;
            B12.ForeColor = Color.White;
            B13.ForeColor = Color.White;
            B14.ForeColor = Color.White;

            C1.ForeColor = Color.Red;
            C2.ForeColor = Color.White;
            C3.ForeColor = Color.White;
            C4.ForeColor = Color.White;
            C5.ForeColor = Color.White;
            C6.ForeColor = Color.White;
            C7.ForeColor = Color.White;
            C8.ForeColor = Color.White;
            C9.ForeColor = Color.White;
            C10.ForeColor = Color.White;
            C11.ForeColor = Color.White;
            C12.ForeColor = Color.White;
            C13.ForeColor = Color.White;
            C14.ForeColor = Color.White;

            D1.ForeColor = Color.White;
            D2.ForeColor = Color.White;
            D3.ForeColor = Color.White;
            D4.ForeColor = Color.White;
            D5.ForeColor = Color.White;
            D6.ForeColor = Color.White;
            D7.ForeColor = Color.White;
            D8.ForeColor = Color.White;
            D9.ForeColor = Color.White;
            D10.ForeColor = Color.White;
            D11.ForeColor = Color.White;
            D12.ForeColor = Color.White;
            D13.ForeColor = Color.White;
            D14.ForeColor = Color.White;
        }
        if (position != "D1")
        {

        }
        else
        {
            A1.ForeColor = Color.White;
            A2.ForeColor = Color.White;
            A3.ForeColor = Color.White;
            A4.ForeColor = Color.White;
            A5.ForeColor = Color.White;
            A6.ForeColor = Color.White;
            A7.ForeColor = Color.White;
            A8.ForeColor = Color.White;
            A9.ForeColor = Color.White;
            A10.ForeColor = Color.White;
            A11.ForeColor = Color.White;
            A12.ForeColor = Color.White;
            A13.ForeColor = Color.White;
            A14.ForeColor = Color.White;

            B1.ForeColor = Color.White;
            B2.ForeColor = Color.White;
            B3.ForeColor = Color.White;
            B4.ForeColor = Color.White;
            B5.ForeColor = Color.White;
            B6.ForeColor = Color.White;
            B7.ForeColor = Color.White;
            B8.ForeColor = Color.White;
            B9.ForeColor = Color.White;
            B10.ForeColor = Color.White;
            B11.ForeColor = Color.White;
            B12.ForeColor = Color.White;
            B13.ForeColor = Color.White;
            B14.ForeColor = Color.White;

            C1.ForeColor = Color.White;
            C2.ForeColor = Color.White;
            C3.ForeColor = Color.White;
            C4.ForeColor = Color.White;
            C5.ForeColor = Color.White;
            C6.ForeColor = Color.White;
            C7.ForeColor = Color.White;
            C8.ForeColor = Color.White;
            C9.ForeColor = Color.White;
            C10.ForeColor = Color.White;
            C11.ForeColor = Color.White;
            C12.ForeColor = Color.White;
            C13.ForeColor = Color.White;
            C14.ForeColor = Color.White;

            D1.ForeColor = Color.Red;
            D2.ForeColor = Color.White;
            D3.ForeColor = Color.White;
            D4.ForeColor = Color.White;
            D5.ForeColor = Color.White;
            D6.ForeColor = Color.White;
            D7.ForeColor = Color.White;
            D8.ForeColor = Color.White;
            D9.ForeColor = Color.White;
            D10.ForeColor = Color.White;
            D11.ForeColor = Color.White;
            D12.ForeColor = Color.White;
            D13.ForeColor = Color.White;
            D14.ForeColor = Color.White;
        }
        //if (position != "A2")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.Red;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B2")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.Red;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C2")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.Red;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D2")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.Red;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A3")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.Red;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B3")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.Red;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C3")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.Red;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D3")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.Red;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A4")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.Red;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B4")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.Red;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C4")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.Red;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D4")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.Red;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A5")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.Red;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B5")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.Red;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C5")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.Red;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D5")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.Red;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A6")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.Red;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B6")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.Red;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C6")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.Red;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D6")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.Red;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A7")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.Red;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B7")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.Red;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C7")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.Red;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D7")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.Red;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A8")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.Red;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B8")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.Red;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C8")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.Red;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D8")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.Red;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A9")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.Red;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B9")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.Red;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C9")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.Red;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D9")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.Red;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A10")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.Red;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B10")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.Red;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C10")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.Red;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D10")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.Red;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A11")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.Red;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B11")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.Red;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C11")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.Red;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D11")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.Red;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A12")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.Red;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B12")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.Red;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C12")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.Red;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D12")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.Red;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A12")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.Red;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B12")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.Red;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C12")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.Red;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D12")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.Red;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A13")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.Red;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B13")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.Red;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C13")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.Red;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D13")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.Red;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "A14")
        //{

        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.Red;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "B14")
        //{


        //}
        //else
        //{

        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.Red;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "C14")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.Red;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.White;
        //}
        //if (position != "D14")
        //{

        //}
        //else
        //{
        //    A1.ForeColor = Color.White;
        //    A2.ForeColor = Color.White;
        //    A3.ForeColor = Color.White;
        //    A4.ForeColor = Color.White;
        //    A5.ForeColor = Color.White;
        //    A6.ForeColor = Color.White;
        //    A7.ForeColor = Color.White;
        //    A8.ForeColor = Color.White;
        //    A9.ForeColor = Color.White;
        //    A10.ForeColor = Color.White;
        //    A11.ForeColor = Color.White;
        //    A12.ForeColor = Color.White;
        //    A13.ForeColor = Color.White;
        //    A14.ForeColor = Color.White;

        //    B1.ForeColor = Color.White;
        //    B2.ForeColor = Color.White;
        //    B3.ForeColor = Color.White;
        //    B4.ForeColor = Color.White;
        //    B5.ForeColor = Color.White;
        //    B6.ForeColor = Color.White;
        //    B7.ForeColor = Color.White;
        //    B8.ForeColor = Color.White;
        //    B9.ForeColor = Color.White;
        //    B10.ForeColor = Color.White;
        //    B11.ForeColor = Color.White;
        //    B12.ForeColor = Color.White;
        //    B13.ForeColor = Color.White;
        //    B14.ForeColor = Color.White;

        //    C1.ForeColor = Color.White;
        //    C2.ForeColor = Color.White;
        //    C3.ForeColor = Color.White;
        //    C4.ForeColor = Color.White;
        //    C5.ForeColor = Color.White;
        //    C6.ForeColor = Color.White;
        //    C7.ForeColor = Color.White;
        //    C8.ForeColor = Color.White;
        //    C9.ForeColor = Color.White;
        //    C10.ForeColor = Color.White;
        //    C11.ForeColor = Color.White;
        //    C12.ForeColor = Color.White;
        //    C13.ForeColor = Color.White;
        //    C14.ForeColor = Color.White;

        //    D1.ForeColor = Color.White;
        //    D2.ForeColor = Color.White;
        //    D3.ForeColor = Color.White;
        //    D4.ForeColor = Color.White;
        //    D5.ForeColor = Color.White;
        //    D6.ForeColor = Color.White;
        //    D7.ForeColor = Color.White;
        //    D8.ForeColor = Color.White;
        //    D9.ForeColor = Color.White;
        //    D10.ForeColor = Color.White;
        //    D11.ForeColor = Color.White;
        //    D12.ForeColor = Color.White;
        //    D13.ForeColor = Color.White;
        //    D14.ForeColor = Color.Red;
        //}
        
        RadListView1.DataSource = dst.Tables[0];
        RadListView1.DataBind();


        sqlConnection.Close();



    }


}
