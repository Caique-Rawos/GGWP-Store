<?php
$id = $_GET['id'];
if($id == 1){
  $card = '<div class="col-lg-2 col-md-6 mt-3">
  <div class="prod"><a class="decoracao" href="produto.php?id_prod=1">
      <img class="tamanho img-fluid" src="imagens/foto_colecionaveis.png"></a>
      <p class="corLetra lead">Funkopop Star Wars</p>
      <p class="corLetra lead mt-2">R$ 79,99</p>
  </div>
</div>';
}else if($id == 2){
 $card = '<div class="col-lg-2 col-md-6 mt-3">
 <div class="prod"> <a class="decoracao" href="produto.php?id_prod=2">
     <img class="tamanho img-fluid" src="imagens/foto_games.png"></a>
     <p class="corLetra lead">The last of Us 2</p>
     <p class="corLetra lead mt-2">R$ 79,99</p>
 </div>
</div>';
}else if($id == 3){
  $card = '<div class="col-lg-2 col-md-6 mt-3">
  <div class="prod"><a class="decoracao" href="produto.php?id_prod=3">
      <img class="tamanho img-fluid" src="imagens/foto_computadores.png"></a>
      <p class="corLetra lead">Notebook gueimer</p>
      <p class="corLetra lead mt-2">R$ 79,99</p>
  </div>
</div>';
}else if($id == 4){
  $card = '<div class="col-lg-2 col-md-6 mt-3">
  <div class="prod"><a class="decoracao" href="produto.php?id_prod=4">
      <img class="tamanho img-fluid" src="imagens/foto_perifericos.png"></a>
      <p class="corLetra lead">Mouse Gamer Top</p>
      <p class="corLetra lead mt-2">R$ 79,99</p>
  </div>
</div>';
}else{
  $card = '<div class="col-lg-2 col-md-6 mt-3">
  <div class="prod"><a class="decoracao" href="produto.php?id_prod=5">
      <img class="tamanho img-fluid" src="imagens/foto_hqs.png"></a>
      <p class="corLetra lead">HQ Batman</p>
      <p class="corLetra lead mt-2">R$ 79,99</p>
  </div>
</div>';
}
?>