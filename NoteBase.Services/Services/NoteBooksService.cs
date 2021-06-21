using NoteBase.Core.DTOs;
using NoteBase.Core.Models;
using NoteBase.Core.Repositories;
using NoteBase.Core.Services;
using NoteBase.Core.UnitOfWork;

namespace NoteBase.Service.Services
{
    public class NoteBooksService :ServiceGeneric<NoteBooks,NoteBooksDto>, INoteBooksService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IGenericRepository<NoteBooks> _genericRepository;

        public NoteBooksService(IUnitOfWork unitOfWork, IGenericRepository<NoteBooks> genericRepository) : base(unitOfWork,genericRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }
    }
}