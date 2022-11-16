<?php
include_once "session.php"; 
include "cabecalho.php";
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="css/style.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/6b517c0011.js" crossorigin="anonymous"></script>
    <link rel="icon" type="image/x-icon" href="imagens/favicon-32x32.ico">
    <script src="javaScript/java.js"></script>
    <script src="jquery/jquery-3.6.1.min.js"></script>

    <script>

      function cep(){
        var prod = document.getElementById("valor_prod").innerHTML;
        console.log(prod);
        var cep = document.getElementById("cep").value;
        console.log(cep);
        $.post( 
          "ajax/calcula_cep.php", { 
          cep: cep,
          preco : prod
        },
        function( data ) {
          var valor = data.valor['0'];
          var prazo = data.prazo['0'];
          document.getElementById("valor_frete").innerHTML = valor;
          document.getElementById("valor_tot").innerHTML = data.total;
          if(prazo != '1')
          document.getElementById("comment_frete").innerHTML = "<br> Valor Sedex: R$ "+valor+" <br> Prazo: "+prazo+" dias";
          else
          document.getElementById("comment_frete").innerHTML = "<br> Valor Sedex: R$ "+valor+" <br> Prazo: "+prazo+" dia";
        }, "json");
        endereco(cep);
      }

      function endereco(cep){
        $.post( 
          "ajax/endereco.php", { 
          cep: cep
        },
        function( data ) {
          document.getElementById("rua").value = data.rua['0'];
          document.getElementById("bairro").value = data.bairro['0'];
          document.getElementById("estado").value = data.uf['0'];
        }, "json");
      }
      
    </script>

    <title>GGWP Store</title>
</head>
<body> 
  
    <?php
    function get_endereco($cep){
      $cep = preg_replace("/[^0-9]/", "", $cep);
      $url = "http://viacep.com.br/ws/$cep/xml/";
    
      $xml = simplexml_load_file($url);
      return $xml;
    }
    
    echo $cabeca;
    ?>

      <div class="container bordaItens mt-5 p-3">
        <div class="row">
          <div class="col-12">
            <h1 class="corLetra display-5 text-center">Carrinho</h1>
            </div>
        </div>
        </div>
      
        <div class="container bordaItens mt-5 p-3">

          
          <div class="container-fluid">
            <div class="row">
                
                <!--<div class="col-lg-1">
                </div>-->

              <?php include "id_carrinho.php"?>

                <!--<div class="col-lg-1">
                </div>-->
                
              </div>
            </div>
          </div>

          
        <div class="container bordaItens corLetra mt-5 p-4">
          <h1 class="display-5">Frete</h1>
          <div class="row form-group">
            <div class="col-md-8 col-8">
            <input type="text" class="form-control" name="cep" id="cep" placeholder="Insira o CEP">
            </div>
            <div class="col-md-4 col-4 text-center d-grid gap-2">
              <button class="btn btn-outline-success" onclick="cep()">Enviar</button>
            </div>
          </div>
          <div class="row mt-4">
            <div class="col-4">
              <label for="rua" class="lead">Rua</label><br>
              <input type="text" class="form-control" name="rua" id="rua" placeholder="">
            </div>
            <div class="col-4">
              <label for="bairro" class="lead">Bairro</label><br>
              <input type="text" class="form-control" name="bairro" id="bairro" placeholder="">
            </div>
          </div>
          <div class="row mr-4">
            <div class="col-4 mt-4">
              <label for="logradouro" class="lead">Logradouro</label><br>
              <input type="text" class="form-control" name="logradouro" id="logradouro" placeholder="">
            </div>
            <div class="col-4 mt-4">
              <label for="estado" class="lead">Estado</label><br>
              <input type="text" class="form-control" name="estado" id="estado" placeholder="">
            </div>
            <div class="col-2 mt-4">
              <label for="numero" class="lead">Numero</label><br>
              <input type="text" class="form-control" name="numero" id="numero" placeholder="">
            </div>
          </div>
          <Span class="center lead mt-4" id="comment_frete"></Span>

        </div>
      <div class="container carrinho bordaItens mt-5 p-3">
        <div class="container">
          <div class="row">
            <h1 class="display-5 corLetra mt-2">Resumo</h1>
          </div>
        </div>
        
        <div class="container">
          <div class="row">
            <div class="col-8">
              <p class="lead corLetra mt-3">Valor dos Produtos</p>
            </div>
            <div class="col-4">
              <p class="lead corLetra mt-3">R$ <span id="valor_prod">0,00</span> </p>
            </div><hr class="mt-2">
          </div>
          <div class="row">
            <div class="col-8">
              <p class="lead corLetra mt-1">Frete</p>
            </div>
            <div class="col-4">
              <p class="lead corLetra mt-1">R$ <span id="valor_frete">0,00</span></p>
            </div>
          </div>
          <div class="row">
            <div class="col-8">
              <p class="lead corLetra mt-1">Valor Total</p>
            </div>
            <div class="col-4">
              <p class="lead corLetra mt-1">R$ <span id="valor_tot">0,00</span></p>
            </div>
          </div>
          <div class="row mt-4"> 
            <div class="col-6 d-grid gap-2">
              <button class="btn btn-outline-success">Continuar comprando</button>
            </div>
            <div class="col-6 d-grid gap-2">
              <button  class="btn btn-outline-success">Finalizar compra</button>
            </div>
        </div>  
        </div>
      </div>
      
<!--INICIO FOOTER-->
<footer id="sticky-footer" class="flex-shrink-0 py-2 bg-dark text-white-50 mt-5">
  <div class="container text-center">
    <small>Copyright &copy; GGWP Store</small>
  </div>
</footer>
<!--FIM FOOTER-->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></scrip>

</body>
</html>