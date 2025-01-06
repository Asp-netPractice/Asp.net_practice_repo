<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NayanGrideView2.aspx.cs" Inherits="WebApplication4.NayanGrideView2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered border-primary  table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="User_id" HeaderText="User Id" />
                    <asp:BoundField DataField="usrname" HeaderText="User Name" />
                    <asp:BoundField DataField="email" HeaderText="User Email" />
                </Columns>

            </asp:GridView>



        </div>

        <div class="container mt-3">
            <asp:GridView ID="GridView2" runat="server" CssClass="table table-bordered border-primary  table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText ="User Id">

                        <ItemTemplate ><%# Eval("User_id") %></ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="User Name">

                        <ItemTemplate><%# Eval("usrname") %></ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="User Email ID">

                        <ItemTemplate><%# Eval("email") %></ItemTemplate>

                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
