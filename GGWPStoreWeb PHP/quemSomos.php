<?php
include_once "session.php";
include "cabecalho.php";
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
        .accordion{
            margin-top: 1vh;
            margin-bottom: 1vh;
        }
    </style>
</head>
<body>
<div class="principal">
<?php echo $cabeca;?>

      <!-- Conteudo Principal-->
      

    <div class="container bg-dark mt-5 p-3 conteudoAccordiao">
        <div class="accordion bg-dark" id="accordionExample">
            <div class="accordion-item">
              <h2 class="accordion-header conteudoAccordiao  corLetra" id="headingOne">
                <button class="accordion-button conteudoAccordiao corLetra" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                  Quem Somos?
                </button>
              </h2>
              <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                <div class="accordion-body conteudoAccordiao corLetra">
                  <p> Somos uma revenda de games e acessórios especializada, que está sempre pronta pra te atender com toda atenção e disposição possíveis.</p>
                  <p> Aqui também somos gamers de verdade e ficamos extremamente felizes em poder fazer parte da sua gameplay. Então, conte com a gente sempre que precisar :)</p>
                  Uma vez gamer, sempre gamer!
            </div>
              </div>
            </div>
            <div class="accordion-item">
              <h2 class="accordion-header conteudoAccordiao corLetra" id="headingTwo">
                <button class="accordion-button collapsed conteudoAccordiao corLetra" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                  Perguntas Frequentes
                </button>
              </h2>
              <div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#accordionExample">
                <div class="accordion-body conteudoAccordiao corLetra">
                  <p><strong>Compras: </strong>
                    Nós disponibilizamos vários tipos de pagamentos em nosso site, se na compra você não conseguir achar seu modo de pagamento falar com o vendedor.</p>
                    <p><strong>Devolução: </strong>
                    Para devolver um produto é preciso entrar em contato com o vendedor, para combinar a devolução e de que forma será feita. Assim recebendo também o reembolso da maneira mais adequada. </p>
                    <p><strong>Opinião em Anúncios: </strong>
                    Todos os usuários cadastrados conseguem comentar em publicações dos itens, se infelizmente não conseguir, é possível que o vendedor tenha bloqueado você ou os comentários naquele produto. Para ter certeza, verifique se está conseguindo fazer perguntas em outros anúncios. Se conseguir, foi exatamente isso que aconteceu.
                    </p>
                    <p><strong>Direito de arrependimento de compra: </strong>
                      Você tem o prazo legal de até 7 dias corridos, contados do recebimento do produto, para se arrepender da compra.
                      </p>
                </div>
              </div>
            </div>
          </div>

     <!--Mapa-->
    <div class="container">
        <p class="display-2 corLetra">Nossa Localização:</p>
         <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3684.446458929352!2d-47.42729288504055!3d-22.562399385187994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c8806c2c324933%3A0xe2108428886c8646!2sCotil%20(Unicamp)!5e0!3m2!1spt-BR!2sbr!4v1649724435101!5m2!1spt-BR!2sbr" width="100%" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
        </div>  
    </div>

    <div class="conteudoPagina"></div>

    <!-- Fim conteudo Principal-->

    <!--INICIO FOOTER-->
    <footer id="sticky-footer" class="flex-shrink-0 py-2 bg-dark text-white-50 mt-5">
        <div class="container text-center">
          <small>Copyright &copy; GGWP Store</small>
        </div>
    </footer>
    <!--FIM FOOTER-->
  </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    
</body>
</html>