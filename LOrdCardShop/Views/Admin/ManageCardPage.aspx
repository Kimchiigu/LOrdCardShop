<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageCardPage.aspx.cs" Inherits="LOrdCardShop.Views.Admin.ManageCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h1>Manage Card</h1>
            <br />
            <asp:GridView ID="cardGV" runat="server" AutoGenerateColumns="False" OnRowEditing="cardGV_RowEditing" OnRowDeleting="cardGV_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="CardID" HeaderText="ID"/>
                    <asp:BoundField DataField="CardName" HeaderText="Name"/>
                    <asp:BoundField DataField="CardPrice" HeaderText="Price"/>
                    <asp:BoundField DataField="CardDesc" HeaderText="Description"/>
                    <asp:BoundField DataField="CardType" HeaderText="Type"/>
                    <asp:BoundField DataField="isFoil" HeaderText="Foil"/>
                    <asp:TemplateField HeaderText="ACTIONS">
                        <ItemTemplate>
                            <asp:Button ID="UpdateBtn" runat="server" Text="Update" CommandName="Edit"/>
                            <asp:Button ID="DeleteBtn" runat="server" Text="Delete" CommandName="Delete"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click"/>
        </div>
</asp:Content>
