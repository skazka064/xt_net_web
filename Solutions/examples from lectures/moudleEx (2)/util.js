(function(){

    const BURGER_CONST = 3.76845;
    
    const mineBitcoin = () => {
        return 10*BURGER_CONST;
    }
    
    const calculateCal = (price) => {
        return price*2/BURGER_CONST;
    }

    window.mineBitcoin = mineBitcoin;
    window.calculateCal = calculateCal;
    
}())