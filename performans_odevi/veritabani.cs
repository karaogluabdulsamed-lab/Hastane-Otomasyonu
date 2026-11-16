using System;
using MySql.Data.MySqlClient;  //myaql gonder

namespace performans_odevi
{
    public class Veritabani  
    {
        
        private string baglantiAdresi = "Server=localhost;Database=hastane;Uid=root;Pwd=;charset=utf8;";  

        public MySqlConnection Baglan()  //bag
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiAdresi);   
            return baglanti; //gereklı veriyi ıletmek ıcın 
        }
    }
}