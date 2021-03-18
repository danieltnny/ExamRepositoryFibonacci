using System;

public class FibonacciService : IFibonacciService
{
    public int getFibonacciByIndex_v1 (int index){
        try{
            int lastFivonacci = 0;
            int newFivonacci = 1;
            int auxiliar = 0;

            if(index < 0)
                throw new Exception("The index cannot be less than 0");

            if(index == 0 || index == 1)
                return index;

            for (int i = 1; i < index; i++){
                auxiliar = newFivonacci;
                newFivonacci = lastFivonacci + newFivonacci;
                lastFivonacci = auxiliar;
            }

            return newFivonacci;
        }
        catch(Exception ex){
            throw ex;
        }
    }
    public int getFibonacciByIndex_v2 (int index){
        try{
            if(index < 0)
                throw new Exception("The index cannot be less than 0");

            if(index == 0 || index == 1)
                return index;
            else
                return getFibonacciByIndex_v2(index - 1) + getFibonacciByIndex_v2(index - 2);

        }
        catch(Exception ex){
            throw ex;
        }
    }
}