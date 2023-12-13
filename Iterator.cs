using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_8
{
    public interface Iterator
    {
        MenuItem getNext();
        bool hasMore();
    }

    public class PancakeHouseMenuIterator : Iterator
    {
        ArrayList menuItems;
        int currentPosition = 0;
        public PancakeHouseMenuIterator(ArrayList MenuItems) => menuItems = MenuItems;
        public MenuItem getNext() => (MenuItem)menuItems[currentPosition++];
        public bool hasMore()
        {
            if (currentPosition >= menuItems.Count)
                return false;
            return true;
        }
    }
    public class DinnerMenuIterator : Iterator
    {
        MenuItem[] menuItems;
        int currentPosition = 0;
        public DinnerMenuIterator(MenuItem[] MenuItems) => menuItems = MenuItems;
        public MenuItem getNext() => menuItems[currentPosition++];
        public bool hasMore()
        {
            if (currentPosition >= menuItems.Length)
                return false;
            return true;
        }
    }

}
