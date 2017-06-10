<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProdDetails.aspx.cs" Inherits="ProdDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <H1>
        Product Details.</H1>
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="product_id" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Horizontal" Height="50px" OnItemCommand="DetailsView1_ItemCommand" Width="700px">
            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="product_id" HeaderText="Product ID" ReadOnly="True" SortExpression="product_id" />
                <asp:BoundField DataField="productname" HeaderText="Product name" SortExpression="productname" />
                <asp:ImageField DataImageUrlField="productimage" HeaderText="Product Image">
                    <ControlStyle Height="150px" Width="300px" />
                </asp:ImageField>
                <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                <asp:BoundField DataField="category_id" HeaderText="Category_id" SortExpression="category_id" />
                <asp:BoundField DataField="supplier_id" HeaderText="Supplier ID" SortExpression="supplier_id" />
                <asp:BoundField DataField="saleprice" HeaderText="Sale Price" SortExpression="saleprice" />
                <asp:ButtonField ButtonType="Button" CommandName="AddToCart" Text="Add to Cart" />
                <asp:ButtonField ButtonType="Button" CommandName="SubmitReview" Text="Submit Review" />
            </Fields>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        </asp:DetailsView>
    </p>
    <p>
        Product Quantity: <asp:TextBox ID="txt_qty" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:divdevConnectionString %>" SelectCommand="SELECT * FROM [Product] WHERE ([product_id] = @product_id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="product_id" QueryStringField="product_id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <h1>Reviews.</h1>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="547px">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="Username" SortExpression="username" />
                <asp:BoundField DataField="reviewdate" HeaderText="Review Date" SortExpression="reviewdate" />
                <asp:BoundField DataField="comments" HeaderText="Comments" SortExpression="comments" />
                <asp:BoundField DataField="rating" HeaderText="Rating" SortExpression="rating" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:divdevConnectionString %>" SelectCommand="SELECT [username], [reviewdate], [comments], [rating] FROM [Review] WHERE ([product_id] = @product_id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="product_id" QueryStringField="product_id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>

