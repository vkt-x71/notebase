using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBase.Core.Models
{
    public class NoteTags
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int NoteId { get; set; }
        public Notes Note { get; set; }
        public Tags Tag { get; set; }

    }
}
