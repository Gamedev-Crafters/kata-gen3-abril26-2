namespace Tests;

public class Tests {
	[Test]
	public void OneReturnsOne() {
		Assert.AreEqual(FizzBuzz.FizzBuzzConverter(1), "1");
	}

	[Test]
	public void TwoReturnsTwo()
	{
		Assert.AreEqual(FizzBuzz.FizzBuzzConverter(2), "2");
	}

	[Test]
	public void ThreeReturnsFizz()
	{
		Assert.AreEqual(FizzBuzz.FizzBuzzConverter(3), "Fizz");
	}

	[Test]
	public void SixReturnsFizz()
	{
		Assert.AreEqual(FizzBuzz.FizzBuzzConverter(6), "Fizz");
	}
}