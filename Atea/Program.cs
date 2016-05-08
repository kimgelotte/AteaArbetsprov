using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atea
{
    public class Program
    {
        //Initierar klass-variabler.
        public static string userInput;
        public static DateTime timeStamp;

        static void Main(string[] args)
        {
            SaveTextToDb();
            Console.ReadKey();
        }
        
        //Metod för att spara meddelande till db.
        public static void SaveTextToDb()
        {
            try
            {
                //Variabler för användarinput och tidsstämpel.
                string userInput = GetMessage("Enter message: ");
                DateTime timeStamp = DateTime.Now;

                //Öppnar db-koppling, skapar nytt entity objekt och sparar med nya värden.
                using (MessageContext db = new MessageContext())
                {
                    MessageEntity messages = new MessageEntity()
                    {
                        MessageText = userInput,
                        MessageTime = DateTime.Now,
                    };
                    db.Messages.Add(messages);
                    db.SaveChanges();
                    Console.Write("Message sent!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Metod för inmatning av meddelande
        public static string GetMessage(string message)
        {
            try
            {
                //Skriver ut argumentet och retunerar ReadLine.
                Console.Write(message);
                return Console.ReadLine();
            }
            catch (Exception ex)
            {
                //Skriver ut ev. felmeddelande, sedan körs metoden om.
                Console.WriteLine(ex.Message);
                return GetMessage(message);
            }
        }
    }
}
