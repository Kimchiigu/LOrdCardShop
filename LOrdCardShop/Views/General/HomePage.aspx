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
    <div class="min-h-screen flex flex-col items-center justify-center bg-gradient-to-br from-blue-100 to-indigo-200 px-6 py-12">
        <div class="w-full max-w-2xl bg-white rounded-xl shadow-xl p-8 text-center">
            <h1 class="text-3xl font-bold text-gray-800 mb-4">Welcome Home <%= Username %></h1>
            <p class="text-gray-600 text-lg">This is the content of the home page.</p>
        </div>
    </div>
</asp:Content>
