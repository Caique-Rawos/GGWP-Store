<?php 
include "conexao.php";
$id_prod = $_GET['id_prod'];

$sql = "SELECT * FROM produto_ggwp WHERE id_produto = $id_prod;";
               $stmt = $conn->prepare($sql);
               $stmt->execute();
              $cards = "";
while ($row = $stmt->fetch()) {
  $htmlProd = '
<!-- Conteudo Principal-->
<div class="container mt-5 mb-5"> 
<div class="body">  
  <div class="row g-0"> 
    <div class="col-md-6 "> 
      <div class="d-flex flex-column justify-content-center"> 
        <div class="main_image">  
          <img src="data:image;base64,'.base64_encode($row["foto"]).'" id="main_product_image" width="350"> 
        </div>  
        <div class="mt-3"></div>
        <div class="thumbnail_images">  
          <ul id="thumbnail"> 

          <li><img onclick="changeImage(this)" src="data:image;base64,'.base64_encode($row["foto"]).'" width="70"></li> 
          <li><img onclick="changeImage(this)" src="data:image;base64,'.base64_encode($row["foto"]).'" width="70"></li>
          <li><img onclick="changeImage(this)" src="data:image;base64,'.base64_encode($row["foto"]).'" width="70"></li> 
          <li><img onclick="changeImage(this)" src="data:image;base64,'.base64_encode($row["foto"]).'" width="70"></li>

        </ul> 

        </div>  
      </div>  
    </div>  
    <div class="col-md-6">  
      <div class="p-3 right-side">
        <div class="d-flex justify-content-between align-items-center"> 
          <h3>'.$row['nome'].'</h3>  
        </div>  
        <div class="mt-2 pr-3 content"> 
          <p>'.$row['descricao'].'</p> 
        </div>
        <br>  
        <h3>R$ '.number_format($row['preco'],2,",",".").'</h3>  

         <!--STAR INICIO-->
         <img src="imagens/star1.png" width="30px" onclick="avaliar(1, 1)" id="s1">
         <img src="imagens/star1.png" width="30px" onclick="avaliar(2, 1)" id="s2">
         <img src="imagens/star1.png" width="30px" onclick="avaliar(3, 1)" id="s3">
         <img src="imagens/star1.png" width="30px" onclick="avaliar(4, 1)" id="s4">
         <img src="imagens/star1.png" width="30px" onclick="avaliar(5, 1)" id="s5">
        <!--STAR FIM--> 

            <br>

             <a onclick="mandaCarinho('.$id_prod.')" class="btn btn-outline-success mt-5" role="button"><h1 class=" display-6">Comprar</h1></a>
  
              </div>  
            </div>  
          </div>  
        </div>  
      </div> 
    </div>

<!-- Fim conteudo Principal-->';
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