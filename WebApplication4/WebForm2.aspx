<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication4.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                  <div class="col-sm-7 form-group">
                  <label for="UserID">First Name</label>
                  <input type="text" runat="server" class="form-control" name="UserID" id="Text3" placeholder="Enter your userID." required>
                </div>
                    <div class="col-sm-6 form-group">
                  <label for="Username">First Name</label>
                  <input type="text" runat="server" class="form-control" name="Username" id="Text1" placeholder="Enter your username." required>
                </div>
                    <div class="col-sm-6 form-group">
                  <label for="pass">Password</label>
                  <input type="Password" runat="server" name="password" class="form-control" id="pass" placeholder="Enter your password." required>
                </div>
                    <div class="col-sm-6 form-group">
                          <label for="email_id">email</label>
                     <input type="email" runat="server" name="Email_id" class="form-control" id="email_id" placeholder="Enter your email." required/>
                </div>
               <%-- <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="Submit" OnClick="Unnamed_Click" />
           --%>
      <asp:Button runat="server" CssClass="w-100" Text="submit" OnClick="Unnamed_Click" />
        </div>
    </div>
</div>

</asp:Content>
