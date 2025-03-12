<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LOrdCardShop.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://unpkg.com/@tailwindcss/browser@4"></script>
    <title>LOrdCardShop - Login</title>
    <script>
        tailwind.config = {
            theme: {
                extend: {
                    colors: {
                        primary: '#3b82f6',
                        secondary: '#10b981',
                        accent: '#8b5cf6',
                        background: '#f9fafb',
                        card: '#ffffff'
                    }
                }
            }
        }
    </script>
</head>
<body class="from-blue-50 to-indigo-100 p-4 flex min-h-screen items-center justify-center bg-gradient-to-br">
    <div class="w-full max-w-md">
        <div class="bg-white overflow-hidden rounded-xl shadow-xl">
            <div class="from-blue-600 to-indigo-600 p-6 bg-gradient-to-r text-center">
                <h1 class="text-white text-3xl font-bold">LOrd Card Shop</h1>
                <p class="text-blue-100 mt-2">Your Collectible Cards Marketplace</p>
            </div>
            
            <form id="form1" runat="server" class="p-6 space-y-6">
                <div class="space-y-2">
                    <asp:Label ID="Lbl_Username" runat="server" Text="Username" CssClass="text-gray-700 block text-sm font-medium"></asp:Label>
                    <asp:TextBox ID="TB_Username" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500" placeholder="Enter your username"></asp:TextBox>
                </div>
                <div class="space-y-2">
                    <asp:Label ID="Lbl_Password" runat="server" Text="Password" CssClass="text-gray-700 block text-sm font-medium"></asp:Label>
                    <asp:TextBox ID="TB_Password" runat="server" TextMode="Password" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"  placeholder="Enter your password"></asp:TextBox>
                </div>
                <div class="flex items-center">
                    <asp:CheckBox ID="CB_RememberMe" runat="server" CssClass="h-4 w-4 text-blue-600 border-gray-300 rounded focus:ring-blue-500"/>
                    <asp:Label ID="Lbl_RememberMe" runat="server" Text="Remember Me" CssClass="ml-2 text-gray-700 block text-sm"></asp:Label>
                </div>
                <div>
                    <asp:Button ID="Btn_Login" runat="server" Text="Login" CssClass="from-blue-600 to-indigo-600 text-white py-2 px-4 w-full rounded-lg bg-gradient-to-r font-medium transition-colors hover:from-blue-700 hover:to-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500" />
                </div>
                <div class="text-gray-600 text-center text-sm">
                    Don't have an account? 
                    <a href="RegisterPage.aspx" class="text-blue-600 font-medium hover:text-blue-500">Register here</a>
                </div>
            </form>

            <div class="bg-gray-50 px-6 py-4 text-gray-500 text-center text-xs">
                <p>© 2025 LOrd Card Shop. All rights reserved.</p>
            </div>
        </div>
    </div>
</body>
</html>
