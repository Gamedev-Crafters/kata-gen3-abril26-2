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

	[Test]
	public void FiveReturnsBuzz()
	{
		Assert.AreEqual(FizzBuzz.Of(5), "Buzz");
	}

	[Test]
	public void TenReturnsBuzz()
	{
		Assert.AreEqual(FizzBuzz.Of(10), "Buzz");
	}

	[Test]
	public void FifteenReturnsFizzBuzz()
	{
		Assert.AreEqual("FizzBuzz", FizzBuzz.Of(15));
	}

	[Test]
	public void ThirtyReturnsFizzBuzz()
	{
		Assert.AreEqual("FizzBuzz", FizzBuzz.Of(30));
	}

	[Test]
	public void FourtyFiveRetunsFizzBuzz()
	{
		Assert.AreEqual("FizzBuzz", FizzBuzz.Of(45));
	}
}