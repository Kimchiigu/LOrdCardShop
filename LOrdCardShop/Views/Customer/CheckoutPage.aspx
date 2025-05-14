<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="CheckoutPage.aspx.cs" Inherits="LOrdCardShop.Views.Customer.CheckoutPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <div class="row">
        <div class="col-md-12">
            <h2>Checkout Page</h2>
            <asp:GridView ID="GV_Cartl" runat="server" AutoGenerateColumns="False" DataKeyNames="CardID" CssClass="table-bordered table">
                <Columns>
                    <asp:BoundField DataField="CardID" HeaderText="ID" />
                    <asp:BoundField DataField="CardName" HeaderText="Card Name" />
                    <asp:BoundField DataField="CardPrice" HeaderText="Price" />
                    <asp:BoundField DataField="CardDesc" HeaderText="Description" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="Lbl_Error" runat="server" Text="Error"></asp:Label><br />
            <asp:Button ID="Btn_Checkout" runat="server" Text="Button" OnClick="Btn_Checkout_Click" />
        </div>
    </div>
</div>
</asp:Content>
