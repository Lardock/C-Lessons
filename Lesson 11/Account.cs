using System;

namespace Lesson11
{
    class Account
    {
        private string userName;
        private decimal userbalance;
        public string UserCountry { get; set; }
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public decimal UserBalance
        {
            get
            {
                return userbalance;
            }
            set
            {
                userbalance = value;
            }
        }

        public Account()
        {
            Console.WriteLine("Enter Your First Name");
            UserName = Console.ReadLine();
            Console.WriteLine("Enter Your balance");
        SetBalance:
            try
            {
                UserBalance = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid value!");
                goto SetBalance;
            }
            Console.WriteLine("Enter Your country");
            UserCountry = Console.ReadLine();

        }
        public void ShowAccountData()
        {
            Console.WriteLine(new String('=',20));
            Console.WriteLine($"First name: {UserName} | Your Balance: {UserBalance}");
            Console.WriteLine(new String('=', 20));
        }
    }

    class AccountExtraData : Account
    {
        public string UserSex { get; set; }
        public string UserPhoneNumb { get; set; }

        public void AccountExtraDataSet()
        {
            Console.WriteLine("Enter Your gender");
            UserSex = Console.ReadLine();
            Console.WriteLine("Enter Your phone");
            UserPhoneNumb = Console.ReadLine();
        }
        public void ShowAccountExtraData()
        {
            Console.WriteLine($"Your gender: {UserSex} | Your phone: {UserPhoneNumb}");
        }
    }
}
