using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class MockZingerRepository
    {
        private List<ApplicationUser> _userList;

        public MockZingerRepository()
        {
            _userList = new List<ApplicationUser>()
        {
            new ApplicationUser() { UserName="@fkohrt0", Last_Name = "Kohrt", First_Name="Karla", Middle_Name="Filippa", Display_Name="fkohrt0", Date_of_Birth= new DateTime(1973, 4, 18), PasswordHash="l8TpCD6", Email="fkohrt0@a8.net"},
            new ApplicationUser() { UserName="@lvirgoe1", Last_Name = "Virgoe", First_Name="Arlin", Middle_Name="Livy", Display_Name="lvirgoe1", Date_of_Birth= new DateTime(1961, 12 ,21), PasswordHash="Kq3MIF", Email="lvirgoe1@mysql.com"},
            new ApplicationUser() { UserName="@aort2", Last_Name = "Ort", First_Name="Onfre", Display_Name="bort2", Date_of_Birth= new DateTime(1984, 6, 7), PasswordHash="aLl4VVsJOfi", Email="bort2@google.co.jp"},
            new ApplicationUser() { UserName="@hsterland3", Last_Name = "Sterland", First_Name="Nola", Middle_Name="Harriet", Display_Name="hsterland3", Date_of_Birth= new DateTime(1962, 8, 15), PasswordHash="bIMmCQT6u", Email="hsterland3@guardian.co.uk"},
            new ApplicationUser() { UserName="@bcozens4", Last_Name = "Cozens", First_Name="Osmund", Middle_Name="Bobbette", Display_Name="bcozens4", Date_of_Birth= new DateTime(1969, 9, 7), PasswordHash="MxyWNh1", Email="bcozens4@cnbc.com"},
            new ApplicationUser() { UserName="@hmyrie5", Last_Name = "Myrie", First_Name="Sigismund", Middle_Name="Herb", Display_Name="hmyrie5", Date_of_Birth= new DateTime(1966, 7, 15), PasswordHash="tQYG6D77sHr", Email="hmyrie5@hud.gov"},
            new ApplicationUser() { UserName="@mbrydson6", Last_Name = "Brydson", First_Name="Almeta", Display_Name="jbrydson6", Date_of_Birth= new DateTime(1971, 8, 2), PasswordHash="E13DNtsgFy", Email="dbrydson6@scribd.com"},
            new ApplicationUser() { UserName="@tgrishanov7", Last_Name = "Grishanov", First_Name="Jillana", Middle_Name="Tiebout", Display_Name="tgrishanov7", Date_of_Birth= new DateTime(1982, 8, 1), PasswordHash="Rcj84GMI6oC", Email="tgrishanov7@gizmodo.com"},
            new ApplicationUser() { UserName="@hmackartan8", Last_Name = "MacKartan", First_Name="Haleigh", Middle_Name="Hilliary", Display_Name="hmackartan8", Date_of_Birth= new DateTime (1984, 2, 3), PasswordHash="T3SLMRi3EL7C", Email="hmackartan8@bravesites.com"},
            new ApplicationUser() { UserName="@tartinstall9", Last_Name = "Artinstall", First_Name="Atlante", Middle_Name="Tim", Display_Name="tartinstall9", Date_of_Birth= new DateTime(1991, 5, 16), PasswordHash="gdwxi7", Email="tartinstall9@patch.com"},
        };
        }

        public ApplicationUser GetUsers(string Id)
        {
            return this._userList.FirstOrDefault(e => e.Id == Id);
        }
    }
}

