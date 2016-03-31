<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestHomes.aspx.cs" Inherits="Project4.RequestHomes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Requested Visit Homes</h1>


        <asp:GridView ID="gvRequested" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Realtor" HeaderText="Assigned Realtor" />
                <asp:BoundField DataField="Address" HeaderText="Home Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
                <asp:BoundField DataField="Footage" HeaderText="Square Footage" />
                <asp:BoundField DataField="Bedrooms" HeaderText="# Of Bedroom" />
                <asp:BoundField DataField="Bathrooms" HeaderText="# Of Bathrooms" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
            </Columns>
        </asp:GridView>
    



        <br /><br />
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
    </div>
        
    </form>
</body>
</html>
