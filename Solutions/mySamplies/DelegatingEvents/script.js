
table.onclick = function(event) {
    let td = event.target.closest('td'); // (1)
  
    if (!td) return; // (2)
  
    if (!table.contains(td)) return; // (3)
  
    highlight(td); // (4)
  };