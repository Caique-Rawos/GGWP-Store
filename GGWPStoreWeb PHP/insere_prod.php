<?php
require("conexao.php");

$nomeEvento = $_POST['nome'];
$descricaoEvento = $_POST['desc'];
die(var_dump($_FILES));
$imagem = $_FILES['imagem']['tmp_name'];
$tamanho = $_FILES['imagem']['size'];
$tipo = $_FILES['imagem']['type'];
$nome = $_FILES['imagem']['name'];

if ( $imagem != "none" )
{
    $fp = fopen($imagem, "rb");
    $conteudo = fread($fp, $tamanho);
    $conteudo = addslashes($conteudo);
    fclose($fp);


$sql = "INSERT INTO tabela_imagens (nome_evento,
descricao_evento, nome_imagem,
tamanho_imagem, tipo_imagem, imagem) VALUES ('$nomeEvento',
'$descricaoEvento','$nome','$tamanho', '$tipo','$conteudo')";

$conn -> query($sql) or die("Algo deu errado ao inserir
 o registro. Tente novamente.");
echo 'Registro inserido com sucesso!';
header('Location: index.php');
 if(mysql_affected_rows($conexao) > 0)
     print "A imagem foi salva na base de dados.";
 else
     print "Não foi possível salvar a imagem na base de dados.";
 }
else
    print "Não foi possível carregar a imagem.";
?>