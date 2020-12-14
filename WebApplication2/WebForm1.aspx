<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container-login">
            <div class="login-form">
                 <h1 class="login-title">Bine ati venit!</h1>
                 <asp:Label class="label" style="display:block; margin-bottom:10px; color: white;" ID="Label1" runat="server" Text="Utilizator"></asp:Label>
                 <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
                 <asp:Label ID="Label2" style="display:block; margin-bottom:10px; color:white;" runat="server" Text="Parola"></asp:Label>
                 <asp:TextBox ID="TextBox1" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:Button ID="Button1" class="btn" runat="server"  OnClick="Button1_Click" Text="Autentificare"  ToolTip="Log in" />
            </div>
        </div>
        <link href="css/StyleSheet1.css" rel="stylesheet" />

    </form>
</asp:Content>


