namespace Project;

public static class FizzBuzz {
	public static string Of(int i)
	{
		if (i % 3 == 0)
		{
			return "Fizz";
		}
		return i.ToString();
	}
}