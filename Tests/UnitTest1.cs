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

	private string asdoifuh(int i)
	{
		return i.ToString();
	}
}