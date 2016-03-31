<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project4.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jie's Realtor Website</title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Jie's Realtor Website</h1><br />
            <asp:Label ID="lblShow" runat="server" ForeColor="Green"></asp:Label><br />
            <asp:Label ID="lblWarning2" runat="server" ForeColor="Red"></asp:Label><br />
            <asp:Label ID="lblInstruction" runat="server" Text="Please select the available realtors then check the house you want to visit: "></asp:Label>
            <asp:DropDownList ID="ddlRealtor" runat="server">
                <asp:ListItem>Select:</asp:ListItem>
                <asp:ListItem>Gahbah</asp:ListItem>
                <asp:ListItem>Jason</asp:ListItem>
                <asp:ListItem>Alexia</asp:ListItem>
                <asp:ListItem>John</asp:ListItem>
                <asp:ListItem>Jie</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnReview" runat="server" Text="Schedule Visit Appointment" OnClick="btnReview_Click" /><br /><br />

            <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="False" OnRowCommand="gvHomes_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Visit Appointment">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Address" HeaderText="Home Address" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="State" HeaderText="State" />
                    <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
                    <asp:BoundField DataField="Footage" HeaderText="Square" />
                    <asp:BoundField DataField="Bedrooms" HeaderText="Number of Bedrooms" />
                    <asp:BoundField DataField="Bathrooms" HeaderText="Number of Bathrooms" />
                    <asp:BoundField DataField="CStatus" HeaderText="Status" />
                    <asp:ButtonField ButtonType="Button" CommandName="updateHouse" HeaderText="Update" Text="Update" />
                    <asp:ButtonField ButtonType="Button" CommandName="deleteHouse" HeaderText="Remove" Text="Delete" />
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
          

            <br /><asp:Button ID="btnShow" runat="server" Text="Show All" OnClick="btnShow_Click" />
            
            <br /><br />
            <asp:Button ID="btnRequest" runat="server" Text="Show Home Request" OnClick="btnRequest_Click" /><br />
            <br /><h1>Add Houses</h1>
            <asp:Label ID="lblShowEnter" runat="server" ForeColor="Green"></asp:Label><br />
            <br /><asp:Label ID="lblWarning" runat="server" ForeColor="Red"></asp:Label><br />
            <br /><asp:Label ID="lblAddress" runat="server" Text="House Address: "></asp:Label>
            <br />
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />

            <br /><asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label><br />
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />

            <br /><asp:Label ID="lblState" runat="server" Text="State: "></asp:Label><br />
            <asp:TextBox ID="txtState" runat="server"></asp:TextBox><br />

            <br /><asp:Label ID="lblPrice" runat="server" Text="Price: "></asp:Label><br />
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />

            <br /><asp:Label ID="lblFootage" runat="server" Text="Footage: "></asp:Label><br />
            <asp:TextBox ID="txtFootage" runat="server"></asp:TextBox><br />

            <br /><asp:Label ID="lblBedroom" runat="server" Text="# of Bedrooms: "></asp:Label><br />
            <asp:TextBox ID="txtBedrooms" runat="server"></asp:TextBox><br />

            <br /><asp:Label ID="lblBathroom" runat="server" Text="# of Bathrooms: "></asp:Label><br />
            <asp:TextBox ID="txtBathrooms" runat="server"></asp:TextBox><br />

            <br /><asp:Button ID="btnAdd" runat="server" Text="Add House" OnClick="btnAdd_Click" />

        </div>
    </form>
</body>
</html>
