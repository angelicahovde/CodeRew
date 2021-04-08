using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRew
{
    class BrusAutomat
    {
        public Brus[] Hyller = new Brus[5];
        private BankTerminal bankterminal = new BankTerminal();
        private Comand komando = new Comand();

        public void FyllPåBrus(Brus[] buser)
        {
            var num = 0;
            if (buser.Length <= Hyller.Length)
            {
                num = buser.Length;
            }
            else num = Hyller.Length;

            for (int i = 0; i < num; i++)
            {
                Hyller[i] = buser[i];
            }
        }

        public void PrintLagerBeholdning()
        {
            for (int i = 0; i < Hyller.Length; i++)
            {
                if (Hyller[i] != null)
                {
                   Console.WriteLine(Hyller[i]._navn);
                }
                else
                {
                    Console.WriteLine("Tomt i hylle " + (i + 1));
                }
            }
        }
    }
}
