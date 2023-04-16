using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Items
{
    public class Product : CoreEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ProductDescription { get; set; }
        public double Stock { get; set; }
        public double FirstPrice { get; set; }
        public int ImgID { get; set; }
        public string ImgPath { get; set; }
        public string ImageUrl { get; set; }
    }
}
   //core entity koy ++ enum bak table no double olacak ++
   //product category eklenecek ve product ile bire çok ++
   //user tablosu oluşturulacak identity user kütüphanesini kullanın ++
   //dbcontext dosyasını oluşturun ++ ve içeriğini doldurun ++
   //services isminde solution içerisinde yeni bir proje oluşturun++ servislerin soyut ve somut core classlarını yazın++
   //ve  CRUD işlemlerini yazın ve içeriklerini doldurun bu kısımda generic reppository design pattern kullanın
   //ilgili modellere ait servisleri oluşturunuz.