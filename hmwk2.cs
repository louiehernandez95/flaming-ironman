using System;
using IntroCS;
using quotient;

namespace MainName
{
   class MainClass
   {
      public static void Main (string[] args)
      {
         Console.WriteLine ("Hello World!");
         string hello = UI.PromptLine("Enter hello: ");
         Console.WriteLine(hello);
      }
   }
}