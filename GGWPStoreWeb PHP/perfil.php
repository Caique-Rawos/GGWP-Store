<?php
include_once "session.php";
include_once "conexao.php";
include "cabecalho.php";
$count = 0;

if($_SESSION['login'] == ""){
  echo ("
        <script>
        window.location.href = \"login.php\";
        </script>
        ");
}

$sql = "SELECT usuario_ggwp.*, count(id_produto) as total_itens FROM usuario_ggwp left join produto_ggwp on usuario = email WHERE email = '{$_SESSION['login']}'";
try{
  foreach ($conn->query($sql) as $row) {
    $username = $row['username'];
    $data = $row['data'];
    if($row['foto'] == null){
      $foto = "imagens/foto.png";
    }else{
      $foto = "data:image;base64," . base64_encode($row["foto"]);
    }
    $total_itens = $row['total_itens'];
    $count++;
}
    $data = str_replace("-", "/", $data);
    $data = date('d/m/Y', strtotime($data));
//die($row['email']);

if($count != 1){
  die("Erro ao encontrar perfil");
  $_SESSION['login'] = "";

}

}catch(exception $e){
  die("Erro ao executar sql");
  $_SESSION['login'] = "";
}

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
      <div class="container">
        <div class="row">
          <div class="col-xxl-1 col-lg-2 col-md-2 col-sm-3">
            <img src="<?=$foto?>" class="rounded-circle border mt-4 image-perfil" alt="">
          </div>
          <div class="col-lg-3 col-md-8 col-sm-3 marginPerfil">
            <h1 class="corLetra lead mt-4">@<?=$username?></h1>
          <!--STAR INICIO-->
          <img src="imagens/star1.png" width="20px" onclick="avaliar(1, 2)" id="s1">
              
              <img src="imagens/star1.png" width="20px" onclick="avaliar(2, 2)" id="s2">
              
              <img src="imagens/star1.png" width="20px" onclick="avaliar(3, 2)" id="s3">
              
              <img src="imagens/star1.png" width="20px" onclick="avaliar(4, 2)" id="s4">
              
              <img src="imagens/star1.png" width="20px" onclick="avaliar(5, 2)" id="s5">

              <img src="imagens/star1.png" width="20px" onclick="avaliar(6, 2)" id="s6">
      <!--STAR FIM-->
          </div>
          
          <div class="col-lg-3 col-md-6 col-sm-6">
             <h1 class="lead corLetra mt-4"><i class="fa-solid fa-shop corLetra"></i> &nbsp; Produtos: <?=$total_itens?></h1>
             <h1 class="lead corLetra mt-4"><i class="fa-solid fa-user-plus corLetra"></i> &nbsp; Seguindo: 0</h1>
          </div>
          <div class="col-lg-3 col-md-6 col-sm-6">
            <h1 class="lead corLetra mt-4"><i class="fa-solid fa-people-group corLetra"></i> &nbsp; Seguidores: 0</h1>
            <h1 class="lead corLetra mt-4"><i class="fa-solid fa-stopwatch corLetra"></i> &nbsp; Vendendo Desde: <?=$data?></h1>
         </div>
        </div>
        <div class="row">
          <div class="col-lg-4 col-sm-12">
            <button class="btn btn-outline-secondary rounded mt-5"><i class="fa-solid fa-plus fa-xs"></i> Seguir</button>
            <button class="btn btn-outline-secondary rounded mt-5 marginPerfil"><i class="fa-regular fa-comment-dots"></i>&nbsp;Chat</button>
          </div><hr class="mt-4">
        </div>
      </div>

      <div class="container">
        <div class="row">
          <div class="col-6 col-lg-2 col-md-3">
            <a class="categorias" href="#principal"><h1 class="corLetra lead text-center">Pagina Principal</h1></a>
          </div>
          <div class="col-6 col-lg-1 col-md-3">
            <a class="categorias" href="cadastro_prod.php"><h1 class="corLetra lead text-center">Produtos</h1></a>
          </div><div class="col-6 col-lg-1 col-md-3">
            <a class="categorias" href="listVendas.php"><h1 class="corLetra lead text-center">Vendas</h1></a>
          </div><hr class="mt-2">
        </div>
      </div>

      <div class="container mt-2">
          <div class="conteudoPerfil corLetra">
             <p> Boas-Vindas à Família Gamer! 🎮 </p>
             <p> Somos uma revenda de games e acessórios especializada, que está sempre pronta pra te atender com toda atenção e disposição possíveis.</p>
             <p> Aqui também somos gamers de verdade e ficamos extremamente felizes em poder fazer parte da sua gameplay. Então, conte com a gente sempre que precisar :)</p>
             Uma vez gamer, sempre gamer!
          </div>
      </div>

      <div class="container mt-4"> <a id="produtos"></a>
        <h1 class="display-6 corLetra text-center">Produtos</h1>

        <div class="container-fluid">
          <div class="row">
              
              <div class="col-lg-1">
              </div>

              <?php
              $count = 0;
              $sql = "select * from produto_ggwp where usuario = '{$_SESSION['login']}';";
              foreach ($conn->query($sql) as $row) {
                if($count % 5 == 0 && $count != 0){
                  echo "<div class='col-lg-1'>
                  </div>
                  
                  <div class='col-lg-1'>
                  </div>";
                }

                echo '<div class="col-6 col-lg-2 col-md-4 mt-2">
                <div class="prod altura100"><a class="decoracao" href="produto.php?id_prod='.$row['id_produto'].'">
                    <img class="tamanho img-fluid" src="data:image;base64,'.base64_encode($row["foto"]).'"></a>
                    <p class="corLetra lead">'.$row['nome'].'</p>
                      <p class="corLetra lead mt-2">R$ '.number_format($row['preco'],2,",",".").'</p>
                </div>
              </div>';
              $count++;
            }
              ?>

          </div>
        </div>

      </div>

      <!-- Fim conteudo Principal-->

      <!--INICIO FOOTER-->
    <footer id="sticky-footer" class="navbar-fixed-bottom flex-shrink-0 py-2 bg-dark text-white-50 mt-5">
        <div class="container text-center">
          <small>Copyright &copy; GGWP Store</small>
        </div>
      </footer>
    <!--FIM FOOTER-->

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    
</body>
</html>