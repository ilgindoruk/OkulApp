using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulApp.Modeller
{
     public class DbSinif
    {
        public int Id { get; set; } //PK

        [MaxLength(10)]
        public string SinifAdi { get; set; }


        //Eğer öğrenci yok ise new() ile boş liste oluştur 
        public List<DbÖğrenci> Ogrenciler { get; set; } = new(); //Navigation Property

    }
}
