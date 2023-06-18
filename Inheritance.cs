using Inheritance.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Inheritance
{
    
    namespace Inheritance
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

    namespace Inheritance
    {
        public class Hodim : Inson
        {
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
    namespace Inheritance
    {
        public class Shifokor : Hodim
        {
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
            Console.WriteLine("Hello, World!");
            Inson inson1 = new Inson(180, 80);
            Inson inson2 = new Inson(170, 70);
            inson1.boy = 180;
            Hodim hodim1 = new Hodim(180, 90, 25000);
            hodim1.Maosh = 3000;
            Shifokor shifokor1 = new Shifokor(170, 70, 14000);
            shifokor1.Tajriba = 7;

        }
    }



}