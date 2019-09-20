<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbrirSolicitacao.aspx.cs" Inherits="CommuniCareProject.Paginas.AbrirSolicitacao" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    	<link rel="icon" href="~/Content/assets/images/brand/favicon.ico" type="image/x-icon">
		<link rel="shortcut icon" type="image/x-icon" href="~/Content/assets/images/brand/favicon.ico" />

		<!--Bootstrap.min css-->
		<link rel="stylesheet" href="~/Content/assets/plugins/bootstrap/css/bootstrap.min.css">
            
		<!-- Dashboard css -->
		<link href="~/Content/assets/css/style.css" rel="stylesheet" />

		<!-- Custom scroll bar css-->
		<link href="~/Content/assets/plugins/scroll-bar/jquery.mCustomScrollbar.css" rel="stylesheet" />

		<!-- Horizontal-menu css -->
		<link href="~/Content/assets/plugins/horizontal-menu/horizontalmenu.css" rel="stylesheet">
		<link href="~/Content/assets/plugins/horizontal-menu/dropdown-effects/fade-down.css" rel="stylesheet">

		<!--Daterangeicker css-->
		<link href="~/Content/assets/plugins/bootstrap-daterangepicker/daterangepicker.css" rel="stylesheet" />

		<!-- Sidebar Accordions css -->
		<link href="~/Content/assets/plugins/accordion1/css/easy-responsive-tabs.css" rel="stylesheet">

		<!-- Rightsidebar css -->
		<link href="~/Content/assets/plugins/sidebar/sidebar.css" rel="stylesheet">

		<!---Font icons css-->
		<link href="~/Content/assets/plugins/iconfonts/plugin.css" rel="stylesheet" />
		<link href="~/Content/assets/plugins/iconfonts/icons.css" rel="stylesheet" />
		<link href="~/Content/assets/fonts/fonts/font-awesome.min.css" rel="stylesheet">

</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card">
									<div class="card-header">
										<h3 class="mb-0 card-title">Default Form Input Fields with labels</h3>
									</div>
									<div class="card-body">
										<div class="row">
											<div class="col-md-6">
												<div class="form-group">
													<label class="form-label">Enter Name</label>
													<input type="text" class="form-control" name="example-text-input" placeholder="Name">
												</div>
												<div class="form-group">
													<label class="form-label">Disabled</label>
													<input type="text" class="form-control" name="example-disabled-input" placeholder="Disabled text area.." value="" disabled="">
												</div>
												<div class="form-group">
													<label class="form-label">Readonly</label>
													<input type="text" class="form-control" name="example-disabled-input" placeholder="Read Only Text area." value="Read Only Text area. " readonly="">
												</div>
											</div>
											<div class="col-md-6">
												<div class="form-group">
													<label class="form-label">Valid Email</label>
													<input type="text" class="form-control is-valid state-valid" name="example-text-input-valid" placeholder="Valid Email..">
												</div>
												<div class="form-group m-0">
													<label class="form-label">Invalid Number</label>
													<input type="text" class="form-control is-invalid state-invalid" name="example-text-input-invalid" placeholder="Invalid Number..">
													<div class="invalid-feedback">Invalid feedback</div>
												</div>
												<div class="form-group">
													<label class="form-label">Password</label>
													<input type="password" class="form-control" name="example-password-input" placeholder="Password..">
												</div>
											</div>
											<div class="col-md-12 ">
												<div class="form-group mb-0">
													<label class="form-label">Message</label>
													<textarea class="form-control" name="example-textarea-input" rows="4" placeholder="text here.."></textarea>
												</div>
											</div>
										</div>
									</div>
								</div>
</asp:Content>
