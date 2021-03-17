
public int getFibonacciByIndex (int index){
    int lastFivonacci = 0;
    int newFivonacci = 0;
    int auxiliar = 0;

    if(n < 0)
        throw new Exception("The index cannot be less than 0");

    for (i = 0; i < index; i++){
        if(newFivonacci = 0)
            newFivonacci = 1;
            
        auxiliar = newFivonacci;
        newFivonacci = lastFivonacci + newFivonacci;
        lastFivonacci = auxiliar;
    }

    return newFivonacci;
}