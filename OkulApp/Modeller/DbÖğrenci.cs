using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulApp.Modeller
{
    public class DbÖğrenci
    {
        public int Id { get; set; } //PK

        public int Numara { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int? Cinsiyet { get; set; } // 0: Erkek, 1: Kız
        //int? null olabilir anlamında

        public int SinifId { get; set; } //FK    

        public DbSinif Sinif { get; set; } //Navigation Property
    }
}
