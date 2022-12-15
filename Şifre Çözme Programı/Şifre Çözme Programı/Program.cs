using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şifre_Çözme_Programı
{
    class Program
    {
        public string sifrelepar;
        public string sifrecozpar;
        public string sifrele;

        public string Kendi(string yazıpar)
        {
            sifrele = yazıpar;

            return sifrele;
        }
        public string Sifrele(string yazıpar)
        {

            string sifreSifrele = "";

            foreach (char x in yazıpar)                                       
            {
                
                int sifreleme = (int)x + 1;

                sifreSifrele += (char)sifreleme;               
            
            }

            sifrelepar = sifreSifrele;

            return sifreSifrele;
           
        }


        public string Sifre_Coz(string yazıpar)
        {

            yazıpar = sifrelepar;

            string sifreCoz = "";

            foreach (char a in yazıpar)
            {
                
                int sifreleme = (int)a - 1;

                sifreCoz += (char)sifreleme;

            }

            sifrecozpar = sifreCoz;

            return sifreCoz;
        }

        public void Yaz()
        {
            Console.WriteLine("Alınan Metin : {0} ", sifrele);

            Console.WriteLine("Şifrelenmiş Metin : {0} ", sifrelepar);

            Console.WriteLine("Şifresi Çözüldükten Sonraki Metin : {0} ", sifrecozpar);
        }

        
        static void Main(string[] args)
        {

            Program nesne = new Program();

            Console.Write("Şifrelenmesi için bir yazı yazınız : ");

            string yazı = Console.ReadLine();

            if (yazı.Length == 0)
            {
                Console.WriteLine("Şifrelenecek bir metin yok ya da hatalı giriş ! ");
            }

            nesne.Kendi(yazı);
            
            nesne.Sifrele(yazı);

            nesne.Sifre_Coz(yazı);

            nesne.Yaz();


        }
    }
}
