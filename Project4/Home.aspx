﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project4.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblShow" runat="server" ForeColor="Green"></asp:Label>

            <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Address" HeaderText="Home Address" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="State" HeaderText="State" />
                    <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
                    <asp:BoundField DataField="Footage" HeaderText="Square" />
                    <asp:BoundField DataField="Bedrooms" HeaderText="Number of Bedrooms" />
                    <asp:BoundField DataField="Bathrooms" HeaderText="Number of Bathrooms" />
                    <asp:BoundField DataField="CStatus" HeaderText="Status" />
                </Columns>
            </asp:GridView>



        

            <asp:Label ID="lblMaxPrice" runat="server" Text="Maximum Price: "></asp:Label><br />
            <asp:DropDownList ID="ddlMaxPrice" runat="server" OnSelectedIndexChanged="ddlMaxPrice_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>50000</asp:ListItem>
                <asp:ListItem>150000</asp:ListItem>
                <asp:ListItem>200000</asp:ListItem>
                <asp:ListItem>250000</asp:ListItem>
                <asp:ListItem>300000</asp:ListItem>
                <asp:ListItem>350000</asp:ListItem>
                <asp:ListItem>400000</asp:ListItem>
                <asp:ListItem>500000</asp:ListItem>
                <asp:ListItem>1000000</asp:ListItem>
                <asp:ListItem>5000000</asp:ListItem>
                <asp:ListItem>50000000</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="lblSquare" runat="server" Text="Minimum Footage: "></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSquare" runat="server" OnSelectedIndexChanged="ddlSquare_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>500</asp:ListItem>
                <asp:ListItem>700</asp:ListItem>
                <asp:ListItem>900</asp:ListItem>
                <asp:ListItem>1100</asp:ListItem>
                <asp:ListItem>1300</asp:ListItem>
                <asp:ListItem>1500</asp:ListItem>
                <asp:ListItem>1700</asp:ListItem>
                <asp:ListItem>1900</asp:ListItem>
                <asp:ListItem>2000</asp:ListItem>
                <asp:ListItem>2500</asp:ListItem>
                <asp:ListItem>3000</asp:ListItem>
            </asp:DropDownList>
            <br />


            <asp:Label ID="lblBedrooms" runat="server" Text="Minimum Bedrooms: "></asp:Label>
            <br />
            <asp:DropDownList ID="ddlBedrooms" runat="server" OnSelectedIndexChanged="ddlBedrooms_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="lblBathrooms" runat="server" Text="Minimum Bathrooms"></asp:Label><br />
            <asp:DropDownList ID="ddlBathrooms" runat="server" OnSelectedIndexChanged="ddlBathrooms_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList><br />

        </div>

    </form>
</body>
</html>
