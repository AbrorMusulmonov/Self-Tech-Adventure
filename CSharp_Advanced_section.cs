//Delegate topics


/*
using Delegate.Delegate;

namespace Delegate
{
    namespace Delegate
    {
        class Pul
        {
            public double Miqdor { get; set; }  //Pul miqdori
            public string Valyuta { get; set; } //Valyuta turi
            public Pul(double miqdor)
            {
                Miqdor = miqdor;
                Valyuta = "UZS";
            }
            public delegate void PulDelegate(Pul pul);
        }



    }

    namespace Delegate
    {
        class Pulboshqaruvchi
        {
            ///<summary>
            ///So'mdan aqsh dollariga o'giradi:
            /// </summary>
            /// <param name="pul"></param>

            public void UZS2USD(Pul pul)
            {
                pul.Valyuta = "$";
                pul.Miqdor /= 11400;
            }
            ///<summary>
            ///So'mga aqsh dollaridan o'giradi:
            /// </summary>
            /// <param name="pul"></param>

            public void USD2USZ(Pul pul)
            {
                pul.Valyuta = "$";
                pul.Miqdor *= 11400;
            }

            public void Sending(Pul pul, string bank, Pul.PulDelegate delegat)
            {
                if (delegat.Target != null)
                    delegat(pul);

                Console.WriteLine(pul.Miqdor.ToString("0.00") + " " + pul.Valyuta + " miqdoridagi pul " + bank + " bankiga muvaffaqiyatli o'tkazildi. ");
            }

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Pul pul = new Pul(10000000);
            Pulboshqaruvchi pulBoshqaruvchi = new Pulboshqaruvchi();
            Pul.PulDelegate delegat = new Pul.PulDelegate(pulBoshqaruvchi.UZS2USD);
            pulBoshqaruvchi.Sending(pul, "VD", delegat);
            Console.WriteLine(delegat.Method.Name);   //Delegat korsatkich bolgan methodni aniqlashimiz mumkin!
            Console.ReadLine();




        }
    }
}*/