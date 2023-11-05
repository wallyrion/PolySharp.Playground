using System;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	public class PropertyPatternMatchingExample
	{

		public int Test()
		{
			var payment = GetPayment();

			if (payment is { Type: PaymentType.Visa, Amount: 100 })
			{
				Console.Write("Test");
			}
			
			return payment switch
			{
				{ Type: PaymentType.Visa, Amount: 100, Card: {Location: "us"} } => 100,
				{ Type: PaymentType.MasterCard, Amount: 100 } => 200,
				_ => 0,
			};
		}

		private Payment GetPayment()
		{
			return new Payment
			{
				Type = PaymentType.Visa,
				Amount = 100,
				Card = new Card()
				{
					Number = "1234",
					Location = "US"
				}
			};
		}
		

		private class Payment
		{
			public PaymentType Type { get; set; }
			public int Amount { get; set; }
			public Card Card { get; set; } = null!;
		}

		private class Card
		{
			public string Number { get; set; } = null!;
			public string Location { get; set; } = null!;
		}

		private enum PaymentType
		{
			Visa,
			MasterCard,
		}
	}
	
	
}