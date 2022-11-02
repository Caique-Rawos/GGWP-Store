<?php

function getFoto(){
  include "conexao.php";
  $email = $_SESSION['login'];
  if($email == ""){
    return "<a href='login.php'>
    <button class='btn' type='submit'><i class='fa-solid fa-user fa-xl'></i></button>
    </a>";
  }else{
    $sql = "SELECT id_usuario, foto FROM usuario_ggwp WHERE email = '$email';";
    $stmt = $conn->prepare($sql);
    $stmt->execute();

    while ($row = $stmt->fetch()) {
      if($row['foto'] != null){
        return "<img onclick='window.location.href = \"perfil.php\";' style='width: 32px; height: 32px; border-radius: 50%;' src='data:image;base64,".base64_encode($row["foto"])."'>";
      }else{
        return "<img onclick='window.location.href = \"perfil.php\";' style='width: 32px; height: 32px;' src='imagens/foto.png'>";
      } 
    }
  }
}

    $cabeca = "<!--INICIO NAVBAR-->
    <nav class='navbar navbar-dark bg-dark navbar-expand-lg navbar-light bg-light '>
            <div class='container-fluid'>
              <a class='navbar-brand' href='index.php'><img src='imagens/GGWPLogo.png' width='70vh' alt='Logo da Loja'></a>
              <button class='navbar-toggler' type='button' data-bs-toggle='collapse' data-bs-target='#navbarSupportedContent' aria-controls='navbarSupportedContent' aria-expanded='false' aria-label='Toggle navigation'>
                <span class='navbar-toggler-icon'></span>
              </button>
              <div class='collapse navbar-collapse' id='navbarSupportedContent'>
                <ul class='navbar-nav me-auto mb-2 mb-lg-0'>
                  <li class='nav-item'>
                    <a class='nav-link' aria-current='page' href='index.php'><span class='corLetra-cabecalho'>Home</span></li></a>
                  <li class='nav-item dropdown'>
                    <a class='nav-link dropdown-toggle' href='#' id='navbarDropdown' role='button' data-bs-toggle='dropdown' aria-expanded='false'>
                     <span class='corLetra-cabecalho'>Categorias</span>
                    </a>
                    <ul class='dropdown-menu' aria-labelledby='navbarDropdown'>
                      <li><a class='dropdown-item' href='lista_itens.php?id=1'><span>Colecionáveis</span></a></li>
                      <li><a class='dropdown-item' href='lista_itens.php?id=2'><span>Games</span></a></li>
                      <li><a class='dropdown-item' href='lista_itens.php?id=3'><span>Computadores</span></a></li>
                      <li><a class='dropdown-item' href='lista_itens.php?id=4'><span>Periféricos</span></a></li>
                      <li><a class='dropdown-item' href='lista_itens.php?id=5'><span>HQ's</span></a></li>
                    </ul>
                  </li>
                  <!--<li class='nav-item'>
                  <a class='nav-link' aria-current='page' href='quemSomos.php'><span class='corLetra-cabecalho'>Quem Somos</span></li></a>-->
                </ul>
                <form class='d-flex'>
                  <input class='form-control me-2' type='search' placeholder='Buscar' aria-label='Search'>
                  <button class='btn' type='submit'><i class='fa-solid fa-magnifying-glass fa-xl'></i></button>
                    
                </form>
              </div>
                    ";
                    $cabeca .= getFoto();
                    $cabeca .= "
                    <a href='carrinho.php'><button class='btn' type='submit'><i class='fa-solid fa-cart-arrow-down fa-xl'></i></button></a>
              <div>
                      <button class='btn' onclick='darkMode()'><i class='fa-solid fa-moon fa-xl'></i></button> 
                  </div>
            </div>
          </nav>
          <!--FIM NAVBAR-->";
?>