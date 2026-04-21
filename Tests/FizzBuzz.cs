namespace Tests;

public static class FizzBuzz {
	public static string FizzBuzzConverter(int i)
	{
		if (i % 3 == 0)
		{
			return "Fizz";
		}
		return i.ToString();
	}
}