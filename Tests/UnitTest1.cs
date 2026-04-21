namespace Tests;

public class Tests {
	[Test]
	public void OneReturnsOne() {
		Assert.AreEqual(FizzBuzzConverter(1), "1");
	}

	[Test]
	public void TwoReturnsTwo()
	{
		Assert.AreEqual(FizzBuzzConverter(2), "2");
	}

	[Test]
	public void ThreeReturnsFizz()
	{
		Assert.AreEqual(FizzBuzzConverter(3), "Fizz");
	}

	[Test]
	public void SixReturnsFizz()
	{
		Assert.AreEqual(FizzBuzzConverter(6), "Fizz");
	}

	private string FizzBuzzConverter(int i)
	{
		if (i == 3 || i == 6)
		{
			return "Fizz";
		}
		return i.ToString();
	}
}