<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashboardNayan.aspx.cs" Inherits="WebApplication4.DashboardNayan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div>
        <h1>Welcome, <asp:Literal ID="litUsername" runat="server"></asp:Literal>!</h1>
          <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="Logout" OnClick="Unnamed_Click" />
  </div>
</asp:Content>
