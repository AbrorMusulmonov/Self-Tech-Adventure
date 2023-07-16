using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//OOP-Section
Following topic:
    { Abstraction_and_Encupsulation | Inheritance | Polymorfizm | Interface }



//11.2-Abstraction_and_Encupsulation
/*
  
using Abstraction_and_Encupsulationn.Abstraction_and_Encupsulation;


namespace Abstraction_and_Encupsulationn
{


    namespace Abstraction_and_Encupsulation
    {
        //class Abituriyent
        //{

        //    private int bal;
        //    public int GetBal()
        //    {
        //        return bal;
        //    }
        //    public void SetBal(int b)
        //    {
        //        if ((b > 0) && (b < 101))
        //        {
        //            this.bal = b;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Ball noto'g'ri kiritildi! ");
        //        }

        //    }
        //}

        class Abituriyent
        {
            //ichki ball maydoni
            private int bal;
            //Bal xossasi (public ko'rinish doirasida)
            public int Bal
            {
                //get maydonidan ichki ball maydonini qiymati qaytariladi(getter)
                get
                {
                    return bal;
                }
                //set maydonidan ichki bal maydoniga qiymat belgilanadi(setter)
                set
                {
                    if ((value > 0) && (value < 101))
                    {
                        this.bal = value;
                    }
                    else
                    {
                        Console.WriteLine("Ball noto'g'ri kiritildi! ");
                    }

                }
            }
            public static void register() //static methodlar
            {

            }
            public void takeExam()
            {

            }

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Abituriyent klasiga mansub abit obektini e'lon qilamiz:
            Abituriyent abit = new Abituriyent();
            //abit obyektini Ball xossasiga ko'ra 90 qiymatini belgilaymiz:
            abit.Bal = 90;
            //abit obyektini Ball xossasiga ko'ra konsolga chiqaramiz:
            Console.WriteLine(abit.Bal);
            //abit obyektini Ball xossasiga ko'ra 120 qiymatini belgilaymiz:
            abit.Bal = 120;
            // Console.WriteLine(abit.Bal);
            Console.Read();
            abit.takeExam();//dynamic method-ordinary method
            Abituriyent.register();//static method
            //Abstraction_and_Encupsulation - buning asosiy vazifasi user uchun faqat kerakli qismlarni ko'rsatishdan iboratdir//
        }
    }

}*/



//11.3-Inheritance

/*
using Inheritance.Inheritance;


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
*/

//11.4 - Polymorfizm


/*
using Polymorfizm.Polymorfizm;



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

}*/

//11.5 - Interface


/*
using Interface.Interface;

namespace Interface
{
    namespace Interface
    {
        public interface INafasOluvchi
        {
            string NafasOlishAzosi
            {
                get;

            }
            void NafasOlish();

        }
    }

    namespace Interface
    {
        public class Baliq : INafasOluvchi
        {
            #region INafasOluvchi Members
            public string NafasOlishAzosi
            {
                get
                {
                    return "Jabra";
                }
            }
            public void NafasOlish()
            {
                Console.WriteLine("Nafas Oldi");
            }
            #endregion
        }
    }

    namespace Interface
    {
        public class Inson : INafasOluvchi
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

            #region INafasOluvchi Members
            public string NafasOlishAzosi
            {
                get
                {
                    return "Burn";
                }
            }
            public void NafasOlish()
            {
                Console.WriteLine("Nafas Olindi");
            }
            #endregion
        }
    }

    namespace Interface
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
    namespace Interface
    {
        public class Shifokor : Hodim, ICloneable
        {

            public override void MaoshOlish(float PulMiqdori)
            {
                float mukofot = 1000000F;
                PulMiqdori += mukofot;
                Console.WriteLine(PulMiqdori.ToString() + " sum miqdorda olindi. ");
                //base.MaoshOlish(PulMiqdori);
            }

            object ICloneable.Clone()
            {
                throw new NotImplementedException();
            }
            public object Clone()
            {
                return new Shifokor(boy, ogirlik, maosh);
            }

            public string Ism
            {
                get;
                set;

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

            public decimal maosh { get; private set; }
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
            shifokor1.Ism = "Abror";
            shifokor1.Tajriba = 7;
            shifokor1.MaoshOlish(3000000F);
            Console.WriteLine("Hello, World!");
            shifokor1.NafasOlish();
            Console.WriteLine(shifokor1.Ism + " akamizning nafas olish azosi - " + shifokor1.NafasOlishAzosi);

            Baliq baliq1 = new Baliq();
            baliq1.NafasOlish();
            Console.WriteLine("Baliqning nafas olish azosi - " + baliq1.NafasOlishAzosi);

            Shifokor shifokor2 = (Shifokor)shifokor1.Clone();
            shifokor2.Ism = "Yunus";
            Console.WriteLine(shifokor1.Ism);
            Console.WriteLine(shifokor2.Ism);

            Console.ReadKey();

        }
    }



}*/
