public class Primes 
{
    public static void main(String[] args) throws Exception 
    {
        System.out.println("Hello, World!");

        for(int i = 2; i < 101; i++)
        {
            if(isPrime(i))
            {
                System.out.println(i);
            }
        }
    }

    public static boolean isPrime(int n)
    {
        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
