﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_test
{
    internal class Figure
    {
        public bool colored = false;

        public bool Colored
        {
            get
            {
                return colored;
            }

            set
            {
                colored = value;
            }
        }
    }
}
