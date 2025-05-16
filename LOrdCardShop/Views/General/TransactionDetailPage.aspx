<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="LOrdCardShop.Views.General.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Transaction Detail</h2>

    <asp:GridView ID="GV_Details" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Card.CardName" HeaderText="Card Name" />
            <asp:BoundField DataField="Card.CardPrice" HeaderText="Price" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:TemplateField HeaderText="Subtotal">
                <ItemTemplate>
                    <%# (Convert.ToDouble(Eval("Card.CardPrice")) * Convert.ToInt32(Eval("Quantity"))).ToString("F2") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
