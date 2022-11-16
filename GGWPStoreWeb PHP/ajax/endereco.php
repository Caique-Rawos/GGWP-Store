<?php
    $cep = $_POST['cep'];
    $cep = preg_replace("/[^0-9]/", "", $cep);
    $url = "http://viacep.com.br/ws/$cep/xml/";

    $xml = simplexml_load_file($url);

    $response = array(
        "cep"    => $xml->cep,
        "rua"    => $xml->logradouro,
        "bairro" => $xml->bairro,
        "cidade" => $xml->localidade,
        "uf"     => $xml->uf,
    );

    echo json_encode($response);
?>