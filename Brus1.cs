using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRew
{
    class Brus1 : Brus
    {
        private string Test;

        public Brus1(string navn, int pris, int mengde, int lager, string test) : base(navn, pris, mengde, lager)
        {
            Test = test;
        }
    }
}
