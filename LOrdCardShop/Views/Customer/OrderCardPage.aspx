<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderCardPage.aspx.cs" Inherits="LOrdCardShop.Views.Customer.OrderCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Available Cards</h2>
    <asp:Repeater ID="RepeaterCards" runat="server">
        <ItemTemplate>
            <div class="card-box">
                <h3><%# Eval("CardName") %> - $<%# Eval("CardPrice") %></h3>
                <asp:Button runat="server" CommandName="AddToCart" CommandArgument='<%# Eval("CardID") %>' Text="Add to Cart" OnCommand="CardCommand" />
                <asp:Button runat="server" CommandName="ViewDetail" CommandArgument='<%# Eval("CardID") %>' Text="Detail" OnCommand="CardCommand" />
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
