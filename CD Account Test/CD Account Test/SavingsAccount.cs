﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class SavingsAccount
    {
        // Fields
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;

        public SavingsAccount()
        {
            _accountNumber = "";
            _interestRate = 0;
            _balance = 0;
        }

        public string AccountNumber
        {
            get { return _accountNumber;  }
            set { _accountNumber = value;  }
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
