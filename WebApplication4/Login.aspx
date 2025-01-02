<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

       <div class="container">
  <div class="row justify-content-center align-items-center mt-5">
    <div class="col-lg-4 col-md-6 col-sm-6">
      <div class="card shadow">
        <div class="card-title text-center border-bottom">
          <h2 class="p-3">Login</h2>
        </div>
        <div class="card-body">


            <div class="mb-4">
                <label for="formGroupExampleInput" class="form-label">Email ID</label>
                <input type="text" runat="server" class="form-control" id="formGroupExampleInput" placeholder="Email ID" />

            </div>
            <div class="mb-4">
              <label for="password" class="form-label">Password</label>
              <input type="password"  runat="server" class="form-control" id="password" />
            </div>
            <div class="d-grid">
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Cssclass="btn btn-primary float-right" Text="okk" />
               
            </div>
          
            <a href="Register_page.aspx" runat="server">New user</a>

        </div>
      </div>
    </div>
  </div>
</div>


</asp:Content>
