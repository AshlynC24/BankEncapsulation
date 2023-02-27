using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double balance = 0;

		//define a method that will accept a double
		//and store that value in the balance field

		public void Deposit(double amount) //encapsulation 
		{
			balance += amount;
		}

		//define a method named GetBalance that will
		//return the amount stored in the balance feild

		public double GetBalance()
		{
			return balance;
		}
		
	}
}

