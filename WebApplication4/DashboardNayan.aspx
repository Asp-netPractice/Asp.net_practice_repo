<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashboardNayan.aspx.cs" Inherits="WebApplication4.DashboardNayan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-9">
                <h1>Welcome,
                    <asp:Literal ID="litUsername" runat="server"></asp:Literal>!</h1>
            </div>
            <div class="col-3">
                <asp:Button runat="server" CssClass="btn btn-primary w-100" Text="Logout" OnClick="Unnamed_Click" />
            </div>

        </div>
        <div class="row mb-3">

            <div class="col-auto">
                <label for="Username" class="col-form-label">Name</label>
            </div>
            <div class="col-auto">
                <input type="text" runat="server" id="Username" class="form-control" aria-describedby="passwordHelpInline" />
            </div>
        </div>

        <div class="row mb-3">

            <div class="col-auto">
                <label for="Marks" class="col-form-label">Marks</label>
            </div>
            <div class="col-auto">
                <input type="number" runat="server" id="Marks" class="form-control" aria-describedby="passwordHelpInline" />
            </div>

        </div>
        <div class="row mb-3">

            <div class="col-auto">
                <label for="Subject" class="col-form-label">Subject</label>
            </div>
            <div class="col-auto">
                <input type="text" runat="server" id="Subject" class="form-control" aria-describedby="passwordHelpInline" />
            </div>
        </div>
        <div class="row mb-3">

            <div class="col-auto">
                <asp:Button runat="server" ID="inserbtn" CssClass="btn btn-primary w-100" Text="Insert" OnClick="Insert_btn" />
            </div>
            <div class="col-auto">
                <asp:Button runat="server" ID="updatebtn" CssClass="btn btn-primary w-100" Text="Update" OnClick="Update_btn" />
            </div>
            <div class="col-auto">
                <asp:Button runat="server" ID="deletebtn" CssClass="btn btn-primary w-100" Text="Delete" OnClick="Delete_btn" />
            </div>
        </div>

    </div>

    <div class="container">
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered border-primary  table-hover" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="false">
     <Columns>
         <asp:TemplateField HeaderText="User Id">

             <ItemTemplate>
                  <asp:Literal ID="LiteralUserId" runat="server" Text='<%# Eval("Stud_id") %>'></asp:Literal>
              </ItemTemplate>

         </asp:TemplateField>

         <asp:TemplateField HeaderText="Student Name">

             <ItemTemplate>
                  <asp:Literal ID="LiteralUserName" runat="server" Text='<%# Eval("Name") %>'></asp:Literal>
               </ItemTemplate>

         </asp:TemplateField>

         <asp:TemplateField HeaderText="Marks">

             <ItemTemplate>
                  <asp:Literal ID="Literalmarks" runat="server" Text='<%# Eval("Marks") %>'></asp:Literal>
               </ItemTemplate>

         </asp:TemplateField>

         
         <asp:TemplateField HeaderText="Subject">

             <ItemTemplate>
                  <asp:Literal ID="Literalsub" runat="server" Text='<%# Eval("Subject") %>'></asp:Literal>
               </ItemTemplate>

         </asp:TemplateField>
         <asp:ButtonField CommandName="Select" Text="Select" ButtonType="Button" ShowHeader="True" HeaderText="Select"></asp:ButtonField>
     </Columns>

 </asp:GridView>
    </div>
</asp:Content>
