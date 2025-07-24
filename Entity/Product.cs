using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product
    { 
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Ürün Açıklama")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock {  get; set; }

        [DisplayName("Ürün Görseli")]
        public string Image {  get; set; }
        
        [DisplayName("Anasayfada mı?")]
        public bool IsHome { get; set; }

        [DisplayName("Onaylı mı?")]
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}