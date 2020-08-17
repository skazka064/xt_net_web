function removeDuplicate(str)
{    
    var words = new Array();
    var a = new Array();
    var b = new Array();
    words = str.split(" ");
     
   var a = words[0].split("");
   var b =  words[1].split("");
   var res1 = a[0];
    for(var i=1; i<a.length;i++){
        for(var j=0; j<b.length;j++){
            if(a[i]==a[j]){
                 res1 += a[i];
            }
        }
    }
    return res1;
   

}

console.log(removeDuplicate("У попа была собака"));