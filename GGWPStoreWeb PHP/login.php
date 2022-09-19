<?php
include_once "session.php";
include "cabecalho.php";
include "conexao.php";

if($_SESSION['login'] != ""){
  echo ("
        <script>
        window.location.href = \"perfil.php\";
        </script>
        ");
}
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
  <?php
if ($_SERVER["REQUEST_METHOD"] === 'POST') {
  $msg_erro = '';

      $login = strtoupper($_POST['login']);
      $senha = MD5($_POST['senha']);

      $sql = "SELECT count(email) as email FROM usuario_ggwp WHERE email = '$login' AND senha = '$senha'";
      
      foreach ($conn->query($sql) as $row) {
          $row['email'];
      }
      //die($row['email']);
      
      if($row['email'] == 1){
        $_SESSION['login'] = $login;
        echo ("
        <script>
        window.location.href = \"perfil.php\";
        </script>
        ");
      }else
      $msg_erro = 'Email ou senha incorretos';
}else{
  $msg_erro = "";
}
?>
    

  <?php echo $cabeca;?>

    <div class="centro-tela conteudoPagina">
    <div class="container-fluid">
        <div class="row justify-content-center mt-5">
            <section class="col-12 col-sm-6 col-md-4"> 
                <form class="form-container login needs-validation" novalidate method="POST">
                    <h1 class="text-center corLetra">Login</h1>
                    <br> <span class="text-center" style="color:red;" name="msg_erro" id="msg_erro"><?php echo($msg_erro) ?></span>

                    <div class="form-group">
                        <p class="lead corLetra mt-4">Email</p>
                        <input type="email" class="form-control" id="login" name="login" placeholder="email" required>
                        <div class="invalid-feedback">
                          Valor Invalido!
                        </div>
                    </div>
                    <div>
                        <p class="lead corLetra mt-3">Senha</p>
                        <input type="password" class="form-control" id="login" name="senha" placeholder="senha" required>
                        <div class="invalid-feedback">
                          Valor Invalido!
                        </div>
                    </div>
                    <div class="form-group form-check container">
                        <div class="row">
                        <div class="col-md-6 col-sm-12 mt-4">
                            <input type="checkbox" class="form-check-input">
                            <label class="form-check-label corLetra">Manter conectado</label>
                        </div>
                        <div class="col-md-6 col-sm-12 mt-4">
                            <a href="recuperarSenha.php">Esqueceu a senha?</a>
                        </div>
                        </div>
                    </div>
                    
                    <div class="row">
                        <div class="d-grid gap-2 mt-4">
                          <input type="submit" class="btn btn-outline-light" value="Entrar">
                            <!--<button class="btn btn-outline-light">Entrar</button>
                            <a href="perfil.php" class="btn btn-outline-light" role="button">Entrar</a>-->
                        </div>
                    </div>

                    <div class="row">
                        <div class="d-grid gap-2 mt-4 text-center">
                            <a href="registrar.php">Registrar-se</a>
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

<!--Inicio Script-->



  

<script type="text/javascript">
  // Example starter JavaScript for disabling form submissions if there are invalid fields
(function () {
'use strict'

// Fetch all the forms we want to apply custom Bootstrap validation styles to
var forms = document.querySelectorAll('.needs-validation')

// Loop over them and prevent submission
Array.prototype.slice.call(forms)
 .forEach(function (form) {
   form.addEventListener('submit', function (event) {
     if (!form.checkValidity()) {
       event.preventDefault()
       event.stopPropagation()
     }

     form.classList.add('was-validated')
   }, false)
 })
})()
</script>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>