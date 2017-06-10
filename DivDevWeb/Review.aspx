<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Review.aspx.cs" Inherits="Review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="username,product_id,reviewdate" DataSourceID="SqlDataSource1" DefaultMode="Insert" OnItemInserted="FormView1_ItemInserted">
        <EditItemTemplate>
            username:
            <asp:Label ID="usernameLabel1" runat="server" Text='<%# Bind("username") %>' />
            <br />
            product_id:
            <asp:Label ID="product_idLabel1" runat="server" Text='<%# Bind("product_id") %>' />
            <br />
            reviewdate:
            <asp:Label ID="reviewdateLabel1" runat="server" Text='<%# Bind("reviewdate") %>' />
            <br />
            comments:
            <asp:TextBox ID="commentsTextBox" runat="server" Text='<%# Bind("comments") %>' />
            <br />
            rating:
            <asp:TextBox ID="ratingTextBox" runat="server" Text='<%# Bind("rating") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            Username:
            <asp:TextBox ID="usernameTextBox" runat="server" Text='<%# Bind("username") %>' />
            <br />
            <br />
            Product:
            <asp:TextBox ID="product_idTextBox" runat="server" Text='<%# Bind("product_id") %>' />
            <br />
            <br />
            Review Date:
            <asp:TextBox ID="reviewdateTextBox" runat="server" Text='<%# Bind("reviewdate") %>' />
            <br />
            <br />
            Comments:
            <asp:TextBox ID="commentsTextBox" runat="server" Text='<%# Bind("comments") %>' />
            <br />
            <br />
            Rating:
            <asp:TextBox ID="ratingTextBox" runat="server" Text='<%# Bind("rating") %>' />
            <br />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            username:
            <asp:Label ID="usernameLabel" runat="server" Text='<%# Bind("username") %>' />
            <br />
            product_id:
            <asp:Label ID="product_idLabel" runat="server" Text='<%# Bind("product_id") %>' />
            <br />
            reviewdate:
            <asp:Label ID="reviewdateLabel" runat="server" Text='<%# Bind("reviewdate") %>' />
            <br />
            comments:
            <asp:Label ID="commentsLabel" runat="server" Text='<%# Bind("comments") %>' />
            <br />
            rating:
            <asp:Label ID="ratingLabel" runat="server" Text='<%# Bind("rating") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:divdevConnectionString %>" DeleteCommand="DELETE FROM [Review] WHERE [username] = @username AND [product_id] = @product_id AND [reviewdate] = @reviewdate" InsertCommand="INSERT INTO [Review] ([username], [product_id], [reviewdate], [comments], [rating]) VALUES (@username, @product_id, @reviewdate, @comments, @rating)" SelectCommand="SELECT * FROM [Review]" UpdateCommand="UPDATE [Review] SET [comments] = @comments, [rating] = @rating WHERE [username] = @username AND [product_id] = @product_id AND [reviewdate] = @reviewdate">
        <DeleteParameters>
            <asp:Parameter Name="username" Type="String" />
            <asp:Parameter Name="product_id" Type="Int32" />
            <asp:Parameter DbType="Date" Name="reviewdate" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="username" Type="String" />
            <asp:Parameter Name="product_id" Type="Int32" />
            <asp:Parameter DbType="Date" Name="reviewdate" />
            <asp:Parameter Name="comments" Type="String" />
            <asp:Parameter Name="rating" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="comments" Type="String" />
            <asp:Parameter Name="rating" Type="Int32" />
            <asp:Parameter Name="username" Type="String" />
            <asp:Parameter Name="product_id" Type="Int32" />
            <asp:Parameter DbType="Date" Name="reviewdate" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

