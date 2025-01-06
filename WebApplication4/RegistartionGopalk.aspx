<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistartionGopalk.aspx.cs" Inherits="WebApplication4.RegistartionGopalk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-sm-7 form-group">
        <label for="Text3">First Name</label>
        <input type="text" runat="server"  id="Text3" cssClass="form-control" name="UserID"  placeholder="Enter your Name."/>
    </div>



    <div class="col-sm-6 form-group">
        <label for="Text1" >Last Name</label>
        <input type="text" runat="server" id="Text1" cssClass="form-control" name="Username"  placeholder="Enter your Last name." />
    </div>
    <div class="col-sm-6 form-group">
        <label for="Email_id">email</label>
        <input type="email" runat="server" name="Email_id" cssClass="form-control" id="email_id" placeholder="Enter your email."  />
    </div>
    <div class="col-sm-6 form-group">
        <label for="pass">Password</label>
        <input type="Password" runat="server" name="password" cssClass="form-control" id="pass" placeholder="Enter your password." />
    </div>


    <asp:Button runat="server" CssClass="w-100" Text="submit" OnClick="Unnamed_Click" />


</asp:Content>
