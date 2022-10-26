using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            PagnationHelper nuevo = new PagnationHelper() ;


        }

    }
    public class PagnationHelper<T>
    {
        /* THIS IS THE BEST SOLUTION IN CODEWARS
        // TODO: Complete this class
        private int _itemCount = 0;
        private int _pageCount = 0;
        private int _itemsPerPage = 0;
        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            if (null == collection || collection.Count == 0 || itemsPerPage <= 0)
            { _itemCount = 0; _pageCount = 0; }
            else
            {
                _itemCount = collection.Count;

                int partialPage = 0;
                if ((_itemCount % itemsPerPage) != 0) { partialPage = 1; }

                _pageCount = _itemCount / itemsPerPage + partialPage;
            }

            _itemsPerPage = itemsPerPage;
        }

        */

        // mi solution

        IList<T> _collection;
        int _itemsPerPage;
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            _collection = collection;
            _itemsPerPage = itemsPerPage;


        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return _collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {

            get
            {
                int pages = (int)Math.Ceiling(Convert.ToDouble(ItemCount) / Convert.ToDouble(_itemsPerPage));
                return pages;

            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>


        /// 
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {

            if (pageIndex > PageCount - 1 || pageIndex < 0)
            {
                return -1;
            }
            else
            {
                if (_itemsPerPage==ItemCount)
                {
                    return 0;
                }
                else
                {
                    if (pageIndex != PageCount - 1)
                    {
                        return _itemsPerPage;
                    }
                    else
                    {
                        return ItemCount % _itemsPerPage;
                    }
                }
 
            }

        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex>ItemCount-1 || itemIndex<0)
            {
                return -1;
            }

            if (itemIndex ==0)
            {
                return 0;
            }
            else
            {
                return itemIndex / _itemsPerPage;
            }


            

        }
    }
}