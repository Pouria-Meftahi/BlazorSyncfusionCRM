using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSyncfusionCRM.Shared
{
    public class Note
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public int? ContactId { get; set; }
        public Contact? Contact { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
