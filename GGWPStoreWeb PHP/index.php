<?php
  session_start();
  setcookie('meu_cookie', 'valor do cookie');
  include "cabecalho.php";
  include "conexao.php";
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

<?php echo $cabeca; ?>
      <!-- Conteudo Principal-->

      <!--INICIO CARROUSEL-->
      <div id="carouselExampleIndicators" class="carousel slide mt-3" data-bs-ride="carousel">
        <div class="carousel-indicators">
          <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
          <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
          <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
        </div>
        <div class="carousel-inner">
          <div class="carousel-item active">
            <img src="imagens/foto_carrousel2.png" class="d-block w-100" alt="...">
          </div>
          <div class="carousel-item">
            <img src="imagens/foto_carrousel.png" class="d-block w-100" alt="...">
          </div>
          <div class="carousel-item">
            <img src="imagens/foto_carrousel2.png" class="d-block w-100" alt="...">
          </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Next</span>
        </button>
      </div>
      <!--FIM CARROUSEL-->

      <div class="margem"><p id="linkProduto" class="fs-1 text-center corLetra mt-2" style="font-family: Fantasy;">Categorias</p></div>
      
      <div class="mt-2 produto">


        <div class="container-fluid">
            <div class="row">
                
                <div class="col-lg-1">
                </div>

              <div class="col-lg-2 col-6 col-md-4">
                <a class="categorias" href="lista_itens.php?id=1">
                <div class="prod">
                    <img class="tamanho img-fluid borda" src="imagens/foto_colecionaveis.png"></a>
                    <p id="linkProduto" class="mt-3 text-center lead">Colecionáveis</p>
                </div>
              </div>

              <div class="col-lg-2 col-6 col-md-4">
                <a class="categorias" href="lista_itens.php?id=2">
                <div class="prod">
                    <img class="tamanho img-fluid borda" src="imagens/foto_games.png"></a>
                    <p id="linkProduto" class="mt-3 text-center lead">Games</p>
                </div>
            </div>

              <div class="col-lg-2 col-6 col-md-4">
                <a class="categorias" href="lista_itens.php?id=3">
                <div class="prod">
                    <img class="tamanho img-fluid borda" src="imagens/foto_computadores.png"></a>
                    <p id="linkProduto" class="mt-3 text-center lead">Computadores</p>
                    </div>
              </div>

              <div class="col-lg-2 col-6 col-md-4">
                <a class="categorias" href="lista_itens.php?id=4">
                <div class="prod">
                    <img class="tamanho img-fluid borda" src="imagens/foto_perifericos.png"></a>
                    <p id="linkProduto" class="mt-3 text-center lead">Periféricos</p>
                    </div>
              </div>

              <div class="col-lg-2 col-6 col-md-4">
                <a class="categorias" href="lista_itens.php?id=5">
                <div class="prod">
                    <img class="tamanho img-fluid borda" src="imagens/foto_hqs.png"></a>
                    <p id="linkProduto" class="mt-3 text-center lead">HQ's</p>
                </div>
              </div>

                <div class="col-lg-1">
                </div>

            </div>
          </div>
      </div>

      <!-- Fim conteudo Principal-->

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