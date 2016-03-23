<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project4.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

            <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Address" HeaderText="Home Address" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="State" HeaderText="State" />
                    <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
                    <asp:BoundField DataField="Square Footage" HeaderText="Square" />
                    <asp:BoundField DataField="Bedrooms" HeaderText="Number of Bedrooms" />
                    <asp:BoundField DataField="Bathrooms" HeaderText="Number of Bathrooms" />
                    <asp:BoundField DataField="Availability" HeaderText="Status" />
                </Columns>
            </asp:GridView>



            <asp:Label ID="lblAvailability" runat="server" Text="Availability: "></asp:Label><br />
            <asp:DropDownList ID="ddlAvailability" runat="server" OnSelectedIndexChanged="ddlAvailability_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>for sale</asp:ListItem>
                <asp:ListItem>Sold</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Label ID="lblBedrooms" runat="server" Text="# of Bedrooms: "></asp:Label><br />
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

            <asp:Label ID="lblBathrooms" runat="server" Text="# of Bathrooms"></asp:Label><br />
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

            <asp:Label ID="lblMinPrice" runat="server" Text="Minimum Price: "></asp:Label><br />
            <asp:DropDownList ID="ddlMinPrice" runat="server" OnSelectedIndexChanged="ddlMinPrice_SelectedIndexChanged" AutoPostBack="True">
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
        </div>

    </form>
</body>
</html>
