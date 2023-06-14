using System.Collections;
using System.Globalization;
using System.Text;
using System.Text.Encodings.Web;


namespace General_Farkhod_Dadajonov_tutorials 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*about tutorial: 
             * These topics were written by Farkhod Dadajonov in 2010 year.
             * I am intersted in these videos and I downloaded these tutorial from Youtube channel of Farkhod Dadajonov.
             * I would apprecieted Farkhod bro's labour in coding content creator 
            */

            // Following code from zero(Hello world) to OOP section


            //Lesson_1-Hello world
            /*
            //Konsolga text chiqaramiz
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Davom etish uchun istalgan tugamani bosing!");
            //Konsoldan tugma bosilishini kutadi
            Console.ReadKey();*/

            //Lesson_2-Kelib chiqishi mumkin bolgan xatolar
            /*
            int Yosh;

            try
            {
                //Foydanuvchi yoshini so'rash
                Console.WriteLine("Yoshingizni kiriting: ");
                Yosh = Convert.ToInt32(Console.ReadLine());
                //Kiritilgan yoshga qaeab,javob ko'rsatilish
                if (Yosh <= 12)
                {
                    Console.WriteLine("Siz hali balogatga yetmabsiz");
                }
                else
                {
                    Console.WriteLine("Xush kelibsiz");
                }
                Console.WriteLine("Davom etish xohlagan tugmani kiriting");
                Console.ReadKey();

            }
            catch(DivideByZeroException dex)
            {

            }
            catch (Exception ex)
            {
                //Konsolga xatolik haqida ma'lumot beramiz
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            */
            /*try catch metodida catch(Exception) bu yuzaga keladigan barcha xatoliklar uchun ishlatamiz.
            Agar biz vujudga keladigan xatoni bilsak,uni uchun maxsus metodlarni ishlatamiz 
            catch(DivideByZeroException dex) bu 0 ga bo'lish mumkin emas */

            //Lesson_3-O'zgaruvchilar
            /*
            //Buni sababi method bolgani uchun main functiondan tashaqariga yozilgan
            static void OzgaruvchiYashashDavri()
            {
                int miqdorJami = 10;
                miqdorJami = miqdorJami + 10;
                //MiqdorJami+=10 // deb yozsak ham bo'ladi
            }
            static int miqdorJami;

            static void OzgaruvchiSkopi()
            {
                miqdorJami = 100;

            }*/
            //Lesson_3-O'zgaruvchilar davomi

            /*
             
            Int32 int320zg = 650000;
            Int64 int640zg;
            int640zg = int320zg;
            Console.WriteLine(int640zg);
            Console.ReadKey();

            short short0zg = 10;
            int int0zg1 = 50;
            short0zg = (short)(short0zg + int0zg1);
            Console.WriteLine(short0zg);
            Console.ReadKey();

            int int0zg2 =5;
            string str0zg1=string.Empty;
            str0zg1 = Convert.ToString(int0zg2);
            Console.WriteLine(str0zg1); 
            Console.ReadKey();

            string str0zg2 = "70";
            int int0zg3 = 0;
            int0zg3 = int.Parse(str0zg2);
            Console.WriteLine(int0zg3);
            Console.ReadKey();

            
            bool entervalue = false;
            float num = 0;
            Console.WriteLine("Hisobingizdan qancha pul yechib olinsin");
            string text = Console.ReadLine();
            entervalue = float.TryParse(text, out num);
            if (entervalue)
            {
                Console.WriteLine(string.Format("{0}-pul miqdori hisobingizdan yechib olindi", text));
            }
            else
            {
                Console.WriteLine("Pul miqdori noto'gri kiritildi");
                entervalue = false;
            }
            Console.ReadKey();

            const string about = "Dastur haqida";
            const int oylar = 12, haftalar = 52, kunlar = 365;

            Console.WriteLine(about + Environment.NewLine + oylar + haftalar + kunlar);
            Console.ReadKey(); */


            //Lesson_4-Arifmetik operatorlar

            /*
            int i = 2;
            int j = 3;
            int k = i + j;
            int m;
            m = k * i - 1;
            Console.WriteLine(m);
            Console.ReadKey();

            int w = 7;
            w += 1;   //w=w+1;
            w -= 2;   //w=w-2;
            w *= 3;   //w=w*3;
            w /= 2;   //w=w/2;
            w %= 4;   //w=w%4;

            string a = "Assalomu";
            string b = " ";
            string c = "Alaykum";
            Console.WriteLine(a + b + c);
            Console.ReadKey();


            bool a = true;
            bool b = false;
            if (a == b)
                Console.WriteLine("O'zgaruvchilar qiymati bir xil ya'ni a=b!");
            else
                Console.WriteLine("O'zgaruvchilar qiymati teng emas ya'ni a=!b !");
            Console.ReadKey();

            bool a = true;
            bool b = true;
            if (a)
                Console.WriteLine("a-haqiqat");
            else
                Console.WriteLine("a-yolgon");


            if (!b)
                Console.WriteLine("b-haqiqat");
            else
                Console.WriteLine("b-yolgon");
            Console.ReadKey();

            int b = 10;
            int s = 20;

            if ((b == 10) && (s == 20))
                Console.WriteLine("b=10 va s=20");
            else
                Console.WriteLine("Yolgon");
            Console.ReadKey();

            !A - inkor manosida
             A && B - va bildiradi
             A || B - yoki bildiradi*/


            //Lesson_5 -Shartli operatorlar

            /*string user=string.Empty;
            Console.WriteLine("Please you should enter your name for using programm");
            user=Console.ReadLine();
              
            if(user=="Admin")
                Console.WriteLine("Welcome our program,BOSS !");
            else if(user=="Teacher")
                Console.WriteLine("Welcome to education dashboard");
            else
                Console.WriteLine("Welcome, " + user + " !");
            Console.ReadKey();*/

            //int num = 0;
            //Console.WriteLine("Please write from 1 to 5 numbers! ");
            //char enternum = Console.ReadKey().KeyChar;
            //int.TryParse(enternum.ToString(), out num);
            //Console.WriteLine(Environment.NewLine);
            //switch(num)
            //{       case 1:
            //        Console.WriteLine("Bir");
            //        break;
            //        case 2:
            //        Console.WriteLine("Ikki");
            //        break ;
            //        case 3:
            //        Console.WriteLine("Uch");
            //        break;
            //        case 4:
            //        Console.WriteLine("Tort");
            //        break;
            //        case 5:
            //        Console.WriteLine("Besh");
            //        break;
            //        default:
            //        Console.WriteLine("Bunday son tizimda mavjud emas");
            //        break;
            //}

            /*
            //Lesson_6 - Loop-sikl operatorlari

            //// for loop exe 1
            //for(int i = 0; i <=4; i++)
            //    Console.WriteLine(i.ToString());


            //// foor loop exe 2
            //string[] array = { "Xush kelibsiz!", "Welcome!", "HALLO!" };
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            ////While loop exe 3
            //int[] arrayw = {0,1,2,3,4,5,6,7};
            //int x = 0;
            //while (x < 8)
            //{
            //    Console.WriteLine(arrayw[x].ToString());
            //    x++;
            //}

            ////While loop exe 4
            //string keyword=string.Empty;
            //while(keyword != "PA$$WORD")
            //{
            //    Console.WriteLine("Please, enter the special password!");
            //    keyword = Console.ReadLine();
            //    if (keyword != "PA$$WORD")
            //    {
            //        Console.WriteLine("Keyword is not match our programm password! ");
            //    }
            //    else
            //        Console.WriteLine("Welcome to our programm! ");
            //}

            ////do-while loop exe 5

            //int[] arrayd = { 0, 1, 2, 3 };
            //int k = 0;

            //do
            //{
            //    Console.WriteLine(arrayd[k].ToString());
            //    k++;

            //} while (k <= 2);



            ////do-while loop exe 6
            //Console.WriteLine("Please,Enter keyword : ");
            //ConsoleKeyInfo ki;
            //StringBuilder sb=new StringBuilder();
            //do
            //{
            //    ki = Console.ReadKey(true);
            //    if (ki.Key != ConsoleKey.Backspace)
            //    {
            //        sb.Append(ki.KeyChar);
            //        Console.Write("*");
            //    }
            //    else
            //    {
            //        sb.Remove(sb.Length - 1, 1);
            //        Console.Write("\b \b");
            //    }
            //} while (ki.Key != ConsoleKey.Enter);
            //    Console.WriteLine();
            //    Console.Write(" Your password " + sb);


            ////foreach loop exe 7

            //string[] arrayf = { "acer", "Dell", "Lenova", "hp", "asus", "samsung", "lg","msi","toshiba","sony","tesla" };
            
            //foreach(string s in arrayf)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();
            */


            //Lesson_7 - O'tish Operatorlari(break,continue,goto,return,throw)


            //Break operatori-exe 1

            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i==5) break;
            //    Console.WriteLine(i);   
            //}


            //Continue operatori exe 2

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i < 9) continue;
            //    Console.WriteLine(i);
            //}


            // goto operatori  exe 3

            //    for(int i = 1; i <=10; i++)
            //    {
            //        for (int j = 1; j <=5; j++)
            //        {
            //            for(int k = 1; k <=5; k++)
            //            {
            //                Console.WriteLine(k);
            //                if (k == 5)
            //                goto con;          //jump belgisiga sakrash
            //            }
            //            Console.WriteLine(j);
            //        }
            //        Console.WriteLine(i);   
            //    }
            //con: Console.WriteLine("Bu yerga goto operatori yordamida o'tildi! ");
            //}

            //goto-operatori exe4

            //string statusCode = "Ogoh";

            //switch (statusCode)
            //{
            //    case "Ogoh":
            //        Console.WriteLine("Ogohlantirish bilan tamomlandi. ");
            //        goto case "Tamomlandi";
            //    case "Xato":
            //        Console.WriteLine("Xato bilan tamomlandi. ");
            //        goto case "Tamomlandi";
            //    case "Tamomlandi":
            //        Console.WriteLine("Tamomlandi. ");
            //        break;
            //    case "Barbod":
            //        Console.WriteLine("Barbod bo'ldi. ");
            //        break;
            //    default:
            //        Console.WriteLine("Noaniq kod");
            //        goto case "Barbod";
            //}


            //return operatori exe5

            //int harajatlar = 5000, ustigaQoyildi = 500, adadi = 1100;
            //int natija = FoydaniHisoblash(harajatlar, ustigaQoyildi, adadi);
            //Console.WriteLine("Olingan foyda: " + natija + "so'm. ");

            //static int FoydaniHisoblash(int harajat, int ustigaQoyildi, int adad)
            //{

            //    return (ustigaQoyildi * adad) - harajat;

            //}

            //throw operatori exe6 

            //try
            //{
            //    Hisobla();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Catch bloki ishga tushdi va xatolikka olib keldi. XATO: "+Environment.NewLine+ex.Message);
            //}
            //static void Hisobla()
            //{
            //    int x = 7;
            //    throw new Exception("10chi raqam xato! ");
            //}

            //Yana bir tanlash operatori -turnary exe7

            //int a = 3;
            //string result=string.Empty;
            //result = (a == 5) ? "A'lo" : "A'lo emas";
            //Console.WriteLine(result);

            //Console.ReadKey();


            //Lesson_8 - Methods (prodsedura va funksiya)


            //WritingString("Assalomu alaykum!");



            //string a = ReturnString("Assalomu alaykum", " Hurmatli mijoz");
            //Console.WriteLine(a);



            //Begin();


            //int int0zg = 5;
            //Console.WriteLine(int0zg);
            //Ikkobarobar(ref int0zg);
            //Console.WriteLine(int0zg);

            //exe 1 

            //    //Protsedura 
            //    static void  WritingString(string a )  //parameter string a
            //    {
            //        Console.WriteLine(a+"! ");   
            //    }

            //    //funksiya
            //    static string ReturnString(string a, string b)  //parameter string a, string b
            //    {
            //        return a + b;
            //    }



            //    //exe2

            //    static void Begin()
            //    {
            //        string word=Console.ReadLine(); 
            //        Console.WriteLine("Siz {0} deb yozdingiz",word.Reverse());
            //    }


            ////exe3
            //static void Ikkobarobar(ref int int0zg)  // ref - bu yerda korsatkich vazifasida ishlaydi
            //{
            //  int0zg = int0zg * 2;
            //}


            //Lesson_9  -Arrays(Massivlar)


            // exe 1
            //int[] array1 = new int[5];
            //Console.WriteLine(array1[0].ToString());

            //exe 2
            //string[] array2 = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba" };
            //string[] array3 = new string[] { "Dushanba", "Seshanba", "Chorshanba", "Payshanba" };
            //Console.WriteLine(array2[2]);
            //Console.WriteLine(array3[3]);


            //exe 3
            //int[] array4;
            //Console.WriteLine("Array qiymatlarini kiriting: " );
            //int i;
            //i=int.Parse(Console.ReadLine());
            //array4 = new int[i];

            //for (int j=1;j<i;j++)
            //{
            //    array4[j] = j;
            //}
            //array4[1] = 7;
            //foreach (int k in array4)
            //    Console.WriteLine(k.ToString());



            //exe 4
            //int[] array5 = { 1, 7, 13 };
            //int[] array6;
            //array6 = array5;
            //array6[1] = 9;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(array6[i].ToString());
            //    Console.WriteLine(array5[i].ToString());   
            //}


            //// exe 5
            //int[,] array7;
            //float[,,] array8;
            //array7 =new int[7, 7];
            //array8 = new float[5, 4, 7];
            //array7[4, 3] = 404;

            ////exe 6
            //int[,] array9 = new int[9, 9];
            //for(int k=0; k<9; k++)
            //{
            //    for(int i=0; i<9; i++)
            //    {
            //        array9[k, i] = k*i;
            //        Console.WriteLine(array9[k, i].ToString());
            //    }
            //}


            //exe 7 
            //int[,] array10 = { { 1, 2, 3 }, { 4, 5, 6, } };

            //exe 8

            //string[] array11 = { "C#", "java", "delphi", "vb","c++","Python","Angular","Javascript","Php" };
            //foreach (string a in array11)
            //    Console.WriteLine(a);

            //Array.Sort(array11);

            //foreach (string a in array11)
            //    Console.WriteLine(a);


            ////exe 9

            //string words = "Ushbu so'zlar bir biridan bo'sh joy yordamida ajratiladi. ";
            //char breaker = Convert.ToChar(' ');
            //string[] wordsArray=words.Split(breaker);
            //foreach(string word in wordsArray)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadKey();


            //Lesson_10 -Umumlashmalar(Generics)
            

            //ArrayList-o'zgaruvchan massivlar
            //ArrayList klasi- System.Collections nomlar makonida joylashgan.
            
            /*
            //ARRAYLIST 

            //Yangi ArrayList e'lon qilish:
            ArrayList alist=new ArrayList();


            //ArrayListga yangi element qo'shish
            alist.Add("One");
            alist.Add("Two");
            alist.Add("Four");

       
            //ArrayListni orasidagi yangi element kiritish(indeks yordamida):

            alist.Insert(2, "Three");
            foreach(string s in alist)
            {
                Console.WriteLine(s);
            }

            //ArrayList elementlari sonini aniqlash:
            Console.WriteLine("ArrayListdagi elementlar soni: " + alist.Count);

            //ArrayListdagi ikkinchi elementini o'chirish:
            alist.RemoveAt(1);
            foreach(string item in alist)
            {
                Console.WriteLine(item);
            }


            //ArrayListni tozalash(Barcha elementlarini o'chirib yuborish):
            alist.Clear();
            foreach(string item in alist)
            {
                Console.WriteLine($"ArrayListdagi elementlar soni: {item}");
            }
            Console.ReadKey();
            */

            /*List<T> ro'yxati
             List<T> klasi- System.Collections.Generic nomlar makonidda joylashgan! */
            /*
            //Yangi ro'yxat e'lon qilish:
            List<int> list = new List<int>();

            //Yangi list e'lon qilish (o'lchami avvaldan ko'rsatilgan);
            List<int> list2 = new List<int>(10);

            //Ro'yxat oxiriga yangi element qo'shish:
            list.Add(1);
            list.Add(5);
            list.Add(7);
            list.Add(11);
            list.Add(3);
            
            foreach (int i in list)
            { 
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************************************************");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("*************************************************************");

            //Ro'yxat orasiga yangi element qo'shish (index yordamida):
            list.Insert(4,9);
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*************************************************************");

            //Ro'yxatni tartiblash(Sartirovka) qilish:
            list.Sort();
            foreach(int itemSort in list)
            {
                Console.WriteLine(itemSort);
            }

            //Ro'yxatdan element mavjudligini aniqlash:
            if (list.Contains(2))
                Console.WriteLine("2 soni ro'yxatda mavjud");
            else
                Console.WriteLine("2 soni ro'yxatda mavjud emas");


            //Royxatdan elementni o'chirish:
            list.Remove(3);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************************************************");


            //Ro'yxatdan 4-elementni o'chirish, Remove() methodidan farqi shundaki bunda indexdan o'chiramiz:
            list.RemoveAt(4);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************************************************");

            //Ro'yxatdan bir vaqtning o'zida bir nechta elementlarni o'chirib yuborish:
            list.RemoveRange(2, 1);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************************************************");*/

            /*
            List<string> list = new List<string>();
            list.Add("Toshkent");
            list.Add("KualaLampur");
            list.Add("Dubay");
            list.Add("Tehron");
            list.Add("Istanbul");

            //Ro'yxatlarni ToArray() methodi yordamida massivga o'zgarish mumkin:

            string line=string.Join(",", list.ToArray());
            Console.WriteLine(line);

            //Ko'rsatilgan elementni indeksini topish:
            int index1=list.IndexOf("Istanbul");
            Console.WriteLine(index1);

            //Ko'rsatilgan elementni indeksini topish:
            int index2 = list.BinarySearch("Dubay");
            Console.WriteLine(index2);*/





            /*//Dictionary lug'atlari

            //Yangi lug'at elon qilish:
            Dictionary<int, string> lugat = new Dictionary<int, string>();

            //Lug'atga yangi element qo'shish:
            lugat.Add(11, "Olma");
            lugat.Add(99, "Anor");
            lugat.Add(53, "Nok");
            lugat.Add(98, "Shaftoli");
            lugat.Add(47, "Uzum");
            lugat.Add(62, "O'rik");
            lugat.Add(7, "Xurmo");
            lugat.Add(20, "Olxo'ri");
            lugat.Add(19, "Anjir");
            lugat.Add(35, "Gilos");

            foreach(var juftlik in lugat)
            {
                Console.WriteLine("{0},{1}",
                    juftlik.Key,
                    juftlik.Value);
            }
            Console.WriteLine("*************************************************************");
            //Lug'atdan elementlarni o'chirish:

            lugat.Remove(98);
            foreach (var juftlik in lugat)
            {
                Console.WriteLine("{0},{1}",
                    juftlik.Key,
                    juftlik.Value);
            }

            Console.ReadKey();*/

            
            /* Shuning bilan C# asoslari darslari o'z nihoyasiga yetdi va keyingi bo'limda C# OOP qismi bilan tanishamiz:*/

        }
    }
}
           
    


