using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBase.Core.Models
{
    public class NoteBooks
    {
        public NoteBooks()
        {
            Notes = new HashSet<Notes>();
        }
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TopId { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public bool IsDeleted { get; set; }
        public UserApp UserApp { get; set; }
        public virtual ICollection<Notes> Notes { get; set; }
}
}
