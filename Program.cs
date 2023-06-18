using Polymorfizm.Polymorfizm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Polymorfizm
{

    namespace Polymorfizm
    {
        public class Inson
        {
            private int _boy;// bo'yi
            private int _ogirlik;// og'irligi

            public Inson(int boy, int ogirlik)
            {
                this.boy = boy;
                this.ogirlik = ogirlik;
            }

            //Bo'y xossasi
            public int boy
            {
                get { return _boy; }
                set { _boy = value; }
            }

            //Og'irlik xossasi
            public int ogirlik
            {
                get { return _ogirlik; }
                set { _ogirlik = value; }
            }
        }
    }

    namespace Polymorfizm
    {
        abstract public class Hodim : Inson
        {
            abstract public void MaoshOlish(float PulMiqdori);
            //{
            //    Console.WriteLine(PulMiqdori.ToString() + " sum miqdorda olindi. ");
            //}
            private decimal _maosh;

            public decimal Maosh
            {
                get
                {
                    throw new System.NotImplementedException();
                }
                set
                {

                }
            }

            public Hodim(int boy, int ogirlik, decimal maosh)
                : base(boy, ogirlik)
            {
                _maosh = maosh;

            }


        }
    }
    namespace Polymorfizm
    {
        public class Shifokor : Hodim
        {

            public override void MaoshOlish(float PulMiqdori)
            {
                float mukofot = 1000000F;
                PulMiqdori += mukofot;
                Console.WriteLine(PulMiqdori.ToString() + " sum miqdorda olindi. ");
                //base.MaoshOlish(PulMiqdori);
            }
            public Shifokor(int boy, int ogirlik, decimal maosh) : base(boy, ogirlik, maosh)
            {
            }

            public int Tajriba
            {
                get
                {
                    throw new System.NotImplementedException();
                }
                set
                {

                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Inson inson1 = new Inson(180, 80);
            Inson inson2 = new Inson(170, 70);
            inson1.boy = 180;
            //Hodim hodim1 = new Hodim(180, 90, 25000);

            Shifokor shifokor1 = new Shifokor(170, 70, 14000);
            shifokor1.Tajriba = 7;
            shifokor1.MaoshOlish(3000000F);
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

        }
    }



}