namespace Tests;

public class Tests {
	[Test]
	public void OneReturnsOne() {
		Assert.AreEqual(asdoifuh(1), "1");
	}

	[Test]
	public void TwoReturnsTwo()
	{
		Assert.AreEqual(asdoifuh(2), "2");
	}

	[Test]
	public void ThreeReturnsFizz()
	{
		Assert.AreEqual(asdoifuh(3), "Fizz");
	}

	private string asdoifuh(int i)
	{
		if (i == 3)
		{
			return "Fizz";
		}
		return i.ToString();
	}
}