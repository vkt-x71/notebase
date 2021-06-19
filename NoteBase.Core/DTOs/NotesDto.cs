using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBase.Core.DTOs
{
    public class NotesDto
    {
        public int Id { get; set; }
        public int NoteBookId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
