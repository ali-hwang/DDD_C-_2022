using System;
namespace Prime.Service;
public class PrimeService
{
    public bool IsPrime(int number)
    {
        /*
        for (int n=0;n<number/2 ; n++)
        {
            if (number % n ==0)
            {
                re
            }
        }
        */

        if (number == 1)
        {
            return false;
        }
        else if (number == 2)
        {
            return true;
        }
        throw new NotImplementedException("not yet implement");
    }
}
