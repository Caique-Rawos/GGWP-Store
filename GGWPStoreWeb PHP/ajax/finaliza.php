<?php
include "../conexao.php";
include "../session.php";

$total = $_POST['total'];
$prod = $_POST['prod'];
$frete = $_POST['frete'];

$total = str_replace(".","",$total);
$total = str_replace(",",".",$total);

$prod = str_replace(".","",$prod);
$prod = str_replace(",",".",$prod);

$frete = str_replace(".","",$frete);
$frete = str_replace(",",".",$frete);

$hoje = date('Y-m-d');
$user = $_SESSION['login'];

$sql = "INSERT INTO vendas_ggwp (total_prod, frete, total, comprador, data) VALUES ($prod, $frete, $total, '$user', '$hoje');";

$stmt = $conn->prepare($sql);
$stmt->execute();

$sql = "SELECT max(idVendas) as id FROM vendas_ggwp;";
$stmt = $conn->prepare($sql);
$stmt->execute();

$id=0;
while($row = $stmt->fetch()){
    $id = $row['id'];
}


$sql = "SELECT p.id_produto, p.preco, car.qnt, p.usuario as vendedor, car.usuario as comprador  from produto_ggwp p
        LEFT JOIN (select id_item, count(id_item) as qnt, usuario from carrinho_ggwp group by id_item, usuario) as car on car.id_item = id_produto
        WHERE car.usuario = '$user';";

$stmt = $conn->prepare($sql);
$stmt->execute();
$result = $stmt->fetchAll();

foreach($result as $row){
    $sql = "INSERT INTO vendas_itens_ggwp (idVendas_itens, id_produto, preco_un, qntd, vendedor, comprador, id_venda) VALUES (0, {$row['id_produto']}, {$row['preco']}, {$row['qnt']}, '{$row['vendedor']}', '{$row['comprador']}', $id);";
    $stmt = $conn->prepare($sql);
    $stmt->execute();
}

$sql =  "DELETE FROM carrinho_ggwp WHERE usuario = '$user';";

$stmt = $conn->prepare($sql);
$stmt->execute();

$array = array(
    "error" => '0',
    "id" => $id,
);

echo json_encode($array);
?>