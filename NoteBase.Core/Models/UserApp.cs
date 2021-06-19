using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBase.Core.Models
{
    public class UserApp : IdentityUser
    {
        public UserApp()
        {
            NoteBooks = new HashSet<NoteBooks>();
        }
        public virtual ICollection<NoteBooks> NoteBooks { get; set; }
    }
}
