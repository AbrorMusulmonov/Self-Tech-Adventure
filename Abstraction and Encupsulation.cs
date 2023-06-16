using Abstraction_and_Encupsulationn.Abstraction_and_Encupsulation;

namespace Abstraction_and_Encupsulationn
{

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
            /*Abstraction_and_Encupsulation - buning asosiy vazifasi user uchun faqat kerakli qismlarni ko'rsatishdan iboratdir*/
        }
    }

    namespace Abstraction_and_Encupsulation
    {
        /*class Abituriyent
        {

            private int bal;
            public int GetBal()
            {
                return bal;
            }
            public void SetBal(int b)
            {
                if ((b > 0) && (b < 101))
                {
                    this.bal = b;
                }
                else
                {
                    Console.WriteLine("Ball noto'g'ri kiritildi! ");
                }

            }
        }*/

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
}