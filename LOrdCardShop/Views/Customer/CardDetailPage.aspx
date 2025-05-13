<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="CardDetailPage.aspx.cs" Inherits="LOrdCardShop.Views.Customer.CardDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Card Details</h2>
    <asp:Panel ID="CardPanel" runat="server">
        <p><strong>Name:</strong> <asp:Label ID="LblName" runat="server" /></p>
        <p><strong>Price:</strong> <asp:Label ID="LblPrice" runat="server" /></p>
        <p><strong>Type:</strong> <asp:Label ID="LblType" runat="server" /></p>
        <p><strong>Description:</strong> <asp:Label ID="LblDesc" runat="server" /></p>
        <asp:Button ID="BtnBack" runat="server" Text="Back" OnClick="BtnBack_Click" />
    </asp:Panel>
</asp:Content>
