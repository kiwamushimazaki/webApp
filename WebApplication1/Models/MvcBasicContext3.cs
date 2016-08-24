using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class MvcBasicContext3: DbContext
    {
        public DbSet<Data> Datas { get; set; }
    }
}