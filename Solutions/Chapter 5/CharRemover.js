
let str = `У попа была собака`;

function charRemover(str) {

    
    let myStr = str.split(' '); // get array
    let myNewArr = [];
    let result; 

    myStr.forEach(function(getWord){ // Берем каждое слово из строки
        getWord.split('').forEach(function(getChar, i){ // Берем каждый символ из слова
            
            if (getWord.indexOf(getChar, i + 1) != -1) { // Ищем совпадения
                myNewArr[getChar] = 1;
            }        
        }); 
    });

    result = str.split('').filter(function (char) { 
        return !myNewArr[char];
    }).join('');
    
    console.log(result);
}

charRemover(str);