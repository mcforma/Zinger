using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class MockZingerRepository
    {
        private List<Users> _userList;

        public MockZingerRepository()
        {
            _userList = new List<Users>()
        {
            new Users() { User_Handle="@fkohrt0", Last_Name = "Kohrt", First_Name="Karla", Middle_Name="Filippa", Display_Name="fkohrt0", Date_of_Birth= new DateTime(1973, 4, 18), Pass_word="l8TpCD6", Email_Address="fkohrt0@a8.net", Admin_User=true },
            new Users() { User_Handle="@lvirgoe1", Last_Name = "Virgoe", First_Name="Arlin", Middle_Name="Livy", Display_Name="lvirgoe1", Date_of_Birth= new DateTime(1961, 12 ,21), Pass_word="Kq3MIF", Email_Address="lvirgoe1@mysql.com", Admin_User=true },
            new Users() { User_Handle="@aort2", Last_Name = "Ort", First_Name="Onfre", Display_Name="bort2", Date_of_Birth= new DateTime(1984, 6, 7), Pass_word="aLl4VVsJOfi", Email_Address="bort2@google.co.jp", Admin_User= true },
            new Users() { User_Handle="@hsterland3", Last_Name = "Sterland", First_Name="Nola", Middle_Name="Harriet", Display_Name="hsterland3", Date_of_Birth= new DateTime(1962, 8, 15), Pass_word="bIMmCQT6u", Email_Address="hsterland3@guardian.co.uk", Admin_User=false },
            new Users() { User_Handle="@bcozens4", Last_Name = "Cozens", First_Name="Osmund", Middle_Name="Bobbette", Display_Name="bcozens4", Date_of_Birth= new DateTime(1969, 9, 7), Pass_word="MxyWNh1", Email_Address="bcozens4@cnbc.com", Admin_User=true },
            new Users() { User_Handle="@hmyrie5", Last_Name = "Myrie", First_Name="Sigismund", Middle_Name="Herb", Display_Name="hmyrie5", Date_of_Birth= new DateTime(1966, 7, 15), Pass_word="tQYG6D77sHr", Email_Address="hmyrie5@hud.gov", Admin_User=true },
            new Users() { User_Handle="@mbrydson6", Last_Name = "Brydson", First_Name="Almeta", Display_Name="jbrydson6", Date_of_Birth= new DateTime(1971, 8, 2), Pass_word="E13DNtsgFy", Email_Address="dbrydson6@scribd.com", Admin_User=false },
            new Users() { User_Handle="@tgrishanov7", Last_Name = "Grishanov", First_Name="Jillana", Middle_Name="Tiebout", Display_Name="tgrishanov7", Date_of_Birth= new DateTime(1982, 8, 1), Pass_word="Rcj84GMI6oC", Email_Address="tgrishanov7@gizmodo.com", Admin_User=true },
            new Users() { User_Handle="@hmackartan8", Last_Name = "MacKartan", First_Name="Haleigh", Middle_Name="Hilliary", Display_Name="hmackartan8", Date_of_Birth= new DateTime (1984, 2, 3), Pass_word="T3SLMRi3EL7C", Email_Address="hmackartan8@bravesites.com", Admin_User=false },
            new Users() { User_Handle="@tartinstall9", Last_Name = "Artinstall", First_Name="Atlante", Middle_Name="Tim", Display_Name="tartinstall9", Date_of_Birth= new DateTime(1991, 5, 16), Pass_word="gdwxi7", Email_Address="tartinstall9@patch.com", Admin_User=false },
        };
        }

        public Users GetUsers(int Id)
        {
            return this._userList.FirstOrDefault(e => e.U_ID == Id);
        }
    }
}

