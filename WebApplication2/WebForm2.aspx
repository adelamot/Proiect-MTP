<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    
<html>
<head>
    <title>Books</title>
</head>
<body>
    
   <form id="form1" runat="server">
    <div class="table-div">
    <div style="width: 810px; margin: auto">
    <asp:TextBox  ID="TextBox1" Width="600px" style="display: inline-block; margin-left: 10px;" class="form-control" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <asp:Button  ID="Button1" runat="server" style="display: inline-block; margin-top:-4px;" Width="190px" class="btn" Text="Cauta&#128270;" OnClick="Button1_Click" />
    </div>
    <asp:GridView ID="GridView1" Width="800px" style=" border-radius:3px !important; margin:20px auto;" class="table table-stripped table-bordered" runat="server" BackColor="White" ForeColor="#0000CC" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand"></asp:GridView>
    <asp:Label class="label" style="display:block; margin:20px auto;" Width="800px" color="white" ID="Label1" runat="server" Text=""></asp:Label>
    <div style="width: 810px; margin: auto">
    <asp:DropDownList Width="600px" style="display: inline-block; margin-left:10px;" ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
    <asp:Button ID="Button2" Width="190px" runat="server" style="margin-top:-4px; box-sizing:border-box;display: inline-block;" class="btn" Text="Sterge Excursie" OnClick="Button2_Click" />
    </div>

    </div>
</form>

</body>
</html>
    
</asp:Content>

