<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LOrdCardShop.Views.Customer.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* HTML RESET */
        *,
        *::before,
        *::after {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        html,
        body {
            font-family: 'ui-sans-serif', 'system-ui', sans-serif;
            background-color: #f9fafb;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="flex min-h-screen flex-col items-center justify-center bg-gradient-to-br from-blue-100 to-indigo-200 px-6 py-12">
        <div class="w-full max-w-2xl rounded-xl bg-white p-8 text-center shadow-xl">
            <h1 class="mb-4 text-3xl font-bold text-gray-800">Welcome Home <%= Username %></h1>
            <p class="text-lg text-gray-600">This is the content of the home page.</p>
        </div>
    </div>
</asp:Content>
