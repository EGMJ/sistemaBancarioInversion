﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    interface AmountInterest
    {
        decimal Amount
        {
            set;
        }

        double AnnualInterest
        {
            get;
        }
    }
}
