// Implementing an Interface

public class Customer: ILoyaltyCardHolder
	{
		private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints;}
        }
		public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
        }
        public void ResetPoints()
        {
            totalPoints = 0;
        }

        // Other members of the Customer class.	
}