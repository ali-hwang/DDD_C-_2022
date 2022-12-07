namespace Prime.Service.Tests;


[TestFixture]
public class PrimeTest1
{
    [Test]
    public void test1()
    {
        PrimeService ps = new PrimeService();
        bool result = ps.IsPrime(1);
        Assert.IsFalse(result,"1 should not prime");
        //Console.WriteLine("new PrimeTest1");
    }
    [Test]
    public void test2()
    {
        PrimeService ps = new PrimeService();
        bool result = ps.IsPrime(2);
        Assert.IsTrue(result,"2 should be prime");
        //Console.WriteLine("new PrimeTest1");
    }

}