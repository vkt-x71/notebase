using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBase.Core.DTOs
{
    public class NoteTagsDto
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int NoteId { get; set; }

    }
}
