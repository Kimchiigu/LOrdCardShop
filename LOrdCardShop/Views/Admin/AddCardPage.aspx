<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCardPage.aspx.cs" Inherits="LOrdCardShop.Views.Admin.AddCardPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Style/output.css" rel="stylesheet" />
    <title>Add Card</title>
</head>
<body class="from-blue-50 to-indigo-100 p-4 flex min-h-screen items-center justify-center bg-gradient-to-br">
    <form id="form1" runat="server" class="w-full max-w-xl">
        <div class="bg-white overflow-hidden rounded-xl shadow-xl">
            
            <div class="from-blue-600 to-indigo-600 p-6 bg-gradient-to-r text-center">
                <h1 class="text-white text-3xl font-bold">LOrd Card Shop</h1>
                <p class="text-blue-100 mt-2">Insert New Card</p>
            </div>
            
            <div class="p-6 space-y-4 text-base font-medium">
                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Name" runat="server" Text="Card Name" CssClass="text-gray-700 block"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Name" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Price" runat="server" Text="Card Price" CssClass="text-gray-700 block"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Price" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Desc" runat="server" Text="Card Description" CssClass="text-gray-700 block"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Desc" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Type" runat="server" Text="Card Type" CssClass="text-gray-700 block"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Type" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>

                <div class="space-y-1">
                    <asp:Label ID="Lbl_AddCard_Foil" runat="server" Text="Card Foil" CssClass="text-gray-700 block"></asp:Label>
                    <asp:TextBox ID="TB_AddCard_Foil" runat="server" CssClass="px-4 py-2 border-gray-300 w-full rounded-lg border transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"></asp:TextBox>
                </div>
            </div>

            <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click" CssClass="p-2 m-2 rounded-lg border block mx-auto hover:bg-red-500" />
            <asp:Label ID="Lbl_Error" runat="server" Text="ERROR" CssClass="m-2 text-red-500 text-sm font-semibold block text-center"></asp:Label>

        </div>
    </form>
</body>
</html>
