﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Dealer_TwentyOne : Dealer
    {
        public bool Stay { get; set; }
        public List<Card> Hand { get; set; }
        public bool Busted { get; set; }
    }
}
