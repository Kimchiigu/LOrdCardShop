<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="AddCardPage.aspx.cs" Inherits="LOrdCardShop.Views.Admin.AddCardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="overflow-hidden rounded-xl bg-white shadow-xl">
            
            <div class="bg-gradient-to-r from-blue-600 to-indigo-600 p-6 text-center">
                <h1 class="text-3xl font-bold text-white">LOrd Card Shop</h1>
                <p class="mt-2 text-blue-100">Insert New Card</p>
            </div>
            
            <div class="space-y-4 p-6 text-base font-medium">
                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Name" runat="server" Text="Card Name" CssClass="block text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Name" runat="server" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Price" runat="server" Text="Card Price" CssClass="block text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Price" runat="server" TextMode="Number" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Desc" runat="server" Text="Card Description" CssClass="block text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Desc" runat="server" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Type" runat="server" Text="Card Type" CssClass="block text-gray-700"></asp:Label>
                    <asp:DropDownList ID="DDL_AddCard_Type" runat="server">
                        <asp:ListItem Text="Spell" Value="Spell"></asp:ListItem>
                        <asp:ListItem Text="Monster" Value="Monster"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Foil" runat="server" Text="Card Foil" CssClass="block text-gray-700"></asp:Label>
                    <asp:CheckBox ID="CB_AddCard_Foil" runat="server" />
                </div>
            </div>

            <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click" CssClass="m-2 mx-auto block rounded-lg border p-2 hover:bg-red-500" />
            <asp:Label ID="Lbl_Error" runat="server" Text="Error Message" CssClass="m-2 block text-center text-sm font-semibold text-red-500"></asp:Label>
        </div>
</asp:Content>
