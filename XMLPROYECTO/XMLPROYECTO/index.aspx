<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="XMLPROYECTO.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID ="cmdCreateXml" Text="Crear XML" runat="server" OnClick="cmdCreateXml_Click"/>
            <asp:Button ID ="cmdReadXml" Text="Leer XML (Como texto)" runat="server"/>
            <asp:Button ID ="cmdReadXmlAsObjects" Text="Leer XML (Como objeto)" runat="server"/>
            <br />
            <asp:Label ID="lblXml" runat="server"></asp:Label>
            <asp:GridView ID ="gridResults" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
