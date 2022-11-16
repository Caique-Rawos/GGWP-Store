<?php 
include "conexao.php";

if($_SESSION['login'] != ""){
$valor_total = 0;
$sql = "SELECT count(id_item) AS total, id_item, c.usuario, p.nome, p.preco, p.foto
        FROM carrinho_ggwp c
        LEFT JOIN produto_ggwp p ON p.id_produto = c.id_item
        WHERE c.usuario = '{$_SESSION['login']}'
        GROUP BY id_item, c.usuario ";
               $stmt = $conn->prepare($sql);
               $stmt->execute();
    while ($row = $stmt->fetch()) {
        $valor_total += $row['preco'] * $row['total'];
        echo '
        <div class="col-lg-2 col-6 col-md-4 mt-3">
            <a class="categorias" href="produto.php?id_prod='.$row['id_item'].'">
            <div class="bordaItens">
                <div class="">
                    <img src="data:image;base64,'.base64_encode($row["foto"]).'" class="card-img-top imagem_carrinho" style alt="HQ Batman"></a>
                    <div class="card-body">
                        <p id="texto" class=" lead"></p>
                        <p id="texto" class=" lead">'.$row['nome'].'</p>
                        <p id="texto" class=" lead mt-2">R$ '.number_format($row['preco'],2,",",".").'</p>
                        <p id="texto" class=" lead mt-2">Quant: &nbsp;<i id="i" class="fa-solid fa-angle-left fa-xs"></i> '.$row['total'].' <i id="i" class="fa-solid fa-angle-right fa-xs"></i></p>
                    </div>
                </div>
            </div>
        </div>';
    }
    echo'<script>
    window.onload = function(){
    document.getElementById("valor_prod").innerHTML = "'.number_format($valor_total,2,",",".").'";
    document.getElementById("valor_tot").innerHTML = "'.number_format($valor_total,2,",",".").'";
    }
    </script>';
}else{
  echo "
        <script>
        window.location.href = \"login.php\";
        </script>
        ";
}



/*


      <div class="container mt-5 conteudoPagina">
<div class="row">
  <div class="col-2 col-sm-1">
    <img src="' . $foto . '" class="mt-2 imagem-miniatura" alt=""><br>
    <img src="' . $foto . '" class="mt-2 imagem-miniatura" alt=""><br>
    <img src="' . $foto . '" class="mt-2 imagem-miniatura" alt=""><br>
  </div>
  <div class="col-10 col-md-4">
    <img src="' . $foto . '" width="100%"  class="mt-2 bordaItens" alt=""><br>
  </div>
  <div class="col">
    <h1 class="display-5 corLetra mt-2">The last of Us 2</h1><br>
    <!--STAR INICIO-->
              <img src="imagens/star1.png" onclick="avaliar(1, 1)" id="s1">
              
              <img src="imagens/star1.png" onclick="avaliar(2, 1)" id="s2">
              
              <img src="imagens/star1.png" onclick="avaliar(3, 1)" id="s3">
              
              <img src="imagens/star1.png" onclick="avaliar(4, 1)" id="s4">
              
              <img src="imagens/star1.png" onclick="avaliar(5, 1)" id="s5">
      <!--STAR FIM-->
      <p class="display-6 corLetra mt-4">'. $preco .'</p><br>
    <p class="lead mt-2 corLetra">Descrição</p>
    <p class="corLetra"> ' . $desc . '</p>
    <div class="d-grid gap-2 col-6 mx-auto">
      <!--<button class="btn btn-outline-light mt-5" type="button"><h1 class=" display-6">Comprar</h1></button>-->
      <a href="carrinho.php" class="btn btn-outline-success mt-5" role="button"><h1 class=" display-6">Comprar</h1></a>
    </div>
  </div>
</div>
</div>
      */
?>