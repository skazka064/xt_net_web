
 function first(y){
     console.log(1); 
     y();  
}
function second(a,b){
    console.log(a*b);
}
first(function(){}); 
//second(7,4);
