using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


