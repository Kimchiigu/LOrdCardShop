<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LOrdCardShop.Views.LoginPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Style/output.css" rel="stylesheet"/>
    <title>LOrdCardShop | Login</title>
</head>
<body class="flex min-h-screen items-center justify-center bg-gradient-to-br from-blue-50 to-indigo-100 p-4">
    <div class="w-full max-w-md">
        <div class="overflow-hidden rounded-xl bg-white shadow-xl">
            <div class="bg-gradient-to-r from-blue-600 to-indigo-600 p-6 text-center">
                <h1 class="text-3xl font-bold text-white">LOrd Card Shop</h1>
                <p class="mt-2 text-blue-100">Your Collectible Cards Marketplace</p>
            </div>
            
            <form id="form1" runat="server" class="space-y-6 p-6">
                <div class="space-y-2">
                    <asp:Label ID="Lbl_Login_Username" runat="server" Text="Username" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_Login_Username" runat="server" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500" placeholder="Enter your username"></asp:TextBox>
                </div>
                <div class="space-y-2">
                    <asp:Label ID="Lbl_Login_Password" runat="server" Text="Password" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_Login_Password" runat="server" TextMode="Password" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500" placeholder="Enter your password"></asp:TextBox>
                </div>
                <div class="flex items-center">
                    <asp:CheckBox ID="CB_RememberMe" runat="server" CssClass="h-4 w-4 rounded border-gray-300 text-blue-600 focus:ring-blue-500"/>
                    <asp:Label ID="Lbl_RememberMe" runat="server" Text="Remember Me" CssClass="ml-2 block text-sm text-gray-700"></asp:Label>
                </div>
                <div>
                    <asp:Button ID="Btn_Login" runat="server" OnClick="Btn_Login_Click" Text="Login" CssClass="w-full rounded-lg bg-gradient-to-r from-blue-600 to-indigo-600 px-4 py-2 font-medium text-white transition-colors hover:from-blue-700 hover:to-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500" />
                </div>
                <div>
                    <asp:Label ID="Lbl_Error" runat="server" CssClass="mt-1 text-xs text-red-500" Text=""></asp:Label>
                </div>
                <div class="text-center text-sm text-gray-600">
                    Don't have an account? 
                    <a href="RegisterPage.aspx" class="font-medium text-blue-600 hover:text-blue-500">Register here</a>
                </div>
            </form>
            <div class="bg-gray-50 px-6 py-4 text-center text-xs text-gray-500">
                <p>© 2025 LOrd Card Shop. All rights reserved.</p>
            </div>
        </div>
    </div>
</body>
</html>
