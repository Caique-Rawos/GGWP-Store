<?php
include_once "session.php";
include_once "conexao.php";
include "cabecalho.php";
?>


<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
    
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="css/style.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/6b517c0011.js" crossorigin="anonymous"></script>
    <link rel="icon" type="image/x-icon" href="imagens/favicon-32x32.ico">
    <script src="javaScript/java.js"></script>
    <script src="jquery/jquery-3.6.1.min.js"></script>

    <script>
      function somenteNumeros(e) {
        var charCode = e.charCode ? e.charCode : e.keyCode;
        var text = $("#preco").val();
        if(text.includes(".") && (charCode == 46 || charCode == 44)){
           return false;
        }else if(charCode == 46 || charCode == 44){
          $("#preco").val($("#preco").val() + ".");
          return false;
        }

        // charCode 8 = backspace   
        // charCode 9 = tab
        if (charCode != 8 && charCode != 9) {
            // charCode 48 equivale a 0   
            // charCode 57 equivale a 9
            if (charCode < 48 || charCode > 57) {
                return false;
            }
        }
    }
    </script>

    <title>GGWP Store</title>
</head>

<body>

<?php echo $cabeca;?>

<h2>Cadastro de Produtos</h2>
<div>

    <!-- form com enctype para indicar que serão enviados dados em binário além de texto -->
    <form method="POST" enctype="multipart/form-data">

    <h2>Titulo</h2>
        <input type="text" name="nome" id="nome"><br><br>
        <h2>Descrição</h2>
        <input type="text" name="desc" id="desc"><br><br>
        <h2>Preço</h2>
        <input type="text" name="preco" id="preco" onkeypress="return somenteNumeros(event);"/><br><br>
        <h2>Categoria</h2>
        <select name="cat">
        <option value="1">Colecionáveis</option>
        <option value="2">Games</option>
        <option value="3">Computadores</option>
        <option value="4">Periféricos</option>
        <option value="5">HQ's</option>
      </select>
        <h2>Quantidade</h2>
        <input type="number" name="quant" id="quant" onkeypress="return somenteNumeros(event);"><br><br>

        Foto:<br>
        <input type="file" name="foto" accept="image/gif, image/png, imagem/jpg"><br><br>

        <input type="submit" value="Cadastrar">

        <hr>

    </form>
</div>

<!--INICIO FOOTER-->
<footer id="sticky-footer" class="flex-shrink-0 py-2 bg-dark text-white-50 mt-5">
        <div class="container text-center">
          <small>Copyright &copy; GGWP Store</small>
        </div>
      </footer>
    <!--FIM FOOTER-->

</body>
</html>

<?php

   include("conexao.php");

    // Constante para o tam máximo de arquivo de foto - 2 MB
    define('TAMANHO_MAXIMO', (5 * 1024 * 1024));

    function endsWith($haystack, $needle, $case = true) {
      if ($case) {
          return (strcmp(substr($haystack, strlen($haystack) - strlen($needle)), $needle) === 0);
      }
      return (strcasecmp(substr($haystack, strlen($haystack) - strlen($needle)), $needle) === 0);
  }

    if ($_SERVER["REQUEST_METHOD"] === 'POST') {
        //die(var_dump(print_r($_FILES)) . var_dump(print_r($_POST)));
           if(isset($_FILES['foto'])){
               $arquivo = $_FILES['foto'];
               //die(var_dump(print_r($arquivo)) . "teste" . var_dump(print_r($_FILES['foto'])));
               if($arquivo['error']){
                 die("Falha ao enviar aquivo!");
               }
               if($arquivo['size'] > 5242880){
                   die("<script> alert('Tamanha maximo da imagem de 5MB!') </script>");
               }else{
                   if( ($arquivo['name'] != "") && (!preg_match('/^image\/(jpeg|png|jpg)$/', $arquivo['type'])) ){
                       die("Formato invalido, apenas arquivos JPG, PNG e JPEG são aceitos!");
                   }else{
                        if ($arquivo['name'] == "") {
                            $fotoBinario = null;
                        } else {
                            $fotoBinario = file_get_contents($arquivo['tmp_name']);
                        }

                         $nome = $_POST['nome'];
                         $desc = $_POST['desc'];
                         $preco = $_POST['preco'];
                         if(endsWith($preco, ".")){
                          die("<script> alert('Defina o preço corretamente!') </script>");
                         }
                         $cat = $_POST['cat'];
                         $quant = $_POST['quant'];
                         $hoje = date('Y-m-d');
                         $sql = "INSERT INTO produto_ggwp (id_produto, nome, descricao, preco, quantidade, categoria, foto, usuario, data) VALUES (0,'$nome', '$desc', $preco, $quant, '$cat', :img, '{$_SESSION['login']}', '$hoje');";

                         //die($sql);
                         try{
                          $stmt = $conn->prepare($sql);
                          $stmt->bindParam(':img', $fotoBinario);
                          $stmt->execute();
                           //$conn -> query($sql);
                           echo("<span> Cadastrado com sucesso </span>");
                         }catch(exception $e){
                           die("Erro ao executar comando SQL!");
                         }
                   }
               }
           }
      }
?>
