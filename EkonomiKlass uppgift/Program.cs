using System.Collections.Generic;

using System;

namespace EkonomiKlass_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounting accing = new Accounting();
            accing.CreateTransaction(1910, 0, 5000);
            accing.CreateTransaction(2440, 5000, 0);

            double debit = 0;
            double credit = 0;  

            foreach (var trans in accing.Transactions)
            {
                Console.WriteLine(trans);
                debit += trans.debit;
                credit += trans.credit;

                Console.WriteLine("Summa Debet :        " + debit);
                Console.WriteLine("Summa Kredit:        " + credit);
                Console.WriteLine("Resultat skillnad:   " + (debit - credit));
            }


        }


    }
}
