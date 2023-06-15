namespace Abstraction_and_Encupsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Abituriyent klasiga mansub abit obektini e'lon qilamiz:
            Abituriyent abit =new Abituriyent();
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
}