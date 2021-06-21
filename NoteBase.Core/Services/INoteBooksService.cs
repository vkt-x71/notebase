using Microsoft.EntityFrameworkCore.ChangeTracking;
using NoteBase.Core.DTOs;
using NoteBase.Core.Models;

namespace NoteBase.Core.Services
{
    public interface INoteBooksService : IServiceGeneric<NoteBooks,NoteBooksDto>
    {
        
    }
}