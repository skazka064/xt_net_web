
// Ищем элементы и присваиваем переменным ссылки на них
var modal = document.getElementById("myModal");
var addBtn = document.getElementById("myBtn");
var closeBtn = document.getElementById("closeBtn");
var span = document.getElementsByClassName("close")[0];
var mkBtn = document.getElementById("mkBtn");
var modalHead = document.getElementById("modalHead");
var modalBody = document.getElementById("modalBody");
var list = document.querySelector("#list");
var imgDelete =document.querySelector(".imgDelete");

// Собираем заметку при нажатии на +
mkBtn.onclick = function(){ 
var containerDiv = document.createElement('div');
var myTitle = modalHead.value;
var myText = modalBody.value;
if((myText==false)||(myTitle==false)){alert("Вы не ввели данные"); return false;} 
containerDiv.id = "containerDiv__"+myTitle; 
containerDiv.classList.add("containerDiv");  
var temp ="<p class='p-title'>"+myTitle+"</p>"+"<p onclick='myUpdate(this)' class='p-text'>"+myText+"</p>"+'<img onclick="myDelete(this)" id='+"img__"+myTitle+' class="imgDelete" src="img/delete.png" alt="Удалить заметку" />';
containerDiv.innerHTML=temp;
list.append(containerDiv);
modalHead.value="";
modalBody.value="";
modal.style.display="none";
}
//Закрытие модального окна
closeBtn.onclick=function(){
  modal.style.display="none";
}
//Открытие модального окна при нажатии на кнопке плюсик
addBtn.onclick = function(){
  modal.style.display="block";
}
//Закрытие модального окна при нажатии на крестик
span.onclick= function(){
  modal.style.display="none";
}
//Закрытие модального окна при нажатии на область около него
window.onclick = function(event){
  if(event.target==modal){
    modal.style.display="none";
  }
}
//Функция удаления заметки
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
          modal.style.display="block";
          var myTitle = modalHead.value;
          var myText = modalBody.value;
          
        console.log(el.parentElement);
        } 
}






