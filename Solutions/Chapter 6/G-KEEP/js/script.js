let service = new Service();
// Модальное окно +
var modal = document.getElementById("myModal");
var addBtn = document.getElementById("myBtn");
var closeBtn = document.getElementById("closeBtn");
var span = document.getElementsByClassName("close")[0];
var mkBtn = document.getElementById("mkBtn");
var modalBody = document.getElementById("modalBody");
var modalHead = document.getElementById("modalHead");
var list = document.querySelector("#list");
mkBtn.onclick = function(){ 
var myDiv = document.createElement('div');
myDiv.classList.add("myNote");

myDiv.innerHTML=modalBody.value;
list.appendChild(myDiv);
modalBody.value="";
modalHead.value="";
}
closeBtn.onclick=function(){
  modal.style.display="none";
}
addBtn.onclick = function(){
  modal.style.display="block";
}
span.onclick= function(){
  modal.style.display="none";
}
window.onclick = function(event){
  if(event.target==modal){
    modal.style.display="none";
  }
}
