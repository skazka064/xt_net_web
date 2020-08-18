
let str = `У попа была собака`;

function charRemover(str) {

    str  = str.toLocaleLowerCase();
    let strChar = str.split(' '); // get array
    let emptyStr = {};
    let result; 

    strChar.forEach(function(item){ // Берем каждое слово из строки
        item.split('').forEach(function(charItem, index){ // Берем каждый символ из слова
            
            if (item.indexOf(charItem, index + 1) != -1) { // Ищем совпадения
                emptyStr[charItem] = 1;
            }        
        }); 
    });'use strict';

    result = str.split('').filter(function (char) { 
        return !emptyStr[char];
    }).join('');
    
    console.log(result);
}

charRemover(str);