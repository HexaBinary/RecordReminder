using System;
using System.Threading;

namespace RecordReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, minute, second;

            Console.WriteLine("Teams Toplantı Kayıt Hatırlatıcısına Hoş Geldiniz");
            Console.WriteLine("Eğer programlar ilgili soru veya probleminiz olur ise,");
            Console.WriteLine("https://github.com/HexaBinary/RecordReminder adresinde bir issue oluşturarak veya");
            Console.WriteLine("hexabinary2007@protonmail.com adresine eposta göndererek bana ulaşabilirsiniz");

            while (true)
            {
                hour = DateTime.Now.Hour;
                minute = DateTime.Now.Minute;
                second = DateTime.Now.Second;

                if ((hour == 9 && minute == 1 && second == 0) || (hour == 9 && minute == 36 && second == 0))
                {
                    Console.WriteLine("Dersinizin başlamasından 1 dakika geçti, eğer daha başlatmadıysanız toplantı kaydı başlatmanız önerilir!");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
