<<<<<<< HEAD
=======
using System.Collections.Generic;

>>>>>>> a7b2030 (Input item rule)
namespace ManageStore
{
    public struct Item
    {
        public string Id; /*Mã sản phẩm*/
        public string Name; /*Tên sản phẩm*/
        public int Qty; /*So luong san pham*/
        public Date Exp; /*Hạn sử dụng*/
        public Date Mfg; /*Năm sản xuất*/
        public string Com; /*Cty San xuat*/
        public string Type; /*Loai Hang*/
    }

    public struct Store
    {
<<<<<<< HEAD
        public Item[] ItemsList;
        public string[] Label;
    }

=======
        public List<Item> ItemsList;
        public List<string> Label;
    }
>>>>>>> a7b2030 (Input item rule)
    public struct Date
    {
        public int Month;
        public int Year;
    }
}