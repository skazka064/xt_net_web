
let str = `У попа была собака`;

function charRemover(str) {

    str  = str.toLocaleLowerCase();
    let strChar = str.split(' '); // get array
    let emptyStr = {};
    let result; 

    strChar.forEach(function(item){ // get each words
        item.split('').forEach(function(charItem, index){ // get char in each words
            
            if (item.indexOf(charItem, index + 1) != -1) { // looking for coincidence
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