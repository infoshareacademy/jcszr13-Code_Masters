﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHero.UserPanel
{
    internal class CreateUsers
    {   public void CreateUsersFile()
        {
            var newUser1 = new User("user1@email.hotelhero", "passwordValue1");
            var newUser2 = new User("user2@email.hotelhero", "passwordValue2");
            var newUser3 = new User("user3@email.hotelhero", "passwordValue3");
            var users = new List<User>();
            users.Add(newUser1);
            users.Add(newUser2);
            users.Add(newUser3);

            FileOperations fileOperations = new FileOperations();

            fileOperations.SerializeFile(users);
        }
    }
}
