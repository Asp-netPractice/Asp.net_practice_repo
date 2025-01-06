<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GrideviewNayan.aspx.cs" Inherits="WebApplication4.GrideviewNayan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered border-primary  table-hover" AutoGenerateColumns="False">

        <Columns>
            <asp:BoundField DataField="User_id" HeaderText ="User_id" />
            <asp:BoundField DataField="usrname" HeaderText ="User Name" />
            <asp:BoundField DataField="email" HeaderText ="User Email Id" />
            <asp:BoundField DataField="create_at" HeaderText ="User Created At" />


        </Columns>
   
    </asp:GridView>

    <asp:GridView ID="GridView2" runat="server" CssClass="table   table-hover " AutoGenerateColumns="False" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">

        <Columns>
            <asp:TemplateField HeaderText="User Id" >
                <ItemTemplate>  <asp:Literal ID="LiteralUserId" runat="server" Text='<%# Eval("User_id") %>'></asp:Literal>

                </ItemTemplate>

            </asp:TemplateField>
   
            <asp:TemplateField HeaderText="User Name">
                <ItemTemplate>
                     <asp:Literal ID="LiteralUserName" runat="server" Text='<%# Eval("usrname") %>'></asp:Literal>
                </ItemTemplate>

            </asp:TemplateField>

            <asp:ButtonField CommandName="Select"  Text="Button" ButtonType="Button" ShowHeader="True" HeaderText="Delete"></asp:ButtonField>
        </Columns>

    </asp:GridView>
  
</asp:Content>
