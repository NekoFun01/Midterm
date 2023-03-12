using System.Reflection.Metadata;
namespace work2
{
   class NewBaseType1
    {
        static void Main(string[] args)
        {
           //exam2();
           //exam3();
          // yellow_yellow();
          //ab();
           //mahakon();
           //BTS_Butnot_kpop();
           //pher_pai_teow();
           four();
        }
        static void exam2()
        {
         Console.WriteLine("input a ");
         double a  =  double.Parse(Console.ReadLine());

         Console.WriteLine("Input b");
         double b = double.Parse(Console.ReadLine());
         if(b >= a){
         Console.WriteLine("Input x");
         double x = double.Parse(Console.ReadLine());
         if (b >= a && a >= x || x <= b)
         {
            Console.WriteLine("TRUE");
        }
else{
   Console.WriteLine("False");
}
    }
    else{
      Console.WriteLine("False");
    }
               }  
               static void exam3()
    {
      int power = int.Parse(Console.ReadLine());
      int a, b;
      for (a=1, b=1;a < power;a++)
      {
         
         b = b *= 2;

      }
      Console.WriteLine("power = {0}", power);
      Console.WriteLine("result = {0}", b);

    
	}

 

 static void ab()
 {
    Console.WriteLine("input");
    int num = int.Parse(Console.ReadLine());
    
 }
 static void mahakon()
 {
    Console.WriteLine("Input seat num");
    int x = int.Parse(Console.ReadLine());
    
    x = x%8;
    x = x+1;
    Console.WriteLine(x);
     x = x%8;
    x = x+1;
    Console.WriteLine(x); 
    x = x%8;
    x = x+1;
    Console.WriteLine(x); 
    x = x%8;
    x = x+1;
    Console.WriteLine(x);
   
    
 }
 static void BTS_Butnot_kpop()
 {
Console.WriteLine("Please input a number of stations:");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1:
    Console.WriteLine("Cost (THB): 16");
    break;
    case 2:
    Console.WriteLine("Cost (THB): 23");
    break;
    case 3:
    Console.WriteLine("Cost (THB): 26");
    break;
    case 4:
    Console.WriteLine("Cost (THB): 30");
    break;
    case 5:
    Console.WriteLine("Cost (THB): 33");
    break;
    case 6:
    Console.WriteLine("Cost (THB): 37");
    break;
    case 7:
    Console.WriteLine("Cost (THB): 40");
    break;
    case int t when t>= 8 && t<= 15:
    Console.WriteLine("Cost (THB): 44");
    break;
    case int t when t > 15:
    Console.WriteLine("Cost (THB): 59");
    break;
}
 }
 static void pher_pai_teow()
 {
   Console.WriteLine("input year");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("input month");
    int month = int.Parse(Console.ReadLine());
    Console.WriteLine("input day");
    int day = int.Parse(Console.ReadLine());
    
    bool meji_bool = (day >= 8 && day <= 29 && month >= 7 && month <= 9 && year >= 1868 && year <= 1912);
   bool taisai_bool = (day >= 24 && day <= 30 && month >= 7 && month <= 12 && year >= 1912 && year <= 1926);
   bool showa_bool = (day >= 7 && day <= 25 && month >= 1 && month <= 12 && year >= 1926 && year <= 1989);
   bool heisei_bool = (day >= 8 && day <= 30 && month >= 1 && month <= 4 && year >= 1989 && year <= 2019);
   bool reiwa_bool = (day >= 1 && month >= 5 && year >= 2019);
   if (meji_bool == true)
   {
      Console.WriteLine("Meji");
   }
   if (taisai_bool == true)
   {
      Console.WriteLine("taisai");
   }
   if (showa_bool == true)
   {
      Console.WriteLine("showa");
   }
   if (heisei_bool == true)
   {
      Console.WriteLine("heisei");
   }
   if (reiwa_bool == true)
   {
      Console.WriteLine("reiwa");
   }
   
 }

//  static void yellow_yellow()
//  {
//    Console.WriteLine("it put chaos lv.");
// int sign = int.Parse(Console.ReadLine());
// if(sign >= 1)
// {
//    Console.WriteLine("yellow");
   
// }

// if(sign => 2)
//    {
//    Console.WriteLine("orange");
   
//  }
 
//  if(sign>=4)
//  {
//    Console.WriteLine("red");
//  }
 
//              }

// static void shopzada_Lapee()
// {

// }
   static void four()
   {
      Console.WriteLine("iput");
      string a = (Console.ReadLine());
      int b;
      if(int.TryParse(a , out b))
      {
      Console.WriteLine(b);
      }
   }
    }
}


           
            
             
            
            
     