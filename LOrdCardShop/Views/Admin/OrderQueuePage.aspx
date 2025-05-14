<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderQueuePage.aspx.cs" Inherits="LOrdCardShop.Views.Admin.OrderQueuePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Handle Transaction</h2>

    <asp:GridView ID="GV_Transactions" runat="server" AutoGenerateColumns="False" OnRowCommand="GV_Transactions_RowCommand" DataKeyNames="TransactionID">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="Status" HeaderText="Status" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Btn_Handle" runat="server" CommandName="HandleStatus" CommandArgument='<%# Eval("TransactionID") %>' Text="Handle" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
