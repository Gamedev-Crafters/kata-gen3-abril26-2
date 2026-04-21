using Project;

namespace Tests;

public class Tests {
	[Test]
	public void OneReturnsOne() {
		Assert.AreEqual(FizzBuzz.Of(1), "1");
	}

	[Test]
	public void TwoReturnsTwo()
	{
		Assert.AreEqual(FizzBuzz.Of(2), "2");
	}

	[Test]
	public void ThreeReturnsFizz()
	{
		Assert.AreEqual(FizzBuzz.Of(3), "Fizz");
	}

	[Test]
	public void SixReturnsFizz()
	{
		Assert.AreEqual(FizzBuzz.Of(6), "Fizz");
	}
}