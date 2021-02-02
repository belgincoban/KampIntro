using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager) //herkesin referansını tutar.
        {
            //Basvuran bilgilerini degerlendirme
            //
            
            krediManager.hesapla();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.hesapla();
            }
        }
    }
}
