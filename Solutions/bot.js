function setText(elem, text, speed) {
  // Обращаемся к элементу
  var e = document.getElementsByClassName("non-resizable");
  // Устанавливаем начальную позицию
  var i = 0,
  // Создаём интервал
      int = setInterval(function() {
        // Если позиция равна количеству символов в тексте, то удаляем интервал
        if(i == text.length){
          clearInterval(int);
        };
        // Устанавливаем значение для textarea
        e[0].value = text.substr(0,i); // Текст от начала до текущей позиции
        // Прибавляем +1 к позиции
        i++;
      }, speed);
      
  // Для фокуса
  e[0].focus();
  e[0].onblur = function() { clearInterval(int) };
};
setText('#test', 'Обращение сформировано некорректно.', 300);

document.location.href = "http://ppoz-service-bal-01.prod.egrn:9001/#/administration/details/PKPVD-2020-12-27-021194/history";
var btnAll = document.getElementsByClassName("save");
var txtArea = document.getElementsByClassName("non-resizable");
txtArea[0].focus();
txtArea[0].value="Обращение сформировано некорректно..";
btnAll[0].disabled=false;
btnAll[1].disabled=false;
console.log(btnAll[0].disabled);
btnAll[0].click();



function setKeywordText(text) {
    var el = document.getElementsByClassName("non-resizable");
    el[0].value = text;
    var evt = document.createEvent("KeyboardEvent");
    evt.initEvent("keyUp", true, true);
    el[0].dispatchEvent(evt);	
}
setKeywordText("Обращение сформировано некорректно");
