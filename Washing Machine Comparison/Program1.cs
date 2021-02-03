/*using System;
namespace Program{
class Program
{     
    public static void Main()
    {
        
            getvalue();
        
    }
    static void getvalue()
    {
        Washing_Machine obj1= new Washing_Machine();
       Console.WriteLine("Washing Machine  feature as follows:");
        Console.WriteLine("Washing Company name is: ");
        obj1.company_name=Console.ReadLine();
        Console.WriteLine("Load= ");
        obj1.load=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Capacity: ");
        obj1.capacity=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("color: ");
        obj1.color=(Console.ReadLine());
        Console.WriteLine("type_of_control: ");
        obj1.type_of_control=(Console.ReadLine());
        Console.WriteLine("drum_material: ");
        obj1.drum_material=(Console.ReadLine());
        Console.WriteLine("inner_tube: ");
        obj1.inner_tube=Console.ReadLine();
        Console.WriteLine("frequency: ");
        obj1.frequency=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("voltage: ");
        obj1.voltage=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("max_spin_speed: ");
        obj1.max_spin_speed=Convert.ToInt32(Console.ReadLine());
        


        Washing_Machine obj2= new Washing_Machine();
        Console.WriteLine("Wasjing Machine  feature as follows:");
        Console.WriteLine("Washing company name is: ");
        obj2.company_name=Console.ReadLine();
        Console.WriteLine("Load= ");
        obj2.load=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Capacity: ");
        obj2.capacity=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("color: ");
        obj2.color=(Console.ReadLine());
        Console.WriteLine("type_of_control: ");
        obj2.type_of_control=(Console.ReadLine());
        Console.WriteLine("drum_material: ");
        obj2.drum_material=(Console.ReadLine());
        Console.WriteLine("inner_tube: ");
        obj1.inner_tube=Console.ReadLine();
        Console.WriteLine("frequency: ");
        obj2.frequency=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("voltage: ");
        obj2.voltage=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("max_spin_speed: ");
        obj2.max_spin_speed=Convert.ToInt32(Console.ReadLine());
        


        if(obj1.load>obj2.load)
       {
         Console.WriteLine((obj1.company_name)+" machine load capacity good");
        
       }
       else{
           Console.WriteLine((obj2.company_name)+" machine load capacity good");
       }
       if(obj1.max_spin_speed>obj2.max_spin_speed)
       {
         Console.WriteLine((obj1.company_name)+" machine spin speed good");
        
       }
       else{
           Console.WriteLine((obj2.company_name)+" machine spin speed good");
       }
       
    }
    
public class Washing_Machine
{
   internal string company_name{get;set;}
   internal string model_no{get;set;}
   internal int load{get;set;}
   internal int capacity{get;set;}
   internal string control{get;set;}
   internal string color{get;set;}
   internal string type_of_control{get;set;}
   internal string drum_material{get;set;}
   internal string inner_tube{get;set;}
   internal int frequency{get;set;}
   internal int voltage{get;set;}
   internal int max_spin_speed{get;set;}

   
   
       
   }


}

}*/