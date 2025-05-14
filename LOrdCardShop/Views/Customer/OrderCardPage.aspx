<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderCardPage.aspx.cs" Inherits="LOrdCardShop.Views.Customer.OrderCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Available Cards</h2>

    <asp:GridView ID="GV_Cards" runat="server" AutoGenerateColumns="False" OnRowCommand="GV_Cards_RowCommand" DataKeyNames="CardID" CssClass="table-bordered table">
        <Columns>
            <asp:BoundField DataField="CardName" HeaderText="Card Name" />
            <asp:BoundField DataField="CardPrice" HeaderText="Price" />

            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="TB_Quantity" runat="server" Text="1" Width="50px" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Btn_Add" runat="server" Text="Add to Cart" CommandName="AddToCart" CommandArgument='<%# Eval("CardID") %>' />
                    <asp:Button ID="Btn_Detail" runat="server" Text="Detail" CommandName="ViewDetail" CommandArgument='<%# Eval("CardID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
