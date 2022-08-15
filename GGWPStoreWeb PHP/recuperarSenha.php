<?php
include "cabecalho.php";
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="css/login.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/6b517c0011.js" crossorigin="anonymous"></script>
    <link rel="icon" type="image/x-icon" href="imagens/favicon-32x32.ico">
    <script src="javaScript/java.js"></script>

    <style>
      body{
        background-image: url(imagens/fundo.jpg);
      }
    </style>

    <title>login</title>
</head>
<body>

  <div class="principal">
    

  <?php echo $cabeca;?>

  <div class="centro-tela conteudoPagina">
    <div class="container-fluid">
        <div class="row justify-content-center mt-5">
            <section class="col-12 col-sm-6 col-md-4"> 
                <form class="form-container login">
                    <h1 class="text-center corLetra">Recuperar senha</h1>
                    <div class="form-group">
                        <p class="lead corLetra mt-4">Insira seu e-mail</p>
                        <input type="text" class="form-control" name="email" placeholder="email">
                    </div>
                    <div>
                        <p class="lead corLetra mt-3">Confirmar e-mail</p>
                        <input type="text" class="form-control" name="email" placeholder="confirmar">
                    </div>

                    <div class="row">
                        <div class="d-grid gap-2 mt-5">
                            <button class="btn btn-outline-light">Enviar</button>
                        </div>
                    </div>
                    
                </form>
            </section>
        </div>
    </div>
</div>


<!--INICIO FOOTER-->
<footer id="sticky-footer" class="navbar-fixed-bottom flex-shrink-0 py-2 bg-dark text-white-50">
    <div class="container text-center">
      <small>Copyright &copy; GGWP Store</small>
    </div>
  </footer>
<!--FIM FOOTER-->
</div><!--Div para corrigir o rodapé-->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>