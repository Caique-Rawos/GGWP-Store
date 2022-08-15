<?php 
$id_prod = $_GET['id_prod'];

if($id_prod == 1){
$foto = "imagens/foto_colecionaveis.png";
$preco = "R$ 79,99";
$desc = "Se está querendo inovar seu ambiente ou iniciar uma coleção, a linha Pop! ™ da empresa norte americana Funko®, tem tudo que você precisa. Desde os pequenos pins até os enormes Pops de 18 polegadas (46cm), eles vão dar uma cara nova a sua casa com seus personagens favoritos!";
}else if($id_prod == 2){
$foto = "imagens/foto_games.png";
$preco = "R$ 79,99";
$desc = "The Last of Us é um jogo eletrônico de ação-aventura e sobrevivência desenvolvido pela Naughty Dog e publicado pela Sony Computer Entertainment.";
}else if($id_prod == 3){
$foto = "imagens/foto_computadores.png";
$preco = "R$ 79,99";
$desc = "Notebook Gamer Acer Nitro 5 Intel Core i5 8GB 1TB - 128GB SSD 15.6 NVIDIA GeForce GTX 1650";
}else if($id_prod == 4){
$foto = "imagens/foto_perifericos.png";
$preco = "R$ 79,99";
$desc = "Mouse Sensor Pixart 3200 DPI. com gel nas laterais proporcionando melhor conforto. Desenvolvido com 6 Botoes incluindo seletor de DPI e Scroll. 7 cores LED pulsante. com design anatômico. cabo 1.5m e interruptores Huano para 5 milhões de cliques. garantindo alta durabilidade.";
}else{
$foto = "imagens/foto_hqs.png";
$preco = "R$ 79,99";
$desc = "“A CORTE DAS CORUJAS VIGIA VIGIA o TEMPO INTEIRO” Batman já ouviu falar sobre o conto da Corte das Corujas. Há séculos reunindo-se nas sombras e usando a ave de rapina noturna como seu cartão de visita, é dito que os membros dessa temível e poderosa cabala são os verdadeiros donos de Gotham City.";
}

$htmlProd = '<div class="container mt-5 conteudoPagina">
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
    <p><i class="fa-solid fa-star fa-xl amarelo "></i><i class="fa-solid fa-star fa-xl amarelo"></i><i class="fa-solid fa-star fa-xl amarelo"></i><i class="fa-solid fa-star fa-xl amarelo"></i><i class="fa-solid fa-star fa-xl amarelo"></i></p>
    <p class="display-6 corLetra mt-4">'. $preco .'</p><br>
    <p class="lead mt-2 corLetra">Descrição</p>
    <p class="corLetra"> ' . $desc . '</p>
    <div class="d-grid gap-2 col-6 mx-auto">
      <!--<button class="btn btn-outline-light mt-5" type="button"><h1 class=" display-6">Comprar</h1></button>-->
      <a href="carrinho.php" class="btn btn-outline-success mt-5" role="button"><h1 class=" display-6">Comprar</h1></a>
    </div>
  </div>
</div>
</div>';
?>