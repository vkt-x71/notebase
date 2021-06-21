using NoteBase.Core.DTOs;
using NoteBase.Core.Models;
using NoteBase.Core.Repositories;
using NoteBase.Core.Services;
using NoteBase.Core.UnitOfWork;

namespace NoteBase.Service.Services
{
    public class NotesService: ServiceGeneric<Notes, NotesDto>, INoteSetvice
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IGenericRepository<Notes> _genericRepository;

        public NotesService(IUnitOfWork unitOfWork, IGenericRepository<Notes> genericRepository) : base(unitOfWork, genericRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }
    }
}