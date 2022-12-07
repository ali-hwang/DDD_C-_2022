namespace Prime.Service.Tests;

public class Test
{
    [OneTimeSetUp]
    public void init()
    {
        TestContext.Progress.WriteLine("one time init");
    }

    [OneTimeTearDown]
    public void final()
    {
        TestContext.Progress.WriteLine("one time final");
    }


    [SetUp]    
    public void Setup()
    {
        Console.WriteLine("測試初始環境");
    }

[TearDown]
    public void CleanEnv()
    {
        Console.WriteLine("測試完畢 清理環境");
    }

    [Test]
    public void Test1()
    {
        //Assert.Pass();
        Console.WriteLine("test 1");
    }
    [Test]
    public void Test12()
    {
        //Assert.Fail("new fail");
        Console.WriteLine("test 2");
    }
}