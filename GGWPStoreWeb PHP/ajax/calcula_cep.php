<?php

    $cep_origem = "13482732";     // Seu CEP , ou CEP da Loja
    $cep_destino = $_POST['cep']; // CEP do cliente
    $valor_prod = $_POST['preco'];



    /* DADOS DO PRODUTO A SER ENVIADO */
    $peso          = 2;
    $valor         = 100;
    $tipo_do_frete = '40010'; //Sedex: 40010|Pac: 41106
    $altura        = 6;
    $largura       = 20;
    $comprimento   = 20;


    $url = "http://ws.correios.com.br/calculador/CalcPrecoPrazo.aspx?";
    $url .= "nCdEmpresa=";
    $url .= "&sDsSenha=";
    $url .= "&sCepOrigem=" . $cep_origem;
    $url .= "&sCepDestino=" . $cep_destino;
    $url .= "&nVlPeso=" . $peso;
    $url .= "&nVlLargura=" . $largura;
    $url .= "&nVlAltura=" . $altura;
    $url .= "&nCdFormato=1";
    $url .= "&nVlComprimento=" . $comprimento;
    $url .= "&sCdMaoProria=n";
    $url .= "&nVlValorDeclarado=" . $valor;
    $url .= "&sCdAvisoRecebimento=n";
    $url .= "&nCdServico=" . $tipo_do_frete;
    $url .= "&nVlDiametro=0";
    $url .= "&StrRetorno=xml";


    $xml = simplexml_load_file($url);

    $frete =  $xml->cServico;

    $valor_prod = str_replace(".","",$valor_prod);
    $valor_prod = str_replace(",",".",$valor_prod);

    $frete_val = strval($frete->Valor);

    $frete_val = str_replace(".","",$frete_val);
    $frete_val = str_replace(",",".",$frete_val);

    $tot = number_format(floatval($frete_val) + floatval($valor_prod),2,",",".");

    $response = array(
        "valor" => $frete->Valor,
        "prazo" => $frete->PrazoEntrega,
        "total" => $tot,
    );

    echo json_encode($response);

 ?>
