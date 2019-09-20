<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CommuniCareProject.Pages.Login" %>

 <html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

     	<link rel="icon" href="~/Content/assets/images/brand/favicon.ico" type="image/x-icon">
		<link rel="shortcut icon" type="image/x-icon" href="~/Content/assets/images/brand/favicon.ico" />

 		<!-- Title -->
		<title>Boali | CommuniCare - Seu canal de comunicação.</title>

 		<!--Bootstrap.min css-->
		<link rel="stylesheet" href="../Content/assets/plugins/bootstrap/css/bootstrap.min.css" runat="server">

 		<!-- Dashboard css -->
		<link href="../Content/assets/css/style.css" rel="stylesheet" runat="server" />

 		<!-- Custom scroll bar css-->
		<link href="../Content/assets/plugins/scroll-bar/jquery.mCustomScrollbar.css" rel="stylesheet" runat="server"/>

 		<!-- Horizontal-menu css -->
		<link href="../Content/assets/plugins/horizontal-menu/horizontalmenu.css" rel="stylesheet" runat="server">
		<link href="../Content/assets/plugins/horizontal-menu/dropdown-effects/fade-down.css" rel="stylesheet" runat="server">

 		<!--Daterangepicker css-->
		<link href="../Content/assets/plugins/bootstrap-daterangepicker/daterangepicker.css" rel="stylesheet" runat="server"/>

 		<!-- Sidebar Accordions css -->
		<link href="../Content/assets/plugins/accordion1/css/easy-responsive-tabs.css" rel="stylesheet" runat="server">

 		<!-- Rightsidebar css -->
		<link href="../Content/assets/plugins/sidebar/sidebar.css" rel="stylesheet" runat="server">

 		<!---Font icons css-->
		<link href="../Content/assets/plugins/iconfonts/plugin.css" rel="stylesheet" runat="server"/>
		<link href="../Content/assets/plugins/iconfonts/icons.css" rel="stylesheet" runat="server"/>
		<link href="../Content/assets/fonts/fonts/font-awesome.min.css" rel="stylesheet" runat="server">
        <!-- Jquery js-->
		<script src="../Content/assets/js/vendors/jquery-3.2.1.min.js"></script>

 		<!--Bootstrap.min js-->
		<script src="../Content/assets/plugins/bootstrap/popper.min.js" ></script>
		<script src="../Content/assets/plugins/bootstrap/js/bootstrap.min.js"></script>

 		<!--Jquery Sparkline js-->
		<script src="../Content/assets/js/vendors/jquery.sparkline.min.js" ></script>

 		<!-- Chart Circle js-->
		<script src="../Content/assets/js/vendors/circle-progress.min.js" ></script>

 		<!-- Star Rating js-->
		<script src="../Content/assets/plugins/rating/jquery.rating-stars.js" ></script>

 		<!--Moment js-->
		<script src="../Content/assets/plugins/moment/moment.min.js" ></script>

 		<!-- Daterangepicker js-->
		<script src="../Content/assets/plugins/bootstrap-daterangepicker/daterangepicker.js" ></script>

 		<!-- Horizontal-menu js -->
		<script src="../Content/assets/plugins/horizontal-menu/horizontalmenu.js" ></script>

 		<!--Time Counter js-->
		<script src="../Content/assets/plugins/counters/jquery.missofis-countdown.js"></script>
		<script src="../Content/assets/plugins/counters/counter.js" ></script>

 		<!-- Sidebar Accordions js -->
		<script src="../Content/assets/plugins/accordion1/js/easyResponsiveTabs.js" %>" ></script>
 		<!-- Custom scroll bar js-->
		<script src="../Content/assets/plugins/scroll-bar/jquery.mCustomScrollbar.concat.min.js"></script>
 		<!-- Rightsidebar js -->
		<script src="../Content/assets/plugins/sidebar/sidebar.js"></script>
 		<!-- Custom js-->
		<script src="../Content/assets/js/custom.js" ></script>
        <style>
            .btn-primary
            {
                background-color: #edae1d;
                outline: none;
                border: none;
            }
             .btn-primary:hover 
            {
                color: white;
                background-color: #ffb200;
                font-weight: bold;
            }
             [type=reset], [type=submit], button, html [type=button]
            {
               background-color: #ffb200;
            }
             i {
                color:#edae1d;
            }
        </style>
        <script>
            function criarUsuario() {
                window.location = "LoginValida.aspx?user=" + $("#user").val() + "&senha=" + $("#senha").val();
            }
        </script>
</head>
<body>
    <div class="container body-Content" style="padding: 20px;">
    <div class="row">
		<div class="col-lg-4 d-block mx-auto">
			<div class="row">
				<div class="col-xl-12 col-md-12 col-md-12">
					<div class="card">
						<div class="card-body">
							<div class="text-center mb-6">
								<img src="../Content/assets/images/logo-boali.png" class="" alt="">
							</div>
							<h3>Seja bem-vindo!</h3>
							<p class="text-muted">Entre com seu usuário e senha.</p>
							<div class="input-group mb-3">
								<span class="input-group-addon bg-white"><i class="fa fa-user"></i></span>
								<input type="text" id="user" runat="server" class="form-control" placeholder="Usuário">
							</div>
							<div class="input-group mb-4">
								<span class="input-group-addon bg-white"><i class="fa fa-unlock-alt"></i></span>
								<input type="password" id="senha" runat="server" class="form-control" placeholder="Senha">
							</div>
							<div class="row">
								<div class="col-12">
									<button type="button" onclick="criarUsuario();" class="btn btn-primary btn-block" id="btnEnviar">Entrar</button>
								</div>
								<div class="col-12">
									<a href="forgot-password.html" class="btn btn-link box-shadow-0 px-0">Esqueceu a senha?</a>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
        </div>
</body>
</html>