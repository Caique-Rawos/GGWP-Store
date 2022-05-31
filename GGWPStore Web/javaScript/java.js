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