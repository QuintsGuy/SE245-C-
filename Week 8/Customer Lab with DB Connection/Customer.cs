using System;

namespace Customer_Lab
{
    public class Customer: PersonV2
    {
        private DateTime _customerSince;
        private double _totalPurchases;
        private bool _discountMember;
        private int _rewardsEarned;

        public DateTime CustomerSince
        {
            get { return _customerSince; }
            set
            {
                if (Validations.IsNotAFutureDate(value)==false)
                {
                    Feedback += "\nERROR: Cannot enter date before today";
                }
                else
                {
                    _customerSince = value;
                }
            }
        }

        public double TotalPurchases
        {
            get { return _totalPurchases; }
            set
            {
                if (Validations.IsADouble(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Total Purchases must be a number";
                }
                else if (Validations.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Total Purchases must contain atleast one digit";
                }
                else
                {
                    _totalPurchases = value;
                }
            }
        }

        public bool DiscountMember
        {
            get { return _discountMember; }
            set { _discountMember = value; }
        }

        public int RewardsEarned
        {
            get { return _rewardsEarned; }
            set
            {
                if (Validations.IsAnInteger(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Rewards Earned must be an integer";
                }

                if (Validations.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Rewards Earned must contain atleast one digit";
                }
                else
                {
                    _rewardsEarned = value;
                }
            }
        }
    }
}