using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Atea
{
    // DbContext ifrån EF
    class MessageContext : DbContext
    {
        public DbSet<MessageEntity> Messages { get; set; }  
    }
}
