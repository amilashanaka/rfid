<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tablestructure.aspx.cs" Inherits="Tablestructure" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Galle Dialogue Seating Arrangements</title>
        <link href="Styles/Style2.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style3
        {
            width: 628px;
        }
        .style1 {
	font-size: 18px;
	font-weight: bold;
}
    </style>

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
    <td><asp:Label ID="Label1" runat="server" style="font-weight:bold;font-size:xx-large;color:#0066CC;"><div align="center">Table No</div></asp:Label></td>
  </tr>
  <tr>
    <td><div align="center"><asp:Label ID="lbltable" runat="server" 
            style="font-weight:bold;font-size:xx-large;color:Red;" Font-Bold="True" 
            Font-Size="XX-Large"></asp:Label></div></td>
  </tr>
</table>
            </ContentTemplate>
        </asp:UpdatePanel>
     
</div>
</div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

    <ContentTemplate>
<div> 
    <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick1">
    </asp:Timer>
</div>
<table width="100%" border="0" align="center">
  <tr>
    <td class="style3">

    <asp:ListView ID="RadListView1" runat="server" Skin="Default">
            <ItemTemplate>

            <div class="profile">
<table width="85%" border="0" align="center">
  <tr>
    <td height="330" colspan="2"><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("image")  %>'  Width="330" Height="370"/></td>
    <td width="20%"><asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("countryImage")  %>' Width="140" Height="100"/></td>
  </tr>
  <tr>
<td width="15%"><label><strong class="style1">Name:</strong></label></td>
    <td colspan="2"><strong class="style1"><asp:Label ID="lblRank" runat="server" Text='<%#Eval("rank")  %>'></asp:Label>&nbsp;<asp:Label ID="lblName" runat="server" Text='<%#Eval("name")  %>'></asp:Label></strong></td>
  </tr>
  <tr>
    <td></td>
    <td colspan="2"><strong class="style1"><asp:Label ID="lblAppointment" runat="server" Text='<%#Eval("appointment")  %>'></asp:Label></strong></td>
  </tr>
  <tr>
    <td><label><strong class="style1">Country:</strong></label></td>
    <td colspan="2"><strong class="style1"><asp:Label ID="lblCountry" runat="server" Text='<%#Eval("countryName")  %>'></asp:Label></strong></td>
  </tr>
<%--    <tr>
    <td><label>Table:</label></td>
    <td colspan="2"><asp:Label ID="lblposotion" runat="server" Text='<%#Eval("position")  %>'></asp:Label></td>
  </tr>--%>
</table>
</div>

            </ItemTemplate>
            </asp:ListView>
</td>
    <td>
<table width="35%" height="40" border="0" align="center" style="margin-top:1px;">
  <tr>
    <td width="20%" bgcolor="#0066CC"><div align="center" style="color:White;"><strong>Head Table</strong><br /><asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox></div></td>
  </tr>
</table>
<br />
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A1" runat="server" class="lable"><strong>A1</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B1" runat="server" class="lable"><strong>B1</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C1" runat="server" class="lable"><strong>C1</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D1" runat="server" class="lable"><strong>D1</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A2" runat="server" class="lable"><strong>A2</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B2" runat="server" class="lable"><strong>B2</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C2" runat="server" class="lable"><strong>C2</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D2" runat="server" class="lable"><strong>D2</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A3" runat="server" class="lable"><strong>A3</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B3" runat="server" class="lable"><strong>B3</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C3" runat="server" class="lable"><strong>C3</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D3" runat="server" class="lable"><strong>D3</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A4" runat="server" class="lable"><strong>A4</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B4" runat="server" class="lable"><strong>B4</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C4" runat="server" class="lable"><strong>C4</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D4" runat="server" class="lable"><strong>D4</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A5" runat="server" class="lable"><strong>A5</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B5" runat="server" class="lable"><strong>B5</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C5" runat="server" class="lable"><strong>C5</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D5" runat="server" class="lable"><strong>D5</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A6" runat="server" class="lable"><strong>A6</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B6" runat="server" class="lable"><strong>B6</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C6" runat="server" class="lable"><strong>C6</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D6" runat="server" class="lable"><strong>D6</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A7" runat="server" class="lable"><strong>A7</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B7" runat="server" class="lable"><strong>B7</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C7" runat="server" class="lable"><strong>C7</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D7" runat="server" class="lable"><strong>D7</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A8" runat="server" class="lable"><strong>A8</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B8" runat="server" class="lable"><strong>B8</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C8" runat="server" class="lable"><strong>C8</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D8" runat="server" class="lable"><strong>D8</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A9" runat="server" class="lable"><strong>A9</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B9" runat="server" class="lable"><strong>B9</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C9" runat="server" class="lable"><strong>C9</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D9" runat="server" class="lable"><strong>D9</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A10" runat="server" class="lable"><strong>A10</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B10" runat="server" class="lable"><strong>B10</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C10" runat="server" class="lable"><strong>C10</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D10" runat="server" class="lable"><strong>D10</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A11" runat="server" class="lable"><strong>A11</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B11" runat="server" class="lable"><strong>B11</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C11" runat="server" class="lable"><strong>C11</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D11" runat="server" class="lable"><strong>D11</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A12" runat="server" class="lable"><strong>A12</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B12" runat="server" class="lable"><strong>B12</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C12" runat="server" class="lable"><strong>C12</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
        <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D12" runat="server" class="lable"><strong>D12</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A13" runat="server" class="lable"><strong>A13</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B13" runat="server" class="lable"><strong>B13</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C13" runat="server" class="lable"><strong>C13</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
        <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D13" runat="server" class="lable"><strong>D13</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
<table width="95%" height="30" border="0" align="center">
  <tr>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="A14" runat="server" class="lable"><strong>A14</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">    
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="B14" runat="server" class="lable"><strong>B14</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="10%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
    <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="C14" runat="server" class="lable"><strong>C14</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
    <td width="3%">&nbsp;</td>
    <td width="20%" bgcolor="#0066CC">
        <table width="50" border="0" align="center" >
  <tr>
    <td><div align="center"><asp:Label ID="D14" runat="server" class="lable"><strong>D14</strong></asp:Label></div></td>
  </tr>
</table>
    </td>
  </tr>
</table>
</td>
  </tr>
  <tr>
    <td colspan="2"><div style="color:#0066CC;margin-top:25px;" align="center"><asp:Label ID="Footer" runat="server"><span>Copy rights @ Sri Lanka Navy 2015 | Designed and maintained by Directorate of Naval Information Technology</span></asp:Label></div></td>
  </tr>
</table>


    </ContentTemplate>
    </asp:UpdatePanel>
    
    </div>
    
    </form>

</body>
</html>
