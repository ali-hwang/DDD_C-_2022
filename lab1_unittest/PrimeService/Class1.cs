using System;
namespace Prime.Service;
public class PrimeService
{
    public bool IsPrime(int number)
    {
        
        
        

        if (number == 1)
        {
            return false;
        }
        else// if (number == 2)
        {
            for (int n=2;n<number/2 ; n++)
        {
            if (number % n ==0)
            {
                return false;
            }
        }
        return true;
            //return true;
        }
        throw new NotImplementedException("not yet implement");
    }
}
