<%@ Page Title="Catalog" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Catalog.aspx.cs" Inherits="Catalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Catalog.</h1>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="product_id" DataSourceID="SqlDataSourceProduct" ForeColor="Black" GridLines="Horizontal" Width="1177px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="See Details" />
                <asp:BoundField DataField="product_id" HeaderText="Product ID" ReadOnly="True" SortExpression="product_id" />
                <asp:BoundField DataField="productname" HeaderText="Product Name" SortExpression="productname" />
                <asp:ImageField DataImageUrlField="productimage" HeaderText="Product Image">
                    <ControlStyle Height="150px" Width="300px" />
                    <ItemStyle Height="150px" Width="150px" />
                </asp:ImageField>
                <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                <asp:BoundField DataField="category_id" HeaderText="Category ID" SortExpression="category_id" />
                <asp:BoundField DataField="saleprice" HeaderText="Sale Price" SortExpression="saleprice" DataFormatString="{0:c}" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <br />
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSourceProduct" runat="server" ConnectionString="<%$ ConnectionStrings:divdevConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
    </p>
</asp:Content>

