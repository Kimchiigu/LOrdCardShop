<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="LOrdCardShop.Views.General.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Update Profile</h2>
    <asp:Label ID="LblError" runat="server" ForeColor="Red" />
    <br />

    <asp:Label Text="Username:" runat="server" />
    <asp:TextBox ID="TB_Username" runat="server" /><br />

    <asp:Label Text="Email:" runat="server" />
    <asp:TextBox ID="TB_Email" runat="server" /><br />

    <asp:Label Text="Gender:" runat="server" />
    <asp:DropDownList ID="DDL_Gender" runat="server">
        <asp:ListItem Text="-- Select Gender --" Value="" />
        <asp:ListItem Text="Male" Value="Male" />
        <asp:ListItem Text="Female" Value="Female" />
    </asp:DropDownList><br />

    <hr />
    <h3>Change Password</h3>
    <asp:Label Text="Old Password:" runat="server" />
    <asp:TextBox ID="TB_OldPassword" runat="server" TextMode="Password" /><br />

    <asp:Label Text="New Password:" runat="server" />
    <asp:TextBox ID="TB_NewPassword" runat="server" TextMode="Password" /><br />

    <asp:Label Text="Confirm Password:" runat="server" />
    <asp:TextBox ID="TB_ConfirmPassword" runat="server" TextMode="Password" /><br />

    <br />
    <asp:Button ID="Btn_Update" runat="server" Text="Update Profile" OnClick="Btn_Update_Click" />
</asp:Content>
