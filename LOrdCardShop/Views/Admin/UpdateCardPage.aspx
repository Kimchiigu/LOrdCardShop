<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateCardPage.aspx.cs" Inherits="LOrdCardShop.Views.Admin.UpdateCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <h1>Update Card</h1>
            <br />
            <asp:Label ID="CardIDLbl" runat="server" Text="Card ID: " />
            <asp:Label ID="CardID" runat="server" Text="" />
            <br />

            <asp:Label ID="CardNameLbl" runat="server" Text="Card Name: " />
            <asp:TextBox ID="CardNameTxt" runat="server" />
            <br />

            <asp:Label ID="CardPriceLbl" runat="server" Text="Card Price: " />
            <asp:TextBox ID="CardPriceTxt" runat="server" />
            <br />

            <asp:Label ID="CardDescLbl" runat="server" Text="Card Description: " />
            <asp:TextBox ID="CardDescTxt" runat="server" />
            <br />

            <asp:Label ID="CardTypeLbl" runat="server" Text="Card Type: " />
            <asp:TextBox ID="CardTypeTxt" runat="server" />
            <br />

            <asp:Label ID="IsFoilLbl" runat="server" Text="Is Foil: " />
            <asp:CheckBox ID="IsFoilChk" runat="server" />
            <br />

            <asp:Button ID="UpdateBtn" runat="server" Text="Update Card" OnClick="UpdateBtn_Click" />
            <br />

            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>

        </div>
</asp:Content>
