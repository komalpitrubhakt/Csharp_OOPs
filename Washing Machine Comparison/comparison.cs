/*using System;
namespace Program{
class Program
{
    public static void Main()
    {
      getvalues();   

    }
    public static void getvalues()
    {
        LaptopComparison obj1= new LaptopComparison();
        Console.WriteLine("Laptop feature as follows:");
        Console.WriteLine("Laptop name is: ");
        obj1.LaptopName=Console.ReadLine();
        Console.WriteLine("RAM= ");
        obj1.RAM=(Console.ReadLine());
        Console.WriteLine("Mfg Year ");
        obj1.MfgYear=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("warranty period: ");
        obj1.warrantyperiod=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("CurrentYear: ");
        obj1.CurrentYear=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Displaysize: ");
        obj1.Displaysize=(Console.ReadLine());
        Console.WriteLine("Weight: ");
        obj1.Weight=Console.ReadLine();
        Console.WriteLine("Series:  ");
        obj1.Series=Console.ReadLine();
        Console.WriteLine("Colour: ");
        obj1.Colour=Console.ReadLine();
        Console.WriteLine("touchscreen: ");
        obj1.Touchscreen=Console.ReadLine();
        Console.WriteLine("oprating system: ");
        obj1.Operatingsystem=Console.ReadLine();
        Console.WriteLine("Processor:  ");
        obj1.Processor=Console.ReadLine();

        printresult(obj1);


    }

    public static void printresult(LaptopComparison obj1)
    {
       obj1.Laptop(obj1.MfgYear,obj1.warrantyperiod);
    }
    public class LaptopComparison
    {
        internal string  LaptopName{get;set;}
         internal string RAM{get;set;}
         internal int MfgYear{get;set;}
         internal int warrantyperiod{get;set;}
         internal int CurrentYear{get;set;}
         internal string Displaysize {get;set;}
         internal string Weight {get;set;}
         internal string Series{get;set;}
         internal string Colour{get;set;}
         internal  string Touchscreen{get;set;}
         internal string Operatingsystem {get;set;}
         internal string Processor{get;set;}

         public void Laptop(int MfgYear,int warrantyperiod)
         {
             int WarrantyYear= MfgYear+warrantyperiod;
              if(WarrantyYear>CurrentYear)
              {
                  Console.WriteLine("Your laptop is in warranty period");
              }
              else
              {
                  Console.WriteLine("Your laptop is not in warranty period");
              }
             
         }
    }
}
}
*/