<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Division.aspx.cs" Inherits="WebApplication1.Division" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <asp:Label ID="Label1" runat="server" Text="Ingrese un numero"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Ingrese un  numero"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dividir" />
</p>
<p>
    <asp:Label ID="Label3" runat="server"></asp:Label>
</p>
</asp:Content>
