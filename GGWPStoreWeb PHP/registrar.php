<?php
include_once "session.php";
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
    

  <?php echo $cabeca;?>
  <?php
if ($_SERVER["REQUEST_METHOD"] === 'POST') {
  $msg_erro = '';
  $erro = 0;

      $email = trim(strtoupper($_POST['email']));
      //die($email);
      $username = $_POST['username'];
      $senha = MD5($_POST['senha']);
      $senha_desk = $_POST['senha'];

      $sql = "SELECT count(email) as email FROM usuario_ggwp WHERE email = '$email'";
      //$count = 0;

      //$res = $conn->query($sql);
      //$count = $res->fetchColumn();
      
      foreach ($conn->query($sql) as $row){
         $row['email'];
      }
      //die($row['email']);
      
      if((trim($email) != "") && (trim($senha) != "") && (trim($username) != "")){
        $hoje = date('Y/m/d');
        $sql_insert = "INSERT INTO usuario_ggwp (id_usuario, email, username, senha, data) values(0, '$email', '$username', '$senha', '$hoje');
                       INSERT INTO usuario_desktop_ggwp (id_usuario, email, senha) values(0, '$email', '$senha_desk');";
        try{
          if($row['email'] == 0){
            $conn -> query($sql_insert);
            $_SESSION['login'] = $email;
          echo ("
          <script>
          window.location.href = \"perfil.php\";
          </script>
          ");
          }else{
            $msg_erro = "Email já existente";
          }
        }catch (exception $e){
          $msg_erro = "Como você conseguiu tamanha proeza?";
          //die($e->getMessage());
        }
      }else
      $msg_erro = 'Email, username ou senha invalidos!';
}else{
  $msg_erro = "";
}
?>

  <div class="centro-tela conteudoPagina">
    <div class="container-fluid">
        <div class="row justify-content-center mt-5">
            <section class="col-12 col-sm-6 col-md-4"> 
                <form method="POST" class="form-container login needs-validation" novalidate>
                    <h1 class="text-center corLetra">Registrar</h1>
                    <div class="form-group">
                      <span id="erro" name="erro"><?php echo($msg_erro)?></span>
                        <p class="lead corLetra mt-4">Email</p>
                        <input type="email" class="form-control" name="email" id="email" placeholder="email" required>
                        <div class="invalid-feedback">
                          Email Invalido!
                        </div>
                    </div>
                    <div>
                        <p class="lead corLetra mt-3">Username:</p>
                        <input type="text" class="form-control" name="username" id="username" placeholder="username" required>
                        <div class="invalid-feedback">
                          Defina um nome de usuario!
                        </div>
                    </div>
                    <div>
                        <p class="lead corLetra mt-3">Senha</p>
                        <input type="password" class="form-control" name="senha" id="senha" placeholder="senha" required>
                        <div class="invalid-feedback">
                          Defina sua senha!
                        </div>
                    </div>

                    <div class="row">
                        <div class="d-grid gap-2 mt-4">
                            <button type="submit" class="btn btn-outline-light">Registrar</button>
                        </div>
                    </div>

                    <div class="row">
                        <div class="d-grid gap-2 mt-4 text-center">
                            <a href="login.php">Ja possuo uma conta</a>
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