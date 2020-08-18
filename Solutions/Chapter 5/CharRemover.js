
let str = `У попа была собака`;

function charRemover(str) {

    str  = str.toLocaleLowerCase();
    let myStr = str.split(' '); // get array
    let myNewArr = {};
    let result; 

    myStr.forEach(function(getWord){ // Берем каждое слово из строки
        getWord.split('').forEach(function(getChar, index){ // Берем каждый символ из слова
            
            if (getWord.indexOf(getChar, index + 1) != -1) { // Ищем совпадения
                myNewArr[getChar] = 1;
            }        
        }); 
    });'use strict';

    result = str.split('').filter(function (char) { 
        return !myNewArr[char];
    }).join('');
    
    console.log(result);
}

charRemover(str);