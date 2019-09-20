<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaUsuario.aspx.cs" Inherits="CommuniCareProject.Pages.ListaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        th {
            text-transform: capitalize !important;
        }
    </style>
    <div class="row">
		<div class="col-lg-12">
			<div class="e-panel card">
				<div class="card-header">
					<h4>Usuários</h4>
				</div>
				<div class="card-body">
					<div class="e-table">
						<div class="table-responsive table-lg">
							<table class="table table-bordered">
								<thead>
									<tr>
										<th>CNPJ</th>
										<th>Razão Social</th>
										<th>Endereço</th>
										<th class="text-center">Ações</th>
									</tr>
								</thead>
								<tbody id="table" runat="server"></tbody>
							</table>
						</div>
						<div class="d-flex justify-content-center">
							<ul class="pagination mt-3 mb-0">
								<li class="disabled page-item">
									<a class="page-link" href="#">‹</a>
								</li>
								<li class="active page-item">
									<a class="page-link" href="#">1</a>
								</li>
								<li class="page-item">
									<a class="page-link" href="#">2</a>
								</li>
								<li class="page-item">
									<a class="page-link" href="#">3</a>
								</li>
								<li class="page-item">
									<a class="page-link" href="#">4</a>
								</li>
								<li class="page-item">
									<a class="page-link" href="#">5</a>
								</li>
								<li class="page-item">
									<a class="page-link" href="#">›</a>
								</li>
								<li class="page-item">
									<a class="page-link" href="#">»</a>
								</li>
							</ul>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
