using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationHelper
{
    public class PagnationHelper11<T>
    {
        IList<T> _collection;
        int _itemsPerPage;
        //public PagnationHelper(IList<T> collection, int itemsPerPage)
        //{
        //    _collection = collection;
        //    _itemsPerPage = itemsPerPage;


        //}

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return  _collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {

            get
            {
                int pages = (int)Math.Ceiling( Convert.ToDouble(ItemCount)/ Convert.ToDouble (_itemsPerPage));
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

            if (pageIndex> PageCount - 1 || pageIndex<0)
            {
                return -1;
            }
            else
            {
                if (pageIndex != PageCount-1)
                {
                    return _itemsPerPage;
                }
                else
                {
                    return ItemCount % _itemsPerPage ;
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


            return itemIndex / _itemsPerPage;

        }
    }
}