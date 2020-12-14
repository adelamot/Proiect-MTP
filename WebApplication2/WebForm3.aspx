<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><!DOCTYPE html>

<html>
<head>
    <title>Coffee</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-login">
           <div class="login-form">
               <h1 class="login-title">Adauga excursie</h1>
               <asp:Label class="label" style="display:block; margin-bottom:10px; color: white;" ID="Label1" runat="server" Text="Locatie"></asp:Label>
               <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
               <asp:Label ID="Label2" style="display:block; margin-bottom:10px; color:white;" runat="server" Text="Pret"></asp:Label>
               <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
               <asp:Label ID="Label3" style="display:block; margin-bottom:10px; color:white;" runat="server" Text="Transport"></asp:Label>
               <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
               <asp:Button ID="Button1" class="btn" runat="server" Text="Adauga excursie"  ToolTip="Adauga" OnClick="Button1_Click" />
               <asp:Label class="label" style="display:block; margin-bottom:10px; color: white;" ID="Label4" runat="server" Text=""></asp:Label>
           </div>
        </div>
    </form>
</body>
</html>
</asp:Content>
