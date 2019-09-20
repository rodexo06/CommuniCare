<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="CriarUsuario.aspx.cs" Inherits="CommuniCareProject.Pages.CriarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function criarUsuario() {
            console.log($("#cpf").val());
            window.location = "CriarUser.aspx?cpf=" + $("#cpf").val() + "&nome=" + $("#nome").val() + "&cep=" + $("#cep").val() + "&logradouro= " + $("#logradouro").val() + "&bairro= " + $("#bairro").val() + "&cidade= " + $("#cidade").val() + "&complemento= " + $("#complemento").val() + "&uf= " + $("#uf").val() + "&num= " + $("#numero").val();
        }
    </script>
    <div class="card"> 
        <div class="card-header">
            <h3 class="mb-0 card-title">Criar Usuário</h3>
        </div>
        <div class="card-body">
                <div class="row"> 
                <div class="col-md-4"> 
                    <div class="form-group"> 
                        <label class="form-label">CPF/CNPJ</label> 
                        <input type="text" class="form-control" id="cpf" name="cpf" placeholder="Digite o CPF ou CNPJ..." > 
                    </div> 
                </div>
                <div class="col-md-4"> 
                    <div class="form-group"> 
                        <label class="form-label">Razão Social/Nome</label> 
                        <input type="text" class="form-control" id="nome" name="nome" placeholder="Digite o Nome ou Razão Social..."  > 
                    </div> 
                </div>
                <div class="col-md-4"> 
                    <div class="form-group"> 
                        <label class="form-label">Área</label> 
                        <div id="opcoes" runat="server" ></div>
                    </div>
                </div>
                <div class="col-md-4"> 
                    <div class="form-group "> 
                        <label class="form-label">CEP</label> 
                        <input type="text" class="form-control" id="cep" name="cep" placeholder="Digite o CEP..." >
                    </div>
                </div>
                <div class="col-md-4"> 
                    <div class="form-group "> 
                        <label class="form-label">Endereço</label> 
                        <input type="text" class="form-control" id="logradouro" name="logradouro" placeholder="Digite o Endereço..." >
                    </div>
                </div>
                <div class="col-md-2"> 
                    <div class="form-group "> 
                        <label class="form-label">Número</label> 
                        <input type="text" class="form-control" id="numero" name="numero" placeholder="Digite o Número..." >
                    </div>
                </div>
                <div class="col-md-3"> 
                    <div class="form-group "> 
                        <label class="form-label">Complemento</label> 
                        <input type="text" class="form-control" id="complemento" name="complemento" placeholder="Digite o Complemento..." >
                    </div>
                </div>
                <div class="col-md-3"> 
                    <div class="form-group "> 
                        <label class="form-label">Bairro</label> 
                        <input type="text" class="form-control" id="bairro" name="bairro" placeholder="Digite o Bairro..." >
                    </div>
                </div>
                <div class="col-md-3"> 
                    <div class="form-group "> 
                        <label class="form-label">Municipio</label> 
                        <input type="text" class="form-control" id="cidade" name="cidade" placeholder="Digite o Municipio..." >
                    </div>
                </div> 
                <div class="col-md-3"> 
                    <div class="form-group "> 
                        <label class="form-label">UF</label> 
                        <input type="text" class="form-control" id="uf" name="uf" placeholder="Digite o UF..." >
                    </div>
                </div> 
                <div class="col-md-12"> 
                    <div style="float: right; padding-top: 5px;"> 
                        <a class="btn btn-default" id="criaUsuario" onclick="criarUsuario();" runat="server">Criar</a>
                    </div> 
                </div> 
            </div>
        </div>
    </div>
<%--    <script>--%>


<%--          function limpa_formulário_cep() {
              // Limpa valores do formulário de cep.
              $("#logradouro").val("");
              $("#bairro").val("");
              $("#cidade").val("");
              $("#numero").val("");
              $("#complemento").val("");
              $("#uf").val("");

          }


          $('#cep').keyup(function () {
              var cep = $("#cep").val();
              console.log(cep);
              if (cep.length == 8) {
                  //Nova variável "cep" somente com dígitos.
                  var cep = $(this).val().replace(/\D/g, '');
                  console.log(cep);
                  //Verifica se campo cep possui valor informado.
                  if (cep != "") {

                      //Expressão regular para validar o CEP.
                      var validacep = /^[0-9]{8}$/;

                      //Valida o formato do CEP.
                      if (validacep.test(cep)) {

                          //Preenche os campos com "..." enquanto consulta webservice.
                          $("#logradouro").val("...");
                          $("#bairro").val("...");
                          $("#cidade").val("...");
                          $("#uf").val("...");

                          //Consulta o webservice viacep.com.br/
                          $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                              if (!("erro" in dados))
                              {
                                  //Atualiza os campos com os valores da consulta.
                                  $("#logradouro").val(dados.logradouro);
                                  $("#bairro").val(dados.bairro);
                                  $("#cidade").val(dados.localidade);
                                  $("#uf").val(dados.uf);
                              } //end if.
                              else
                              {
                                  //CEP pesquisado não foi encontrado.
                                  limpa_formulário_cep();
                                  alert("CEP não encontrado.");
                              }
                          });
                      } //end if.
                      else
                      {
                          //cep é inválido.
                          limpa_formulário_cep();
                          alert("Formato de CEP inválido.");
                      }
                  } //end if.
                  else
                  {
                      //cep sem valor, limpa formulário.
                      limpa_formulário_cep();
                  }
              };
            </script>--%>

</asp:Content>
