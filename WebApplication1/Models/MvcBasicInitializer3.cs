using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class MvcBasicInitializer3 : CreateDatabaseIfNotExists<MvcBasicContext3>
    {
        protected override void Seed(MvcBasicContext3 context)
        {
        }
    }
}