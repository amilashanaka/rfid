<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Galle Dialogue</title>
        <link href="Styles/Style.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="main">
<div class="header">
<div class="questions" style="width:20%;height:100px;float:right;">
<asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                <table width="100%" border="0">
  <tr>
    <td><asp:Label ID="Label1" runat="server" style="font-weight:bold;font-size:larger;color:#0066CC;"><div align="center">Awaiting for Questions</div></asp:Label></td>
  </tr>
  <tr>
    <td><div align="center"><asp:Label ID="lblCount" runat="server" 
            style="font-weight:bold;font-size:xx-large;color:#0066CC;" Font-Bold="True" 
            Font-Size="XX-Large"></asp:Label></div></td>
  </tr>
</table>
            </ContentTemplate>
        </asp:UpdatePanel>
     
</div>
</div>
<div><asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick" Interval="1000">
        </asp:Timer></div>
<div class="grid">

    <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
    <ContentTemplate>
        
<table width="100%" border="0">
  <tr>
    <td> <asp:ListView ID="RadListView1" runat="server" Skin="Default" 
            onitemdeleting="RadListView1_ItemDeleting">
            <ItemTemplate>
                <fieldset style="float: left; width: 45%; height: 80px;margin-bottom:5px;background-image:url('Images/back.png');background-repeat:no-repeat;">
                    <div class="details">
                        <div class="photo-container">
    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("image")  %>'  Width="70" Height="80"/> 

                        </div>
                        <div class="data-container">
                            <ul>
                                <li>
<table width="94%" border="0">
  <tr>
    <td width="20%"><%--<label class="style1">Rank:</label>--%></td>
  <td width="80%"><%--<label class="style1"><%#Eval("rank")%></label>--%><asp:Label ID="eventID" runat="server" Text='<%# Eval("id") %>' Visible="false"></asp:Label></td>
    <td width="15%" rowspan="4"><asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("countryImage")  %>' Width="70" Height="50"/></td>
    <td width="5%" rowspan="4"><asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" >
  <img src="Images/delete.gif" alt="Delete" align="right" style="padding-bottom:5px;"/>
</asp:LinkButton></td>
  </tr>
    <tr>
    <td><label>Name:</label></td>
    <td><label><%#Eval("rank")%>&nbsp;&nbsp;<%#Eval("name")%></label></td>
  </tr>
    <tr>
    <td></td>
    <td><label><%#Eval("appointment")%></label></td>
  </tr>
    <tr>
    <td><label>Country:</label></td>
    <td><label><%#Eval("countryName")%></label></td>
  </tr>
</table>
                                </li>
                            </ul>
                        </div>
                    </div>
                </fieldset>
            </ItemTemplate>
            </asp:ListView></td>
  </tr>
  <tr>
    <td><div style="color:#0066CC;" align="center"><asp:Label ID="Footer" runat="server"><span>Copy rights @ Sri Lanka Navy 2015 | Designed and maintained by Directorate of Naval Information Technology</span></asp:Label></div></td>
  </tr>
</table>
            
            </ContentTemplate>
    </asp:UpdatePanel>
    

<%--    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:RFIDConnectionString %>" 
        SelectCommand="SELECT image, rank, name,appointment ,countryName,countryImage
FROM RNID_M_members INNER JOIN
HRIS_M_country ON HRIS_M_country.countryCode = RNID_M_members.countryCode">
    </asp:SqlDataSource>--%>

</div>
    </div>
	</form>
</body>
</html>
