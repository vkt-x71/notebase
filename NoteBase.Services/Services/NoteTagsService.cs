using NoteBase.Core.DTOs;
using NoteBase.Core.Models;
using NoteBase.Core.Repositories;
using NoteBase.Core.Services;
using NoteBase.Core.UnitOfWork;

namespace NoteBase.Service.Services
{
    public class NoteTagsService : ServiceGeneric<NoteTags, NoteTagsDto>, INoteTagsService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IGenericRepository<NoteTags> _genericRepository;

        public NoteTagsService(IUnitOfWork unitOfWork, IGenericRepository<NoteTags> genericRepository) : base(unitOfWork, genericRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }
    }
}