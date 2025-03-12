<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LOrdCardShop.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Style/output.css" rel="stylesheet"/>
    <title>LOrdCardShop | Register</title>
</head>
<body class="from-blue-50 to-indigo-100 p-4 flex min-h-screen items-center justify-center bg-gradient-to-br">
    <div class="w-full max-w-md">
        <div class="bg-white overflow-hidden rounded-xl shadow-xl">
            <div class="from-blue-600 to-indigo-600 p-6 bg-gradient-to-r text-center">
                <h1 class="text-white text-3xl font-bold">LOrd Card Shop</h1>
                <p class="text-blue-100 mt-2">Dive Into the Awesome World of LOrd Card</p>
            </div>
            
            <form id="form2" runat="server" class="p-6 space-y-6">
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Username" runat="server" Text="Username" CssClass="text-gray-700 block text-sm font-medium"></asp:Label>
                    <asp:TextBox ID="TB_Register_Username" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500" placeholder="Enter your username"></asp:TextBox>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Email" runat="server" Text="Email" CssClass="text-gray-700 block text-sm font-medium"></asp:Label>
                    <asp:TextBox ID="TB_Register_Email" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500" placeholder="Enter your username" TextMode="Email"></asp:TextBox>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Password" runat="server" Text="Password" CssClass="text-gray-700 block text-sm font-medium"></asp:Label>
                    <asp:TextBox ID="TB_Register_Password" runat="server" TextMode="Password" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"  placeholder="Enter your password"></asp:TextBox>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_ConfirmPassword" runat="server" Text="Confirm Password" CssClass="text-gray-700 block text-sm font-medium"></asp:Label>
                    <asp:TextBox ID="TB_Register_ConfirmPassword" runat="server" TextMode="Password" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"  placeholder="Confirm your password"></asp:TextBox>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Gender" runat="server" Text="Gender" CssClass="text-gray-700 block text-sm font-medium"></asp:Label>
                    <div class="space-x-4 mt-1 flex">
                        <div class="flex items-center">
                            <asp:RadioButton ID="RB_Register_Male" runat="server" GroupName="Gender" CssClass="h-4 w-4 text-blue-600 border-gray-300 focus:ring-blue-500" />
                            <label for="RB_Male" class="ml-2 text-gray-700 block text-sm">Male</label>
                        </div>
                        <div class="flex items-center">
                            <asp:RadioButton ID="RB_Register_Female" runat="server" GroupName="Gender" CssClass="h-4 w-4 text-blue-600 border-gray-300 focus:ring-blue-500" />
                            <label for="RB_Female" class="ml-2 text-gray-700 block text-sm">Female</label>
                        </div>
                    </div>
                </div>
                <div>
                    <asp:Button ID="Btn_Register" runat="server" OnClick="Btn_Register_Click" Text="Register" CssClass="from-blue-600 to-indigo-600 text-white py-2 px-4 w-full rounded-lg bg-gradient-to-r font-medium transition-colors hover:from-blue-700 hover:to-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500" />
                </div>
                <div class="text-gray-600 text-center text-sm">
                    Already have an account? 
                    <a href="LoginPage.aspx" class="text-blue-600 font-medium hover:text-blue-500">Login here</a>
                </div>
            </form>

            <div class="bg-gray-50 px-6 py-4 text-gray-500 text-center text-xs">
                <p>© 2025 LOrd Card Shop. All rights reserved.</p>
            </div>
        </div>
    </div>
</body>
</html>
