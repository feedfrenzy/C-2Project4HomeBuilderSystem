<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateHomes.aspx.cs" Inherits="Project4.UpdateHomes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Update Selected Homes</h1>

        <asp:GridView ID="gvSelectedHomes" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Address" HeaderText="Selected Homes" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
                <asp:BoundField DataField="Footage" HeaderText="Square Foot" />
                <asp:BoundField DataField="Bedrooms" HeaderText="Bedrooms" />
                <asp:BoundField DataField="Bathrooms" HeaderText="Bathrooms" />
                <asp:BoundField DataField="CStatus" HeaderText="Status" />
            </Columns>
        </asp:GridView>
        <br />


        <asp:Label ID="lblAddress" runat="server" Text="House Address: "></asp:Label><br />
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />

        <br />
        <asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label><br />
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />

        <br />
        <asp:Label ID="lblState" runat="server" Text="State: "></asp:Label><br />
        <asp:TextBox ID="txtState" runat="server"></asp:TextBox><br />

        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price: "></asp:Label><br />
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />

        <br />
        <asp:Label ID="lblFootage" runat="server" Text="Footage: "></asp:Label><br />
        <asp:TextBox ID="txtFootage" runat="server"></asp:TextBox><br />

        <br />
        <asp:Label ID="lblBedroom" runat="server" Text="# of Bedrooms: "></asp:Label><br />
        <asp:TextBox ID="txtBedrooms" runat="server"></asp:TextBox><br />

        <br />
        <asp:Label ID="lblBathroom" runat="server" Text="# of Bathrooms: "></asp:Label><br />
        <asp:TextBox ID="txtBathrooms" runat="server"></asp:TextBox><br />

        <br /><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br />
        <br /><asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        
        <br />
    </form>
</body>
</html>
