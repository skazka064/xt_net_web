document.querySelector('#drag').addEventListener('click', function(e){ // Вешаем обработчик клика на UL, не LI
  var id = e.target.id; // Получили ID, т.к. в e.target содержится элемент по которому кликнули
  document.querySelector('#test strong').innerHTML = id; // For example
});