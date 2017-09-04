<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AdminSite.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
        <a class="navbar-brand" href="#page-top">Bear Gamer</a>
        <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">


            <i class="fa fa-bars"></i>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item">
                    <a class="nav-link" href="#services">Services</a>
                </li>                
                <li class="nav-item">
                    <a class="nav-link" href="#team">Developers</a>
                </li>                
                <li class="nav-item">
                    <a class="nav-link" runat="server" onclick="logout" href="~/Default.aspx">Logout</a>

                </li>
            </ul>
        </div>
    </nav>


    <!-- Header -->
    <header class="masthead">
      <div class="container">
        <div class="intro-text">
          <div class="intro-lead-in">Welcome to paradise for players</div>
          <div class="intro-heading">It's a admin site</div>
          <a href="#services" class="btn btn-xl">More</a>
        </div>
      </div>
    </header>
    

    <!-- Services -->
    <section id="services">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading">Manager Services</h2>
                    <h3 class="section-subheading text-muted">Subjects</h3>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-md-4">
                    <span class="fa-stack fa-4x">
                        <a href="Products/Products.aspx" class="btn btn-xl">
                            <img class="mx-auto rounded-circle" src="img/icons/Game Boy-64.png" alt="Products" />
                        </a>
                    </span>
                    <h4 class="service-heading">Products</h4>
                    <p class="text-muted">Insert, update, delete, view games</p>
                </div>                
                <div class="col-md-4">
                    <span class="fa-stack fa-4x">
                        <a href="Clients/InsertClient.aspx" class="btn btn-xl">
                            <img class="mx-auto rounded-circle" src="img/icons/People.png" alt="Clients" />
                        </a>
                    </span>
                    <h4 class="service-heading">Clients</h4>
                    <p class="text-muted">Insert, delete, all of clients</p>
                </div>
            </div>
        </div>
    </section>
      

    
    <!-- Team -->
    <section class="bg-light" id="team">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading">Developers</h2>
                    <h3 class="section-subheading text-muted">Students to Project Developers</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="https://scontent.fsyq1-1.fna.fbcdn.net/v/t1.0-1/p160x160/17523236_1430459773692152_2887136866121978801_n.jpg?oh=0e609799eff4af9adbe6666a192f9b3c&oe=5A3774A4" alt="" />
                        <h4>Alfonso Brenes Villalobos</h4>
                        <p class="text-muted">Designer</p>
                        <ul class="list-inline social-buttons">
                            <li class="list-inline-item">
                                <a href="https://www.facebook.com/profile.php?id=100001844305163">
                                    <i class="fa fa-facebook"></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="https://scontent.fsyq1-1.fna.fbcdn.net/v/t1.0-1/c0.6.160.160/p160x160/19601203_1399524283465394_2289078277886838240_n.jpg?oh=434961178bd256d0715d956bf582b09e&oe=5A337374" alt="" />
                        <h4>Albert Calderon Alvarado</h4>
                        <p class="text-muted">Developer </p>
                        <ul class="list-inline social-buttons">
                            <li class="list-inline-item">
                                <a href="https://www.facebook.com/alberthgabriel5">
                                    <i class="fa fa-facebook"></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="https://scontent.fsyq1-1.fna.fbcdn.net/v/t1.0-9/12592369_1152148291474597_1494899074289937942_n.jpg?oh=c89d2ba34329d57ad41b2725f662d5e4&oe=5A292E21" alt="" />
                        <h4>Bryan Machado</h4>
                        <p class="text-muted">Developer</p>
                        <ul class="list-inline social-buttons">

                            <li class="list-inline-item">
                                <a href="https://www.facebook.com/bryan.machado.37">
                                    <i class="fa fa-facebook"></i>
                                </a>
                            </li>

                        </ul>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="https://scontent.fsyq1-1.fna.fbcdn.net/v/t1.0-9/16729496_1248709205198982_3939388194339812298_n.jpg?oh=a717fedd0de03a7b1728140ed420665a&oe=5A271E34" alt="" />
                        <h4>Oscar Sanchez Hernández</h4>
                        <p class="text-muted">Developer</p>
                        <ul class="list-inline social-buttons">
                            <li class="list-inline-item">
                                <a href="#">
                                    <i class="fa fa-facebook"></i>
                                </a>
                            </li>

                        </ul>
                    </div>
                </div>

            </div>
            <div class="row">
                <div class="col-lg-8 mx-auto text-center">
                    <p class="large text-muted">Students from Universidad de Costa Rica</p>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
