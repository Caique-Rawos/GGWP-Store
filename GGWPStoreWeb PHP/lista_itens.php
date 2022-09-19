<?php
include_once "session.php";
include "cabecalho.php";
include "id_listaProd.php";
$qntd = 0;

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

      <section>
      <aside class="bordaItens mt-4">
          <h1 class="corLetra text-center mt-3">Filtrar por:</h1>
        <p class="lead corLetra mt-4">Valor</p>
        <div class="input-group mb-3" >
            <input type="text" class="form-control"  placeholder="De: R$" aria-label="Username">
            <input type="text" class="form-control" placeholder="Até: R$" aria-label="Server">
          </div>
        <hr class="mt-2">

        <p class="lead corLetra mt-2">Condição</p>
              <input type="checkbox" id="valor" name="valor">
              <label for="cond" class="corLetra mt-1">Itens Novos</label><br>
              <input type="checkbox" id="valor" name="valor">
              <label for="cond" class="corLetra mt-1">Itens Semi-Novos</label>

              <hr class="mt-2"> 


          <div mt-2></div>
      </aside>

      <main>
        <div class="container-fluid">
            <div class="row">
               <?php
               while($qntd < 18){
                 echo $card;
                 $qntd++;
               }
               ?>

              </div>
            </div>
          </div>

      </main>



    </section>

      <!-- Fim conteudo Principal-->

      <!--INICIO FOOTER-->
    <footer id="sticky-footer" class="flex-shrink-0 py-2 bg-dark text-white-50">
        <div class="container text-center">
          <small>Copyright &copy; GGWP Store</small>
        </div>
      </footer>
    <!--FIM FOOTER-->

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    
</body>
</html>