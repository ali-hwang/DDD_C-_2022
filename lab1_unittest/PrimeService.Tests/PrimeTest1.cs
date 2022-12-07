namespace Prime.Service.Tests;


[TestFixture]
public class PrimeTest1
{
    private PrimeService  prime = null!;

    [OneTimeSetUp]
    public void Prepare()
    {
        prime = new PrimeService();
        TestContext.Progress.WriteLine("測試 prime 初始化");
    }


    [Test]
    public void test1()
    {
        //PrimeService ps = new PrimeService();
        bool result = prime.IsPrime(1);
        Assert.IsFalse(result,"1 should not prime");
        //Console.WriteLine("new PrimeTest1");
    }
    [Test]
    public void test2()
    {
        //PrimeService ps = new PrimeService();
        bool result = prime.IsPrime(2);
        Assert.IsTrue(result,"2 should be prime");
        //Console.WriteLine("new PrimeTest1");
    }

}