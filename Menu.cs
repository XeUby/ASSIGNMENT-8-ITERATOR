using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment_8
{
    public interface Menu
    {
        Iterator createIterator();
    }
    public class MenuItem  
    {
        String name;
        String description;
        bool vegetarian;
        double price;

        public MenuItem(String Name, String Description, bool Vegetarian, double Price) 
        { 
            this.name = Name;
            this.description = Description; 
            this.price = Price;
            this.vegetarian = Vegetarian;
        }
        public string GetName() => name;    
        public string GetDescription() => description;       
        public Boolean GetVegetarian() => vegetarian;
        public double GetPrice() => price;

        public override string? ToString() => $"{name}, {price} -- {description}";
     }

    public class PancakeHouseMenu : Menu
    {
        public Iterator createIterator() => new PancakeHouseMenuIterator(menuItems);
        
        ArrayList menuItems ;
        
        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);

            AddItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries, and blueberry syrup",
                true,
                3.49);

            AddItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59);
        }
        public void AddItem(String Name, String Description, bool Vegetarian, double Price) => menuItems.
            Add(new MenuItem(Name, Description,Vegetarian,Price));

    }

    public class DinerMenu : Menu
    {
        public Iterator createIterator() => new DinnerMenuIterator(menuItems);
        
        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 3.05);
            AddItem("Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 3.89);
        }
        public void AddItem(String Name, String Description, bool Vegetarian, double Price)
        {
            if (numberOfItems < MAX_ITEMS)
            {
                this.menuItems[numberOfItems]= new MenuItem(Name, Description, Vegetarian, Price);
                this.numberOfItems += 1;
            }
        }
    }
}
