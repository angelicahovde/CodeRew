using System;

namespace CodeRew
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pepsi = new Brus1("pepsi", 19, 500, 5, "Brus er godt");
            var Fanta = new Brus1("fanta", 19, 500, 5, "Brus er godt");
            var Solo = new Brus1("solo", 19, 500, 5, "Brus er godt");
            var ListeMedBrus = new Brus[] {Pepsi, Fanta, Solo};
            var BrusAutomat = new BrusAutomat();
            BrusAutomat.FyllPåBrus(ListeMedBrus);
            BrusAutomat.PrintLagerBeholdning();
        }
    }
}


/*OPPGAVE:
    Implementer en brusautomat.Ulike drikker har ulik pris. Automaten har en lagerbeholdning.
    Man kan putte på mynter (1kr, 5kr, 10kr, 20kr).
    Man trykker på en knapp for en bestemt drikk - hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
    Det finnes en knapp for å få gjeldende saldo tilbake.*/