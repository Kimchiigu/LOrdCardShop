<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LOrdCardShop.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Style/output.css" rel="stylesheet"/>
    <title>LOrdCardShop | Register</title>
    <style>
        .calendar-container {
            width: 100%;
            border-radius: 0.5rem;
            overflow: hidden;
            box-shadow: 0 1px 3px rgba(0, 0, 0, 0.1);
            background-color: white;
        }

        .calendar-title {
            background: linear-gradient(to right, #3b82f6, #6366f1);
            color: white;
            font-weight: 600;
            padding: 0.75rem;
            text-align: center;
            margin: 0;
            border: none;
            display: flex;
            justify-content: center;
            align-items: center;
            width: 100%;
        }

        .calendar-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 0.5rem;
            width: 100%;
            margin: 0;
            border: none;
        }

        .calendar-header a {
            color: #4b5563;
            text-decoration: none;
            padding: 0.25rem 0.5rem;
            border-radius: 0.25rem;
            transition: background-color 0.2s;
        }

        .calendar-header a:hover {
            background-color: #e5e7eb;
        }

        .calendar-day-header {
            background-color: #f9fafb;
            font-weight: 500;
            color: #4b5563;
            padding: 0.5rem;
            text-align: center;
            border-bottom: 1px solid #e5e7eb;
        }

        .calendar-day {
            padding: 0.5rem;
            text-align: center;
            transition: background-color 0.2s;
        }

        .calendar-day:hover:not(.calendar-selected-day):not(.calendar-other-month) {
            background-color: #f3f4f6;
            cursor: pointer;
        }

        .calendar-selected-day {
            background-color: #3b82f6;
            color: white;
            font-weight: 500;
        }

        .calendar-today {
            border: 1px solid #3b82f6;
            font-weight: 500;
        }

        .calendar-other-month {
            color: #9ca3af;
        }

    </style>
</head>
<body class="flex min-h-screen items-center justify-center bg-gradient-to-br from-blue-50 to-indigo-100 p-4">
    <div class="w-full max-w-md">
        <div class="overflow-hidden rounded-xl bg-white shadow-xl">
            <div class="bg-gradient-to-r from-blue-600 to-indigo-600 p-6 text-center">
                <h1 class="text-3xl font-bold text-white">LOrd Card Shop</h1>
                <p class="mt-2 text-blue-100">Dive Into the Awesome World of LOrd Card</p>
            </div>
            
            <form id="form2" runat="server" class="space-y-6 p-6">
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Username" runat="server" Text="Username" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_Register_Username" runat="server" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500" placeholder="Enter your username"></asp:TextBox>
                    <div class="mt-1 text-xs text-gray-500">
                        Please enter your username
                    </div>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Email" runat="server" Text="Email" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_Register_Email" runat="server" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500" placeholder="Enter your email" TextMode="Email"></asp:TextBox>
                    <div class="mt-1 text-xs text-gray-500">
                        Email must contain '@'
                    </div>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Password" runat="server" Text="Password" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_Register_Password" runat="server" TextMode="Password" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"  placeholder="Enter your password"></asp:TextBox>
                    <div class="mt-1 text-xs text-gray-500">
                        Please enter your password
                    </div>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_ConfirmPassword" runat="server" Text="Confirm Password" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <asp:TextBox ID="TB_Register_ConfirmPassword" runat="server" TextMode="Password" CssClass="w-full rounded-lg border border-gray-300 px-4 py-2 transition-colors focus:ring-2 focus:ring-blue-500 focus:border-blue-500"  placeholder="Confirm your password"></asp:TextBox>
                    <div class="mt-1 text-xs text-gray-500">
                        Confirmation password must be the same as your password
                    </div>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_Gender" runat="server" Text="Gender" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <div class="mt-1 flex space-x-4">
                        <div class="flex items-center">
                            <asp:RadioButton ID="RB_Register_Male" runat="server" GroupName="Gender" CssClass="h-4 w-4 border-gray-300 text-blue-600 focus:ring-blue-500" Checked="true"/>
                            <label for="RB_Male" class="ml-2 block text-sm text-gray-700">Male</label>
                        </div>
                        <div class="flex items-center">
                            <asp:RadioButton ID="RB_Register_Female" runat="server" GroupName="Gender" CssClass="h-4 w-4 border-gray-300 text-blue-600 focus:ring-blue-500"/>
                            <label for="RB_Female" class="ml-2 block text-sm text-gray-700">Female</label>
                        </div>
                    </div>
                    <div class="mt-1 text-xs text-gray-500">
                        Please select your gender
                    </div>
                </div>
                <div class="space-y-1">
                    <asp:Label ID="Lbl_Register_DOB" runat="server" Text="Date of Birth" CssClass="block text-sm font-medium text-gray-700"></asp:Label>
                    <div class="overflow-hidden rounded-lg border border-gray-300">
                        <asp:Calendar ID="Calendar_DOB" runat="server" 
                            CssClass="w-full"
                            DayNameFormat="Short"
                            FirstDayOfWeek="Sunday"
                            ShowGridLines="False"
                            SelectionMode="Day"
                            TitleFormat="MonthYear"
                            
                            TitleStyle-CssClass="calendar-title"
                            NextPrevStyle-CssClass="calendar-header"
                            DayHeaderStyle-CssClass="calendar-day-header"
                            DayStyle-CssClass="calendar-day"
                            SelectedDayStyle-CssClass="calendar-selected-day"
                            TodayDayStyle-CssClass="calendar-today"
                            OtherMonthDayStyle-CssClass="calendar-other-month">
                        </asp:Calendar>
                    </div>
                    <div class="mt-1 text-xs text-gray-500">
                        Please select your date of birth
                    </div>
                </div>
                <div>
                    <asp:Button ID="Btn_Register" runat="server" OnClick="Btn_Register_Click" Text="Register" CssClass="w-full rounded-lg bg-gradient-to-r from-blue-600 to-indigo-600 px-4 py-2 font-medium text-white transition-colors hover:from-blue-700 hover:to-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-blue-500" />
                </div>
                <div>
                    <asp:Label ID="Lbl_Error" runat="server" CssClass="mt-1 text-xs text-red-500" Text=""></asp:Label>
                </div>
                <div class="text-center text-sm text-gray-600">
                    Already have an account? 
                    <a href="LoginPage.aspx" class="font-medium text-blue-600 hover:text-blue-500">Login here</a>
                </div>
            </form>

            <div class="bg-gray-50 px-6 py-4 text-center text-xs text-gray-500">
                <p>© 2025 LOrd Card Shop. All rights reserved.</p>
            </div>
        </div>
    </div>
</body>
</html>
