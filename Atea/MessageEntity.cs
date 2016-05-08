using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atea
{
    // Entity av tabellen Message i databasen.
    public class MessageEntity
    {
        //Properties som representerar kolumnerna i tabellen.
        [Key]
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageTime { get; set; }
    }
}
