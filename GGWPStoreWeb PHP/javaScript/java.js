var c=0;
function darkMode() {
  var element = document.body;
  element.classList.toggle("dark-mode");
    if(c==0){
        document.getElementById("texto").style.color = "black";
        c++;
    }else{
        document.getElementById("texto").style.color = "white";
        c=0;
    }
}

function changeImage(element) {
var main_prodcut_image = document.getElementById('main_product_image');
main_prodcut_image.src = element.src; }


var myLink = document.querySelector('a[href="#"]');
myLink.addEventListener('click', function(e) {
e.preventDefault();});

function mandaCarinho(id){
        window.location.href = "ajax/mandaCarrinho.php?id="+id+"";
}


function avaliar(valor, local){
    switch(valor){
        case 1:
            limpa(local);
            document.getElementById("s1").src= "imagens/star1.png";
            break;
        case 2:
            limpa(local);
            document.getElementById("s1").src= "imagens/star1.png";
            document.getElementById("s2").src= "imagens/star1.png";
            break;
        case 3:
            limpa(local);
            document.getElementById("s1").src= "imagens/star1.png";
            document.getElementById("s2").src= "imagens/star1.png";
            document.getElementById("s3").src= "imagens/star1.png";
            break;
        case 4:
            limpa(local);
            document.getElementById("s1").src= "imagens/star1.png";
            document.getElementById("s2").src= "imagens/star1.png";
            document.getElementById("s3").src= "imagens/star1.png";
            document.getElementById("s4").src= "imagens/star1.png";
            break;
        case 5:
            limpa(local);
            document.getElementById("s1").src= "imagens/star1.png";
            document.getElementById("s2").src= "imagens/star1.png";
            document.getElementById("s3").src= "imagens/star1.png";
            document.getElementById("s4").src= "imagens/star1.png";
            document.getElementById("s5").src= "imagens/star1.png";
            break;
        case 6:
            limpa(local);
            document.getElementById("s1").src= "imagens/star1.png";
            document.getElementById("s2").src= "imagens/star1.png";
            document.getElementById("s3").src= "imagens/star1.png";
            document.getElementById("s4").src= "imagens/star1.png";
            document.getElementById("s5").src= "imagens/star1.png";
            document.getElementById("s6").src= "imagens/star1.png";
            break; 
    }
}

function limpa(local){
    if(local == 1){
        document.getElementById("s1").src= "imagens/star0.png";
        document.getElementById("s2").src= "imagens/star0.png";
        document.getElementById("s3").src= "imagens/star0.png";
        document.getElementById("s4").src= "imagens/star0.png";
        document.getElementById("s5").src= "imagens/star0.png";
    }else{
        document.getElementById("s1").src= "imagens/star0.png";
        document.getElementById("s2").src= "imagens/star0.png";
        document.getElementById("s3").src= "imagens/star0.png";
        document.getElementById("s4").src= "imagens/star0.png";
        document.getElementById("s5").src= "imagens/star0.png";
        document.getElementById("s6").src= "imagens/star0.png";
    }
    
}

function salva_ajax(){
    $.post( 
        "id_listaProd.php", { 
        id: $_GET['id'] 
    },
    function( data ) {
        console.log(data);
    }, "json");
}