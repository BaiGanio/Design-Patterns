using DP.Common.Models;
using System.Collections.Generic;

namespace DP.Common.Helpers
{
    public static class DataHarvest
    {
        public static IEnumerable<AppUser> GetListOfAppUsers()
        {
            return new List<AppUser>()
            {
                new AppUser(){Username="Daffy", Password="pass", Email="daffy@mail.com", IsConfirmed = true, Role = Role.Customer },
                new AppUser(){Username="Taz", Password="pAss", Email="taz@mail.com", IsConfirmed = false, Role = Role.Visitor},
                new AppUser(){Username="Bugs", Password="p@ss", Email="bugs@mail.com", IsConfirmed = true, Role = Role.Admin}
            };
        }
    }
}
