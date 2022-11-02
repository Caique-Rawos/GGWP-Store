<?php 
include_once "../session.php";
include_once "../conexao.php";

if(isset($_SESSION['login'])){
    if($_SESSION['login'] != ""){
        $id_prod = $_GET['id'];

        $sql = "INSERT INTO carrinho_ggwp (idcarrinho, id_item, usuario) values (0, $id_prod, '{$_SESSION['login']}');";
               $stmt = $conn->prepare($sql);
               $stmt->execute();
    }

}
echo "
        <script>
        window.location.href = \"../carrinho.php\";
        </script>
        ";

?>