<%@ Page Title="DASHBOARD" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashGopalk.aspx.cs" Inherits="WebApplication4.DashGopalk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
   

        <div class="container.accordion-body ">
            <h1>Welcome,
                <asp:Literal ID="litUsername" runat="server"></asp:Literal>!</h1>
            <p>Your application is running successfully!</p>
           

        </div>
        <asp:Button type="button" runat="server" class="btn btn-primary w-100 " Text="Logout" OnClick="Unnamed_Click" ></asp:Button>
    
                    <h3 class="card-title text-center mb-4">Student data</h3>

                    <div class="mb-3">
                        <label for="stdname" class="form-label">Student Name</label>
                        <input type="Text" runat="server" id="stdname" class="form-control" />

                    </div>
                    <div class="mb-3">
                        <label for="rollno" class="form-label">Roll No</label>
                        <input type="Text" runat="server" class="form-control" id="rollno" />
                    </div>
                    <div class="mb-3">
                        <label for="marks" class="form-label">Marks in subject</label>
                        <input type="Text" runat="server" class="form-control" id="marks" />
                    </div>
                    <div class="mb-3">
                        <label for="subject" class="form-label">Subject Name</label>
                        <input type="Text" runat="server" class="form-control" id="subject" />
                    </div>

                    <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="INSERT" OnClick="insrt_btn" />
                    <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="DELETE" OnClick="dlt_btn" />
                     <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="UPDATE" OnClick="updt_btn" />
                    
  
</asp:Content>
