public class TargetTypedExample
{
	public int ShowExample(int? maybeNumber = null, int number = 25)
	{
		int actualNumber = maybeNumber ?? number;
        
		System.Console.WriteLine($"The number is: {actualNumber}");

		return actualNumber;
	}
}