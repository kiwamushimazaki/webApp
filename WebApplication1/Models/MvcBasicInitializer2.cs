using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class MvcBasicInitializer2 : CreateDatabaseIfNotExists<MvcBasicContext2>
    {
            protected override void Seed(MvcBasicContext2 context)
            {
            }
    }
}