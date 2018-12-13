<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:UpdatePanel ID="tagUpdate" runat="server">
            <ContentTemplate>
<br />
                Recived Tag ID
                <br />
                <asp:TextBox ID="txtTagID" runat="server" style="z-index: 1; left: 159px; top: 45px; position: absolute; width: 217px"></asp:TextBox>
<br />
                <asp:Timer ID="tagRead" runat="server" Interval="1000" OnTick="tagRead_Tick">
                </asp:Timer>
<br />
<br />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
