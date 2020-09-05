
// ищем элементы
var modal = document.getElementById("myModal");
var addBtn = document.getElementById("myBtn");
var closeBtn = document.getElementById("closeBtn");
var span = document.getElementsByClassName("close")[0];
var mkBtn = document.getElementById("mkBtn");
var modalHead = document.getElementById("modalHead");
var modalBody = document.getElementById("modalBody");
var list = document.querySelector("#list");
var imgDelete =document.querySelector(".imgDelete");


mkBtn.onclick = function(){ 

var containerDiv = document.createElement('div');
var myTitle = modalHead.value;
var myText = modalBody.value;
if((myText==false)||(myTitle==false)){alert("Вы не ввели данные"); return false;} 
//containerDiv.id = modalHead.value; 
containerDiv.classList.add("containerDiv");  

var temp ="<p class='p-title'>"+myTitle+"</p>"+"<p onclick='myUpdate(this)' class='p-text'>"+myText+"</p>"+'<img onclick="myDelete(this)" id='+myTitle+' class="imgDelete" src="img/delete.png" alt="Удалить заметку" />';
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
function myDelete(el){
  var id =el.id;
  let qua = confirm('Вы действительно хотите удалить заметку?');
        if(qua) {
          document.getElementById(id).parentElement.remove();
        } 
}

function myUpdate(el){
  var id =el.id;
  let qua = confirm('Вы действительно хотите изменить заметку?');
        if(qua) {
          alert("OK");
        } 
}






