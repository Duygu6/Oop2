using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaselLoggerService();
            ILoggerService fileLoogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            DatabaselLoggerService loggerService = new DatabaselLoggerService();
            basvuruManager.BasvuruYap(konutKrediManager, loggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        } 
    }
}
