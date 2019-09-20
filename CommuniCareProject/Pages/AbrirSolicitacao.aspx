<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbrirSolicitacao.aspx.cs" Inherits="CommuniCareProject.Paginas.AbrirSolicitacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function SalvaForm()
        {
            console.log("here :(");
            window.location = "EnviaSolicitacao.aspx?nomeArea=" + $("#nomeArea").val() + "&tipoSolicitacao=" + $("#tipoSolicitacao").val() + "&mensagem=" + $("#mensagem").val();
        }
    </script>
    <div id="abrirSolicitacao" runat="server"></div>
</asp:Content>
