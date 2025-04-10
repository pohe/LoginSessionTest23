﻿using LoginSessionTest.Models;

namespace LoginSessionTest.Data
{
    public class MockData
    {
        public static List<User> UserData = new List<User> { new User { Id = 1, UserName = "Test", Password = "123" }
        , new User { Id = 2, UserName = "Poul", Password = "123" }
        ,new User { Id = 3, UserName = "Charlotte", Password = "123" }};

        public static List<Car> CarData = new List<Car> { new Car { Regnr="AD1212", Model = "Skoda"}
        , new Car { Regnr= "GG2323", Model="Volvo" }
        };
    }
}
