namespace midterm
{
    class choice01
    {
        static void Main(string[] args)
        {
            NekoGrabFood();
        }

            static void NekoGrabFood()
        {
              Console.WriteLine("input day");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("time");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Your Order");
            
            int M_break = 6;
            int M_week = 3;
            int M_Cofee = 4;
            bool chec = true;
            while (chec)
            {
            string Menu = Console.ReadLine();
            switch (Menu)
            {
                case "Breakfast Set":
                if(time < 11)
                {
                M_break = M_break - 1;
                if ( M_break == 0)
                {
                    Console.WriteLine("Sorry your order is out of stock");
                } 
                }
                else
                {
                    Console.WriteLine("Sorry your order is not available");
                }
                break;
                case "Weekend Set":
                 if(day == 6 || day == 7)
                 { 
                    M_week = M_week - 1;
                if ( M_week == 0)
                {
                    Console.WriteLine("Sorry your order is out of stock");
                } 
                }
                else
                {
                    Console.WriteLine("Sorry your order is not available");
                }
                break;
                case "Coffee":
               
                M_Cofee = M_Cofee - 1;
                if ( M_Cofee == 0)
                {
                    Console.WriteLine("Sorry your order is out of stock");
                } 
                break;
                case "End":
                chec = false;
                break;
                default:
                Console.WriteLine("Please enter a valid menu");
                break;
            }
            
        
            
             }
        }
             
    }
}
    

