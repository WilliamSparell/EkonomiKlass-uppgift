using System.Collections.Generic;

using System;

namespace EkonomiKlass_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Account> transactions = new List<Account>();

            //Account acc = new Account();
            //acc.Number = 1910;
            //acc.Label = "Kassa";
            //acc.credit = 5000;

            //transactions.Add(acc);
            //acc = new Account();
            //acc.Number = 2440;
            //acc.Label = "Lev.skuld";
            //acc.debit = 5000;

            //transactions.Add(acc);

            Accounting accing = new Accounting();
            accing.CreateTransaction(1910, 0, 5000);
            accing.CreateTransaction(2440, 5000, 0);

            double debit = 0;
            double credit = 0;  

            foreach (var trans in accing.Transactions)
            {
                Console.Write("Konto:               " + trans.Number + " " + trans.Label);
                Console.Write(" " + trans.debit);
                Console.WriteLine(":" + trans.credit);
                debit += trans.debit;
                credit += trans.credit;

                Console.WriteLine("Summa Debet :        " + debit);
                Console.WriteLine("Summa Kredit:        " + credit);
                Console.WriteLine("Resultat skillnad:   " + (debit - credit));
            }


        }


    }
}
