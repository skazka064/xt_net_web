var str = '3.5 +4*10-5.3 /5 =';
var regex = /(\d+\.\d+)|(\d+)|(\+|\-|\/|\*|\=)/g;
var items = str.match(regex);
var res = parseFloat(items[0]);
for(var i =0; i< items.length;i++){
    switch(items[i]){
        case "+":
            {
                res += parseFloat(items[i + 1]);
            }
        break;
        case "-":
            {
                res-=parseFloat(items[i+1])
            }
            break;
        case "*":
        {
            res *= parseFloat(items[i+1])
        }
        break;
        case"/":
        {
            res /= parseFloat(items[i+1])
        }
        break;
        case "=":
        {
          res = res.toFixed(2);
          console.log(res);
        }
        break;


    }

    
}

