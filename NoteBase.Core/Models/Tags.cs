using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBase.Core.Models
{
    public class Tags
    {
        public Tags()
        {
            NoteTags = new HashSet<NoteTags>();
        }
        public int Id { get; set; }
        public string Tag { get; set; }
        public virtual ICollection<NoteTags> NoteTags { get; set; }

    }
}
