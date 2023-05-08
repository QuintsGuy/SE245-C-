using System;

namespace Personal_Information_Form
{
    public class Customers: PersonV2
    {
        private DateTime _customerSince;
        private double _totalPurchases;
        private bool _discountMember;
        private int _rewardsEarned;

        public DateTime CustomerSince
        {
            get { return _customerSince; }
            set { _customerSince = value; }
        }

        public double TotalPurchases
        {
            get { return _totalPurchases; }
            set { _totalPurchases = value; }
        }

        public bool DiscountMember
        {
            get { return _discountMember; }
            set { _discountMember = value; }
        }

        public int RewardsEarned
        {
            get { return _rewardsEarned; }
            set { _rewardsEarned = value; }
        }
    }
}

