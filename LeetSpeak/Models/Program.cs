using System;
 namespace LeetSpeak.Models{
   public class Program{
     public static void Main()
     {
       Console.WriteLine("Enter yout sentence");
       string userSentence = Console.ReadLine();
       LeetSpeakTranslator myTranslate = new LeetSpeakTranslator();
       string res = myTranslate.Translate(userSentence);
       Console.WriteLine(res);
       // myTranslate.Translate(userSentence);
     }
   }
 }
