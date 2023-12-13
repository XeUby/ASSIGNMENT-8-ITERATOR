namespace assignment_8
{
    public class Program
    {
        public class Waiter
        {
            PancakeHouseMenu pancake_house_menu;
            DinerMenu dinner_menu;

            public Waiter(PancakeHouseMenu pancake_house_menu, DinerMenu dinner_menu)
            {
                this.pancake_house_menu = pancake_house_menu;
                this.dinner_menu = dinner_menu;
            }


            public void printMenu()
            {
                Iterator pancake_house_menu_iterator = pancake_house_menu.createIterator();
                Iterator dinner_menu_iterator = dinner_menu.createIterator();

                Console.WriteLine("MENU\n----\nBREAKFAST");
                while (pancake_house_menu_iterator.hasMore())
                    Console.WriteLine(pancake_house_menu_iterator.getNext());
                Console.WriteLine("LUNCH");
                while (dinner_menu_iterator.hasMore())
                    Console.WriteLine(dinner_menu_iterator.getNext());

            }
        }
        static void Main(string[] args)
        {
            PancakeHouseMenu pancake_house_menu = new PancakeHouseMenu();
            DinerMenu dinner_menu = new DinerMenu();
            

            Waiter waiter = new Waiter(pancake_house_menu, dinner_menu);
            waiter.printMenu();
        }
    }
}