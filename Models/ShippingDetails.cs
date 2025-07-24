using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ShippingDetails
    {




        public string UserName { get; set; }


        [Required(ErrorMessage ="Lutfen adres tanımını giriniz.")]
        public string AdresBasligi { get; set; }

       
        [Required(ErrorMessage = "Lutfen bir adres giriniz.")]
        public string Adres { get; set; }
       

        [Required(ErrorMessage ="Lutfen şehir giriniz.")]
        public string Sehir { get; set; }
        
        
        
        [Required(ErrorMessage ="Lutfen İlçe giriniz.")]
        public string Ilce { get; set; }
       
       
        [Required(ErrorMessage ="Lutfen mahalle giriniz.")]
        public string Mahalle { get; set; }
       
        
        
        public string PostaKodu { get; set; }





    }
}