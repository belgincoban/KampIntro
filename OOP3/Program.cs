using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //interface lerde referans numarasını tutarlar.


            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasıtKrediManager* };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
