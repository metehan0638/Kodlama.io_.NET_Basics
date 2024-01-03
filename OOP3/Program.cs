using OOP3;
using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface'lerde o interface'i implemente eden class'ın referansı tutabilir.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

           basvuruManager.BasvuruYap(esnafKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManager,ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}