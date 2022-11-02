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

    <title>GGWP Store</title>
</head>
<body> 
    <?php echo $cabeca;?>

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
            <input type="text" class="form-control" name="cep" placeholder="Insira o CEP">
            </div>
            <div class="col-md-4 col-4 text-center d-grid gap-2">
              <button class="btn btn-outline-success">Enviar</button>
            </div>
      </div>
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
              <p class="lead corLetra mt-3">R$ 399,95</p>
            </div><hr class="mt-2">
          </div>
          <div class="row">
            <div class="col-8">
              <p class="lead corLetra mt-1">Frete</p>
            </div>
            <div class="col-4">
              <p class="lead corLetra mt-1">R$ 0,00</p>
            </div>
          </div>
          <div class="row">
            <div class="col-8">
              <p class="lead corLetra mt-1">Valor Total</p>
            </div>
            <div class="col-4">
              <p class="lead corLetra mt-1">R$ 399,95</p>
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


<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

</body>
</html>