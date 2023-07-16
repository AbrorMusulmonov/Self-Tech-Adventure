//Delegate 


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


//Events


/*
using Events.Events;
using System.Security.Cryptography.X509Certificates;

namespace Events
{
    namespace Events
    {
        //delegate
        public delegate void ClickEvenetHandler();

        //tugma klasi
        class Tugma
        {
            //Xodisani e'lon qilamiz;
            public event ClickEvenetHandler Click;

            //Tugmani bosilishi "simuliyatsiya"
            public void Simulation()
            {
                //tugmani bosamiz
                if (Click != null)
                    Click();
            }

        }


    }


    internal class Program
    {
        public static void Tugma_Click()
        {
            Console.WriteLine("Tugma bosildi");
        }
        static void Main(string[] args)
        {
            Tugma tugma = new Tugma();
            tugma.Click += new ClickEvenetHandler(Tugma_Click);
            //tugma.Click += new Tugmadelegati(Tugma_Click2);
            //tugma.Click += new Tugmadelegati(Tugma_Click3);

            tugma.Simulation();

            tugma.Click -= new ClickEvenetHandler(Tugma_Click);
            Console.ReadLine();







        }
    }
}*/


//FILES
/*
namespace FIles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-misol: Fayl bilan ishlash:
            //DirectoryInfo dir = new DirectoryInfo(@"C:\temp");
            //Console.WriteLine("To'liq manzil : "+dir.FullName);
            //Console.WriteLine("Atributes : "+ dir.Attributes.ToString()); 

            //2-misol:Papka ichidagi fayllar bilan ishlash:
            //DirectoryInfo dir1 = new DirectoryInfo(@"C:\temp");
            //FileInfo[] txtfiles = dir1.GetFiles("*.txt");//txt fayllari ruyxatini massivga olish
            //Console.WriteLine("txt fayllar somi: "+txtfiles.Length.ToString());
            //foreach(FileInfo file in txtfiles)
            //{
            //    Console.WriteLine("Fayl nomi :{0}", file.Name);
            //    Console.WriteLine("Fayl hajmi :{0}", file.Length);
            //    Console.WriteLine("Faylning tuzilgan vaqti : {0}", file.CreationTime);
            //    Console.WriteLine("Faylning atributlari : {0}", file.Attributes.ToString());
            //    Console.WriteLine(Environment.NewLine);
            //}

            //3-misol: Yangi  papka tuzish:
            //DirectoryInfo dir2 = new DirectoryInfo(@"C:\temp");
            //try
            //{
            //    dir2.CreateSubdirectory("Cat");
            //    dir2.CreateSubdirectory(@"Cat\SubCat");
            //}
            //catch(IOException ex)
            //{
            //    Console.WriteLine("Papka tuzishda xatolik bo'ldi, "+Environment.NewLine+ex.Message.ToString());
            //    return;
            //}
            //Console.WriteLine("Papkalar muvaafaqiyatli tuzildi! ");

            //4-misol: Yangi file yaratish:
            //FileInfo file1 = new FileInfo(@"C:\temp\test1.txt");
            //FileStream fstr = file1.Create();
            //Console.WriteLine("Fayl yaratilgan vaqti: {0}", file1.CreationTime);
            //fstr.Close();

            //5-misol: Fayl o'chirish:
            //FileInfo file2 = new FileInfo(@"C:\temp\test1.txt");
            //file2.Delete();
            //Console.WriteLine(file2.FullName+" fayl o'chirildi.");

            //6-misol: Yangi fayl tuzishda Open() metodidan foydalanish:
            //FileInfo file3 = new FileInfo(@"C:\temp\test2.txt");
            //FileStream stream =file3.Open(FileMode.OpenOrCreate, FileAccess.Read);

            //7-misol: Streamwriter yordamida daylga yozish;
            //FileInfo file4 = new FileInfo(@"C:\temp\test3.txt");
            //StreamWriter writer = file4.CreateText();
            //writer.WriteLine("Bu birinchi qator");
            //writer.WriteLine(writer.NewLine);
            //writer.WriteLine("Bu uchunchi qator");
            //writer.WriteLine("Rahmat");
            //writer.Close();
            //Console.WriteLine("Fayl muvaafaqiyatli tuzilda va ma'lumotlar yozildi.");

            //8-misol:StreamReader yordamida fayldan text o'qish
            //Console.WriteLine("Fayldan malumotlarni o'qish...");
            //StreamReader reader = File.OpenText(@"C:\temp\test3.txt");
            //string read = null;
            //while ((read = reader.ReadLine()) != null)
            //{
            //    Console.WriteLine(read);
            //}
            //reader.Close();
            //reader.Dispose();

            //9-misol: using ishlatib StreamReader yordamida fayldan text o'qish
            //using (StreamReader reader = new StreamReader(@"C:\temp\test3.txt"))
            //{
            //    string read2 = null;
            //    while(!reader.EndOfStream)
            //    {
            //        read2 = reader.ReadLine();
            //        Console.WriteLine(read2);
            //    }
            //}

            //10-misol: Textni faylga yozish uchun TextWriter klasidan foydalanish;
            //using (TextWriter writer2 = File.CreateText(@"C:\temp\test4.txt"))
            //{
            //    writer2.WriteLine("Test1");
            //    writer2.WriteLine("Test2");
            //    writer2.WriteLine("Test3");
            //}

            //11-misol: Fayldagi ma'lumotlarni birdaniga o'qish
            //Faylning kadirovkasini aniqlash:
            //using (StreamReader reader = new StreamReader(@"C:\temp\test4.txt"))
            //{
            //    string alltext=reader.ReadToEnd();  
            //    Console.WriteLine("Fayl kodirovkasi : "+ reader.CurrentEncoding);
            //    Console.WriteLine(alltext); 
            //}
            //Console.Read();
        }
    }
}*/


