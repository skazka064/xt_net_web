let service = new Service();
// Модальное окно +
var modal = document.getElementById("myModal");
var addBtn = document.getElementById("myBtn");
var closeBtn = document.getElementById("closeBtn");
var span = document.getElementsByClassName("close")[0];
var mkBtn = document.getElementById("mkBtn");
var modalHead = document.getElementById("modalHead");
var modalBody = document.getElementById("modalBody");
var list = document.querySelector("#list");

mkBtn.onclick = function(){ 
var containerDiv = document.createElement('div');
var HeadDiv = document.createElement('div');
var BodyDiv = document.createElement('div');

containerDiv.classList.add("containerDiv");
var temp ="<p>"+modalHead.value+"</p>"+"<p>"+modalBody.value+"</p>"+'<div class="wrapDeleteImg"><img id="imgDelete" src="img/delete.png" alt="Удалить заметку" /></div>';

containerDiv.innerHTML=temp;


list.append(containerDiv);



modalHead.value="";
modalBody.value="";

modal.style.display="none";
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
