<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterpgNayan.aspx.cs" Inherits="WebApplication4.RegisterpgNayan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="d-flex justify-content-center align-items-center vh-50">
    <div class="card shadow-lg">
        <div class="card-body">
            <h3 class="card-title text-center mb-4">Register</h3>

            <div class="mb-3">
                <label for="user_name" class="form-label">User Name</label>
                <input type="text" runat="server" id="user_name" class="form-control" />
           
            </div>
            <div class="mb-3">
                <label for="email" class="form-label">Email ID</label>
                <input type="email" runat="server" id="email_id" class="form-control" aria-describedby="emailHelp" />
                <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
            </div>
                <div class="mb-3">
                    <label for="pwd" class="form-label">Password</label>
                    <input type="password" runat="server" class="form-control" id="pwd" />
                </div>
            <%--    <div class="mb-3 form-check">
                    <input type="checkbox" runat="server" class="form-check-input" id="exampleCheck1" />
                    <label class="form-check-label" for="exampleCheck1">Check me out</label>
                </div>--%>
                <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="Submit" OnClick="Register_btn" />
      
        </div>
    </div>
</div>

</asp:Content>
