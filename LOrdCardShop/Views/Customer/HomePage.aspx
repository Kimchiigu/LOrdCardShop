<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LOrdCardShop.Views.Customer.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <ul>
                <li><a href="#">Home</a></li>
                <li><a href="OrderCardPage.aspx">Order Card</a></li>
                <li><a href="CardDetailPage.aspx">Card Detail</a></li>
                <li><a href="ProfilePage.aspx">Profile</a></li>
                <li><a href="HistoryPage.aspx">History</a></li>
                <li><a href="LogoutPage.aspx">Logout</a></li>
                <li><a href="CartPage.aspx">Cart</a></li>
            </ul>
        </nav>

        <div>
            Welcome, <asp:Label id="GreetLbl" runat="server" Text="username!"></asp:Label> <br />
        </div>
        
        <!-- Ini nanti nampilin 6 kartu horizontal -->
        <h2>Collectible Cards</h2>
        <asp:Repeater id="CardRepeater" runat="server">
            <ItemTemplate>
                <div class="card">
                    <asp:Label id="CardNameLbl" runat="server" Text="CardName"></asp:Label> <br />
                    <asp:Label id="CardTypeLbl" runat="server" Text="CardType"></asp:Label> <br />
                    <asp:Label id="CardPriceLbl" runat="server" Text="CardPrice"></asp:Label> <br />
                    <a href='<%# "CardDetailPage.aspx?cardId=" + Eval("CardID") %>'>View Detail</a>
                    <asp:Button id="AddToCartBtn" runat="server" Text="Add to Cart" CommandName="AddToCart" CommandArgument='<%# Eval("CardID") %>'/>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <br />

        <a href="OrderCardPage.aspx">View All Cards</a>

        <div class="bg-gray-50 px-6 py-4 text-gray-500 text-center text-xs">
            <p>© 2025 LOrd Card Shop. All rights reserved.</p>
        </div>
    </form>
</body>
</html>
