<?php
include_once "session.php";
include_once "conexao.php";
include "cabecalho.php";
$count = 0;


if($_SESSION['login'] == ""){
  echo ("
        <script>
        window.location.href = \"login.php\";
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
    <link href="css/style.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/6b517c0011.js" crossorigin="anonymous"></script>
    <link rel="icon" type="image/x-icon" href="imagens/favicon-32x32.ico">
    <script src="javaScript/java.js"></script>

    <title>GGWP Store</title>

    <style>
        table {
            display: grid;
            border-collapse: collapse;
            min-width: 100%;
            grid-template-columns: 
            minmax(150px, 1fr)
            minmax(150px, 1.67fr)
            minmax(150px, 1.67fr);
        }

        thead,
        tbody,
        tr {
            display: contents;
        }

        th,
        td {
            padding: 15px;
            overflow: hidden;
            text-overflow: ellipsis;
            white-space: nowrap;
            border: 1px solid white;
            text-align: center;
        }

        th {
            position: sticky;
            top: 0;
            background: #6c757d;
            text-align: left;
            font-weight: normal;
            font-size: 1.1rem;
            color: black;
            text-align: center;
        }
    </style>

 

</head>
<body>
<?php echo $cabeca;?>

<div style="height: 100px"></div>
    <!-- form com enctype para indicar que serÃ£o enviados dados em binÃ¡rio alÃ©m de texto -->
    <div class="container bordaItens corLetra mt-5 p-4">
        <form method="POST" enctype="multipart/form-data">
        <h1 class="corLetra display-5 text-center">Tabela de vendas</h1>
        <br>
         <table>
            <thead>
                <tr>
                <th><strong>ID</strong></th>
                <th><strong>Comprador</strong></th>
                <th><strong>Preço</strong></th>
                </tr>
            </thead>
            <tbody>
                <?php 
                $sql = "select idVendas, total, username from vendas_ggwp left join usuario_ggwp on email = comprador order by idVendas;";
                try{
                  foreach ($conn->query($sql) as $row) {
                    echo "<tr>
                    <td>".$row['idVendas']."</td>
                    <td>".$row['username']."</td>
                    <td>R$ ".number_format($row['total'],2,",",".")."</td>
                    </tr>";
                }
                }catch(exception $e){
                  die("Erro ao Buscar Vendas");
                  $_SESSION['login'] = "";
                }
                ?>
        </table> 

    <div style="height: 190px"></div>
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