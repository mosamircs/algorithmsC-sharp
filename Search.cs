using System;

namespace algorithms
{
    class Search
    {
        /**
        The binary_search function takes a sorted array and an item. If the
        item is in the array, the function returns its position. You’ll keep track
        of what part of the array you have to search through. At the beginning,
        this is the entire array:
        */
        public int? BinarySearch(int [] list , int element)//tiime is O(log(n))
        {
            int low = 0;//first element in list
            int high = list.Length - 1;//last element in list
            int mid;
            int guess;
            while(low <= high)
            {
                mid = (low + high ) / 2;//gets the middle element
                guess = list[mid];
                if(element == guess)//found the item
                {
                    return mid;
                }
                else if(element < guess)//case element < middle go and search in left part of the list
                {
                    high = mid - 1;
                }
                else 
                {
                    low = mid +1;
                }
                
            }
            Console.WriteLine("Not Found");
            return null;
        }
        public int? LinearSearch(int [] list,int element)// time is O(n)
        {
            for(int i=0;i<list.Length;i++)
            {
                if(element == list[i])
                {
                    return i;
                }
            }
            Console.WriteLine("Not Found");
            return null;
        }
    }
}
