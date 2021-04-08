using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRew
{
    class Brus
    {
        public string _navn;
        private int _pris;
        private int _mengde;
        private int _lager;

        public Brus(string navn, int pris, int mengde, int lager)
        {
            _navn = navn;
            _pris = pris;
            _mengde = mengde;
            _lager = lager;
        }

        public bool SjekkLager()
        {
            if (_lager > 0)
            {
                return true;
            }
            return false;
        }
    }
}
