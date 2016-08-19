using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class MvcBasicInitializer : CreateDatabaseIfNotExists<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            //var menbers = new List<Member>
            //{
            //    new Member
            //    {
            //        Name = "飲み物",
            //        Date = DateTime.Parse("2016-08-17"),
            //        Price= 150,
            //        Memo ="コーラ"
            //    },
            //    new Member
            //    {
            //        Name = "昼食",
            //        Date = DateTime.Parse("2016-08-17"),
            //        Price = 650,
            //        Memo ="マクドナルド"
            //    }
            // };
            //menbers.ForEach(m => context.Members.Add(m));
            //context.SaveChanges();
        }
    }
}