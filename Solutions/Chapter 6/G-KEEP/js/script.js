let service = new Service();
class myRecord {
    constructor(head, body) {
      this.head = head;
      this.body = body;
    }
  }
var modal = document.getElementById("myModal");
var btn = document.getElementById("myBtn");
var span = document.getElementsByClassName("close")[0];
btn.onclick = function(){
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
  
