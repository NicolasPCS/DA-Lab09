<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Movie.aspx.cs" Inherits="LinqSQL.Movie1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="160px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="242px">
                <Columns>
                    <asp:BoundField DataField="Titulo" HeaderText="Title" />
                    <asp:BoundField DataField="Director " HeaderText="Director" />
                    <asp:BoundField DataField="Genre" HeaderText="Genre" />
                    <asp:BoundField DataField="Runtime" HeaderText="Runtime" />
                    <asp:BoundField DataField="Releasedata" HeaderText="ReleaseData" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
