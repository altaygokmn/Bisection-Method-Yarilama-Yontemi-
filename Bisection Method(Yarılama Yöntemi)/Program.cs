using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Method_Yarılama_Yöntemi_
{
    internal class Program
    {
        static float hata = (float)0.01;    //herhangi bir kök ile iterasyon sonucumuzun farkı 0.01 olduğunda işlem sonlanacak.
        //fonksiyonumuz x^3 + 2x^2 + 3
        static double Fonksiyon(double x)
        {
            return x * x * x + 2 * (x * x) + 3;
        }
        static void yarilamaYontemi(double altTaban,double ustTaban)
        {
            if (Fonksiyon(altTaban) * Fonksiyon(ustTaban) >= 0)
            {
                Console.WriteLine("Aralıklar içerisinde bu fonksiyonun kökü bulunmuyor.");
                return;
            }
            double yeniTaban = altTaban;
            while ((ustTaban - altTaban) >= hata)
            {
                yeniTaban = (altTaban + ustTaban) / 2;
                if (Fonksiyon(yeniTaban) == 0.0)
                    break;
                else if (Fonksiyon(yeniTaban)*Fonksiyon(altTaban)<0)
                {
                    ustTaban = yeniTaban;
                }
                else
                {
                    altTaban = yeniTaban;
                }
                Console.WriteLine("Kökün değeri" + yeniTaban);
            }
        }
        static void Main(string[] args)
        {
            double altTaban = -1, ustTaban = 1;
            yarilamaYontemi(altTaban,ustTaban);
            Console.WriteLine("***************************");//aralıkları değiştirdim ki iki farklı sonucu da görelim.
            altTaban = -3; ustTaban = -2;
            yarilamaYontemi(altTaban, ustTaban);
        }
    }
}