//LINQ
/*
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linq1();
            //Linq2();
            //Linq3_1();
            //Linq3_2();
            //Linq4();
            //Linq5();
            //Linq6();
            //Linq7();
            Console.ReadLine();
        }
        //1-Misol: Sonlardan tashkil topgan massivdan 7 dan yuqori bolgan elementlarini olamiz:
        //public static void Linq1()
        //{

        //    //massivmi elon qilamiz
        //    int[] sonlar = { 2, 7, 5, 6, 10, 15, 8, 3 };

        //    //linq sorovini yozamiz:
        //    var natijaviySonlar=from son in sonlar
        //                        where son>7
        //                        orderby son
        //                select son;
        //    //Sorovni ishlatilishi:
        //    foreach(int son in natijaviySonlar)
        //    {
        //        Console.WriteLine(son.ToString());
        //    }
        //}


        //2-misol:Royxatdan "Reader" so'zi uchraydigan va bosh harfi "B" dan keluvchi elementlarni olamiz;
        //public static void Linq2()
        //{
        //    //Royxatni elon qilamiz va uni bazi bir qiymatlarini beramiz;
        //    List<string> eKitoblar=new List<string>();
        //    eKitoblar.Add("Amazon Kindle");
        //    eKitoblar.Add("Amazon Kindle Touch");
        //    eKitoblar.Add("Amazon Kindle DX");
        //    eKitoblar.Add("Amazon Kindle 4 Gen");
        //    eKitoblar.Add("IRiver Story");
        //    eKitoblar.Add("IRiver StoryHD");
        //    eKitoblar.Add("Nook");
        //    eKitoblar.Add("Nook SimpleTouch");
        //    eKitoblar.Add("Ettaco Jetbook");
        //    eKitoblar.Add("BENQ nReader");
        //    eKitoblar.Add("Hanlen eReader");

        //    //Linq sorovi
        //    var eKitobReader = from ekitob in eKitoblar
        //                       where ekitob.Contains("Reader") && ekitob.StartsWith("B")
        //                       orderby ekitob descending
        //                       select "Reader so'zi " + ekitob + " da uchradi va B dan boshlandi ";

        //    //Sorovni ishlatilishi:
        //    foreach(var ekitob in eKitobReader)
        //    {
        //        Console.WriteLine(ekitob.ToString());   
        //    }
        //}


        //private class MyFileInfo
        //{
        //    public string Name;
        //    public long Length;
        //    public DateTime CreationTime;
        //}

        //3.1-misol.Bir nechta qiymatlar olish(Alohida klass elon qilib)
        //public static void Linq3_1()
        //{
        //    var files = new DirectoryInfo(@"C:\\").GetFiles();
        //    var surov = from file in files
        //                where file.Length > 1000
        //                orderby file.Length, file.Name
        //                select new MyFileInfo
        //                {
        //                    Name = file.Name,
        //                    Length = file.Length,
        //                    CreationTime = file.CreationTime
        //                };
        //    foreach(var myfile in surov)
        //    {
        //        Console.WriteLine(
        //            "{0} faylini o'lchami: {1} bayt,tuzilgan vaqti : {2}",
        //            myfile.Name,myfile.Length,myfile.CreationTime);
        //    }


        //3.2-misol.Bir nechta qiymatlarni olish(Anonim tur ishlatgan holda).
        //public static void Linq3_2()
        //{
        //    var files = new DirectoryInfo(@"C:\\").GetFiles();
        //    var surov = from file in files
        //                where file.Length > 1000
        //                orderby file.Length, file.Name
        //                select new 
        //                {
        //                    Name = file.Name,
        //                    Length = file.Length,
        //                    CreationTime = file.CreationTime
        //                };
        //    foreach (var myfile in surov)
        //    {
        //        Console.WriteLine(
        //            "{0} faylini o'lchami: {1} bayt,tuzilgan vaqti : {2}",
        //            myfile.Name, myfile.Length, myfile.CreationTime);
        //    }
        //}


        //4-misol: Take operatori(Extension metodi)
        //public static void Linq4()
        //{
        //    int[] toliqMassiv = {1,2,3,4,5,6,7,8,9,10};
        //    var takeMassiv = toliqMassiv.Take(3);//Avvalgi uchta elementini olamiz;
        //    foreach(var son in takeMassiv)
        //    {
        //        Console.WriteLine(son.ToString());
        //    }
        //}

        //5-misol: SKip operatori
        //public static void Linq5()
        //{
        //    int[] toliqMassiv = { 6, 2, 1, 4, 5, 9, 7, 10, 8 };
        //    var skipTake = toliqMassiv.Skip(4);//Avvalgi 4 ta elementini o'tkazib yuboramiz;
        //    foreach(int i in skipTake)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}


        //6-misol:Reverse operatori
        //public static void Linq6()
        //{
        //    int[] toliqMassiv = { 1, 2, 3, 4, 5, 6, 7 };
        //    var reverseMassiv = toliqMassiv.Reverse();//Massivni teskarisiga aylantiradi;
        //    foreach (int i in reverseMassiv)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}

        //7-misol:TakeWhile operatoridan foydalanish;
        //public static void Linq7()
        //{
        //    int[] toliqMassiv = { 1, 5, 2, 6, 4, 2, 3, 7, 9, -2 };
        //    //Massiv elementlarini berilgan shart bajarilguncha olamiz;
        //    var takeMassiv = toliqMassiv.TakeWhile(i => i <= 5);
        //    foreach(int son in takeMassiv)
        //    {
        //        Console.WriteLine(son);
        //    }

        //}
    }
}*/