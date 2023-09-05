using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public static class ProductRepo
    {
        public static List<Product> AllProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                Image = "/Images/SpriteLarge.jpg",
                ProductName = "Sprite Large",
                ProductCost = 94
            });
            products.Add(new Product
            {
                Image = "/Images/CokeLarge.jpg",
                ProductName = "Coke Large",
                ProductCost = 95
            });
            products.Add(new Product
            {
                Image = "/Images/LaysRed.jpg",
                ProductName = "Lays Red Potato Chips",
                ProductCost = 30
            });

            products.Add(new Product
            {
                Image = "/Images/Glucose.jpg",
                ProductName = "Parle G Glucose Buscuits",
                ProductCost = 15
            });

            products.Add(new Product
            {
                Image = "/Images/DairyMilk.jpg",
                ProductName = "Dairy Milk Choclate",
                ProductCost = 24
            });

            products.Add(new Product
            {
                Image = "/Images/AmulChoclateCone.jpg",
                ProductName = "Amul Choclate Cone Ice-cream",
                ProductCost = 104
            });

            products.Add(new Product
            {
                Image = "/Images/AmulLassiBig.jpg",
                ProductName = "Amul Lassi Big 500ml",
                ProductCost = 60
            });

            products.Add(new Product
            {
                Image = "/Images/AmulTazzaMilk.jpg",
                ProductName = "Amul Tazza Milk 1 ltr",
                ProductCost = 55
            });

            products.Add(new Product
            {
                Image = "/Images/CalRedWine.jpg",
                ProductName = "California Red Wine 1000ml",
                ProductCost = 1060
            });

            products.Add(new Product
            {
                Image = "/Images/SmirnoffVodka.jpg",
                ProductName = "Smirnoff Vodka 1.75 ltr",
                ProductCost = 1500
            });
            products.Add(new Product
            {
                ProductName = "Dell Inspiron 3567",
                ProductCost = 69999,
                Image = "https://images.pexels.com/photos/9474023/pexels-photo-9474023.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"

            });
            products.Add(new Product
            {
                ProductName = "Dell Latitude 5590",
                ProductCost = 79999,
                Image = "https://m.media-amazon.com/images/I/81BL4lKeokL._SL1500_.jpg"
            });
            products.Add(new Product
            {
                ProductName = "Infinix INBook X1 Neo Series",
                Image = "/images/InfinixInbook.jpg",
                ProductCost = 22000
            });
            products.Add(new Product
            {
                ProductName = "realme Book (Slim)",
                Image = "/images/RealmeBookSlim.jpg",
                ProductCost = 36000
            });
            products.Add(new Product
            {
                ProductName = "Xiaomi Notebook Pro 120G",
                Image = "/images/MiNotebookPro.jpg",
                ProductCost = 70000
            });
            products.Add(new Product
            {
                ProductName = "MacBook Air M2 13-inch",
                Image = "/Images/MacBook_Air_M2_Chip_Midnight_.jpg",
                ProductCost = 99900
            });
            products.Add(new Product
            {
                ProductName = "MacBook Pro 13‑inch - Space Grey",
                Image = "/Images/mbp-spacegray-gallery1-202206.jpg",
                ProductCost = 129900
            });
            products.Add(new Product
            {
                ProductName = "MacBook Pro 16‑inch - Space Grey",
                Image = "/Images/mbp16-spacegray-gallery1-202301.jpg",
                ProductCost = 249900
            });
            products.Add(new Product
            {
                ProductName = "Acer Nitro 5",
                Image = "/images/Acer-Nitro-5.jpg",
                ProductCost = 79999
            });
            products.Add(new Product
            {
                ProductName = "Dell-G15-5515",
                Image = "/images/Dell-G15.jpg",
                ProductCost = 75000
            });
            products.Add(new Product
            {
                ProductName = "Gigabyte-G5-2023",
                Image = "/images/Gigabyte.jpg",
                ProductCost = 90999
            });
            products.Add(new Product
            {
                ProductName = "Lenovo IdeaPad Slim 3 Intel Core i3 11th Gen",
                Image = "/images/lenovo2.jpg",
                ProductCost = 41000
            });
            products.Add(new Product
            {
                ProductName = "Lenovo ThinkPad C13 Yoga AMD Ryzen 5 3500C 13.3",
                Image = "/images/lenovo3.jpg",
                ProductCost = 54990
            });
            products.Add(new Product
            {
                ProductName = "Lenovo Tab Yoga Duet 7 ",
                Image = "/images/lenovo4.jpg",
                ProductCost = 70000
            });
            products.Add(new Product
            {
                ProductName = "HP Notebook",
                Image = "/Images/HP_Notebook.jpg",
                ProductCost = 36999
            });
            products.Add(new Product
            {
                ProductName = "HP Pavilion 15",
                Image = "/Images/HP_Pavilion 15.jpg",
                ProductCost = 89990
            });
            products.Add(new Product
            {
                ProductName = "HP Victus",
                Image = "/Images/HP_Victus.jpg",
                ProductCost = 97200
            });
            products.Add(new Product
            {
                ProductName = "ASUS ROC TRIX G15",
                Image = "/laptopimages/Asus ROC trix G15",
                ProductCost = 59000
            });
            products.Add(new Product
            {
                ProductName = "ASUS VIVOBOOK 16X",
                Image = "/laptopimages/ASUS Vivobook 16X (2022).jpg",
                ProductCost = 96000
            });
            products.Add(new Product
            {
                ProductName = "LENOVO V15-82",
                Image = "/laptopimages/lenovo-v15-82kba033ih-11th-gen-intel-core-i3-1115g4-15-6-inches-notebook-laptop-8gb-512gb-ssd-windows-11-				iron-grey-1-7-kg-.jpg",
                ProductCost = 40000
            });

            products.Add(new Product
            {
                Image = "/Images/iPhone1.jpg",
                ProductName = "iPhone14",
                ProductCost = 77000
            });

            products.Add(new Product
            {
                Image = "/Images/iPhoneSE.jpg",
                ProductName = "iPhoneSE",
                ProductCost = 49000
            });

            products.Add(new Product
            {
                Image = "/Images/iPhone13pro.jpg",
                ProductName = "iPhone13pro",
                ProductCost = 99000
            });
            products.Add(new Product
            {
                ProductName = "HD ready smart LED TV",
                Image = "/Images/TV2.jpg",
                ProductCost = 78000
            });
            products.Add(new Product
            {
                ProductName = "Xiaomi Mi TV P1 32 inch",
                Image = "/Images/TV3.jpg",
                ProductCost = 98000
            });
            products.Add(new Product
            {
                ProductName = "X75L Series 4K HDR Smart TV ",
                Image = "/Images/TV4.jpg",
                ProductCost = 88000
            });
            products.Add(new Product
            {
                ProductName = "Samsung TV",
                Image = "/Images/TVSamsung.jpg",
                ProductCost = 500000
            });
            return products;
        }
    }
}