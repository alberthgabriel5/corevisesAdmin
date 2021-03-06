﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InsertClient.aspx.cs" Inherits="AdminSite.Products.Client" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
      <a class="navbar-brand" href="../index.aspx">Bear Gamer</a>
      <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        
          
        <i class="fa fa-bars"></i>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav ml-auto">
          
          <li class="nav-item">
            <a class="nav-link" href="InsertClient.aspx">Insert</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="ViewClient.aspx">Clients</a>
          </li>          
            <li class="nav-item">
            <a class="nav-link" runat="server"  onclick="logout"  href="../Default.aspx">Logout</a>
               
          </li>
        </ul>
      </div>
    </nav>


    <!-- Services -->
    <section id="contact">
        <div class="container">
            <div class="row" >
<h2 class="intro-lead-in">Insert Client</h2>

                <div class="col-lg-12 text-center">
                    
                    <br />
                    <br />
                    <asp:TextBox ID="tbNameClient" AutoCompleteType="None"  runat="server" ToolTip="Name of Client" CssClass="form-control"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="tbUserClient" AutoCompleteType="None"  runat="server" TextMode="Email" ToolTip="User" CssClass="form-control"></asp:TextBox>
                    <br />


                    <br />
                    <asp:TextBox ID="tbPassClient" AutoCompleteType="None"  runat="server" TextMode="Password" ToolTip="Name of Product" CssClass="form-control"></asp:TextBox>
                    <br />

                    <asp:TextBox ID="tbBorn" TextMode="Date" runat="server" Height="29px" Width="455px" CssClass="form-control" ></asp:TextBox>
                        <br />
                    <br />
                    

                    <br />

                    <br />

                    <br />
                    <asp:Button ID="Button1" CssClass="btn btn-xl" runat="server" Text="Insert" OnClick="Button1_Click" ToolTip="Log- In" />
                    <br />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
