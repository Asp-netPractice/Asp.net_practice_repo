<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashGopalk.aspx.cs" Inherits="WebApplication4.DashGopalk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <title>Dashboard</title>
    <style>
       
    </style>
<body>
    <div class="container">
       <h1>Welcome, <asp:Literal ID="litUsername" runat="server"></asp:Literal>!</h1>
        <p>Your application is running successfully!</p>
        <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="Logout" OnClick="Unnamed_Click" />

    </div>
    <div class="container">
        <p> Click the buttuon insert</p>
    </div>
</body>
</asp:Content>
