<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Paktisk_eksamen.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        /* Styling for the dropdown menu */
        .dropdown {
            position: relative;
            display: inline-block;
        }

        /* Styling for the dropdown menu items */
        .dropdown > a {
            display: inline-block;
            padding: 8px 16px;
            background-color: #f1f1f1;
            color: #333;
            text-decoration: none;
            border: none;
            cursor: pointer;
            font-weight: bold;
        }

        /* Styling for the dropdown menu items on hover */
        .dropdown > a:hover {
            background-color: #ddd;
        }

        /* Styling for the dropdown content */
        .dropdown-content {
            display: none;
            position: absolute;
            background-color: #f9f9f9;
            min-width: 200px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            z-index: 1;
        }

        /* Styling for the dropdown menu item links */
        .dropdown-content a {
            display: block;
            padding: 8px 16px;
            text-decoration: none;
            color: #333;
        }

        /* Show the dropdown menu items on hover */
        .dropdown:hover .dropdown-content {
            display: block;
        }

        /* Styling for the nested dropdown menu */
        .nested-dropdown {
            position: relative;
            display: block;
            margin-top: 5px;
        }

        /* Styling for the nested dropdown menu items */
        .nested-dropdown-content {
            display: none;
            position: absolute;
            background-color: #f9f9f9;
            min-width: 200px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            z-index: 2;
            top: 0;
            left: 100%;
        }

        /* Styling for the nested dropdown menu items on hover */
        .nested-dropdown:hover .nested-dropdown-content {
            display: block;
        }
        
        /* Styling for the nested dropdown menu buttons */
        .nested-dropdown-content button {
            display: block;
            padding: 8px 16px;
            background-color: #f1f1f1;
            color: #333;
            text-decoration: none;
            border: none;
            cursor: pointer;
            font-weight: bold;
            margin-bottom: 5px;
        }

        /* Styling for the nested dropdown menu buttons on hover */
        .nested-dropdown-content button:hover {
            background-color: #ddd;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonSearch" runat="server" Text="Søk" OnClick="ButtonSearch_Click" />
            <asp:TextBox ID="TextBoxSearch" runat="server"></asp:TextBox>
            <asp:GridView ID="GridViewSearch" runat="server"></asp:GridView>
        </div>
    <div class="dropdown">
        <a href="#">Filter</a>
        <div class="dropdown-content">
            <div class="nested-dropdown">
                <a href="#">Fag</a>
                <div class="nested-dropdown-content">
                    <asp:Button ID="ButtonNorsk" runat="server" Text="Norsk" />
                    <asp:Button ID="ButtonEngelsk" runat="server" Text="Engelsk" />
                    <asp:Button ID="ButtonGym" runat="server" Text="Gym" />
                    <asp:Button ID="ButtonMatte" runat="server" Text="Matte" />
                    <asp:Button ID="ButtonNaturfag" runat="server" Text="Naturfag" />
                </div>
            </div>
            <div class="nested-dropdown">
                <a href="#">Klasse</a>
                <div class="nested-dropdown-content">
                    <asp:Button ID="ButtonA1" runat="server" Text="A1" />
                    <asp:Button ID="ButtonB1" runat="server" Text="B1" />
                </div>
            </div>
        </div>
        <asp:GridView ID="GridViewFilter" runat="server"></asp:GridView>
    </div>

    </form>
</body>
</html>
