﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Bone
    {
        public int Number { get; set; }
        public int First { get; set; }
        public int Second { get; set; }
        public int Summa { get; set; }
        public Bone (int number)
        {
            Random randon = new Random();
            Number = number;
            First = randon.Next(1, 7);
            Second = randon.Next(1, 7);
            Summa = First + Second;
        }
    }
}
