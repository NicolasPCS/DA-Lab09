<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinqEntity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>INGRESE NUMERO DE PRODUCTO</p><asp:TextBox id="codigoProducto" runat="server" ></asp:TextBox>
    <br />
    <asp:button id="botonProducto" runat="server" Text="Ingresar" OnClick="Unnamed1_Click"/>
    <br />
    <asp:Label ID ="labelProducto" runat="server"></asp:Label>
    <h1 align="center" >PRODUCTOS</h1>
    <br />
    <asp:GridView id="GriedView1" runat="server"></asp:GridView>
    <br />
    <h1 align="center">VENTAS</h1>
    <br />
    <asp:GridView ID="GriedView2" runat="server"></asp:GridView>
    
</asp:Content>
