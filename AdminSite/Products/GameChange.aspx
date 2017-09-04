<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GameChange.aspx.cs" Inherits="AdminSite.Products.GameChange" %>
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
            <a class="nav-link" href="Products.aspx">Game</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="Products.aspx#contact">Insert</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="Products.aspx#team">Products</a>
          </li>          
            <li class="nav-item">
            <a class="nav-link" runat="server"  onclick="logout"  href="../Default.aspx">Logout</a>
               
          </li>
        </ul>
      </div>
    </nav>

    <!-- Contact -->
    <section id="contact">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 text-center">
            <h2 class="section-heading">Changes</h2>
            <h3 class="section-subheading text-muted">Stock Update or Delete</h3>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-12">
            <div class="row">
                <div class="col-md-6">
                  <div class="form-group">
                    <asp:TextBox  CssClass="form-control" ID="tbNameProductU" runat="server" ToolTip="Name of Product" OnTextChanged="tbNameProductU_TextChanged"></asp:TextBox>
                    <p class="help-block text-danger"></p>
                  </div>
                  <div class="form-group">
                    <asp:DropDownList ID="typeListU" ToolTip="Type" runat="server" CssClass="form-control" >
                        <asp:ListItem Value="0">Select Type </asp:ListItem>
                        <asp:ListItem Value="1">Action</asp:ListItem>
                        <asp:ListItem Value="2">Fight</asp:ListItem>
                        <asp:ListItem Value="3">Kids</asp:ListItem>
                        <asp:ListItem Value="4">Puzzle</asp:ListItem>
                        <asp:ListItem Value="5">Race</asp:ListItem>
                        <asp:ListItem Value="6">Simulation</asp:ListItem>
                        <asp:ListItem Value="7">Sport</asp:ListItem>
                        <asp:ListItem Value="8">Strategy</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                  <div class="form-group">
                     <asp:DropDownList ID="consoleListU" ToolTip="Cosole" runat="server" CssClass="form-control" >
                         <asp:ListItem Value="0">Select Console</asp:ListItem>
                         <asp:ListItem Value="1">XBox 360</asp:ListItem>
                         <asp:ListItem Value="2">PS3</asp:ListItem>
                         <asp:ListItem Value="3">PS4</asp:ListItem>
                         <asp:ListItem Value="4">Nintendo Wi</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                    <div class="form-group">
                    <asp:TextBox  CssClass="form-control" ID="tbPriceU" TextMode="Number"  data-validation-required-message="Please enter a price." runat="server" ToolTip="Price of Product" OnTextChanged="tbPriceProductU_TextChanged"></asp:TextBox>
                    <p class="help-block text-danger"></p>
                  </div>
                </div>
                <div class="col-md-6">
                  
                    <div class="form-group">                      
                      <img src="../img/logos/control.png" alt="../img/logos/control.png" class="form-control"  />                    
                  </div>
                </div>

                <asp:Panel ID="frmConfirmation" Visible="False" runat="server">
                    <asp:Label ID="lblUploadResult" runat="server"></asp:Label>
                </asp:Panel>

                <div class="col-lg-12 text-center">
                    <div id="success"></div>
                    <asp:Button ID="ButtonU" CssClass="btn btn-xl" runat="server" Text="Update" OnClick="ButtonU_Click" ToolTip="Log- In" ></asp:Button>
                    &cute;
                    <asp:Button ID="ButtonD" CssClass="btn btn-xl" runat="server" Text="Delete" OnClick="ButtonD_Click" ToolTip="Log- In" ></asp:Button>
                
                </div>
              </div>            
          </div>
        </div>
      </div>
    </section>
</asp:Content>
