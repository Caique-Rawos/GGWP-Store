<?php
include "conexao.php";

if(!isset($_GET['id'])){
  $id = 0;
}else{
  $id = $_GET['id'];
}

$sql = "SELECT * FROM produto_ggwp WHERE categoria = $id;";
               $stmt = $conn->prepare($sql);
               $stmt->execute();
              $cards = "";
               while ($row = $stmt->fetch()) {
                  echo '
                  <div class="col-md-6 col-lg-4 col-xl-3">
                  <div class="prod">
                    <div id="product-2" class="single-product">
                      <div class="part-1">
                        <a href="produto.php?id_prod='.$row['id_produto'].'">
                        <img id="product-2" class="single-product part-1 rodar"  src="data:image;base64,'.base64_encode($row["foto"]).'">
                        </a>
                          <ul>
                        
                          </ul>
                      </div>
                      <div class="part-2">
                          <h1 class="product-title" style="text-align: left">'.$row['nome'].'</h1>
                          <h5 style="text-align: right">R$ '.number_format($row['preco'],2,",",".").'</h5>
                      </div>
                    </div>
                  </div>
                  </div>';
               }
           /* old echo

          '<div class="col-lg-3 col-md-6 mt-3">
                  <div class="prod"><a class="decoracao" href="produto.php?id_prod='.$row['id_produto'].'">
                      <img class="tamanho img-fluid" src="data:image;base64,'.base64_encode($row["foto"]).'"></a>
                      <p class="corLetra lead">'.$row['nome'].'</p>
                      <p class="corLetra lead mt-2">R$ '.number_format($row['preco'],2,",",".").'</p>
                  </div>
                </div>'
           */
?>