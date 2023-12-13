using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_8
{
    // Define an interface for iterators
    public interface Iterator
    {
        MenuItem getNext();  // Get the next item in the iteration
        bool hasMore();      // Check if there are more items in the iteration
    }

    // Iterator implementation for Pancake House Menu
    public class PancakeHouseMenuIterator : Iterator
    {
        ArrayList menuItems;    // Collection of menu items
        int currentPosition = 0; // Current position in the iteration

        // Constructor to initialize the iterator with a list of menu items
        public PancakeHouseMenuIterator(ArrayList MenuItems) => menuItems = MenuItems;

        // Get the next menu item in the iteration
        public MenuItem getNext() => (MenuItem)menuItems[currentPosition++];

        // Check if there are more menu items in the iteration
        public bool hasMore()
        {
            // If the current position is greater than or equal to the number of items, return false
            if (currentPosition >= menuItems.Count)
                return false;

            // Otherwise, return true
            return true;
        }
    }

    // Iterator implementation for Dinner Menu
    public class DinnerMenuIterator : Iterator
    {
        MenuItem[] menuItems;   // Array of menu items
        int currentPosition = 0; // Current position in the iteration

        // Constructor to initialize the iterator with an array of menu items
        public DinnerMenuIterator(MenuItem[] MenuItems) => menuItems = MenuItems;

        // Get the next menu item in the iteration
        public MenuItem getNext() => menuItems[currentPosition++];

        // Check if there are more menu items in the iteration
        public bool hasMore()
        {
            // If the current position is greater than or equal to the array length, return false
            if (currentPosition >= menuItems.Length)
                return false;

            // Otherwise, return true
            return true;
        }
    }
}

