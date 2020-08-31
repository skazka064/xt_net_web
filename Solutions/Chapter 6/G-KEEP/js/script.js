let service = new Service();
class myRecord {
    constructor(head, body) {
      this.head = head;
      this.body = body;
    }
  }

  function createRec() {
    let head = document.getElementById("noteHeadCreate").value;
    let body = document.getElementById("noteTextCreate").textContent;
    
      let record = new  myRecord(head, body);
      showModalWindow();
      service.add(record);
      printNote(record);
      let noteId = document.getElementById(note.id);
      noteId.addEventListener("click", openChangeWindow);
   
  }
function addPlus() {  
    
     
}
function mySearch(input){
    
}