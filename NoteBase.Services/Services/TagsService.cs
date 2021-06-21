using NoteBase.Core.DTOs;
using NoteBase.Core.Models;
using NoteBase.Core.Repositories;
using NoteBase.Core.Services;
using NoteBase.Core.UnitOfWork;

namespace NoteBase.Service.Services
{
    public class TagsService : ServiceGeneric<Tags, TagsDto>, ITagService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IGenericRepository<Tags> _genericRepository;

        public TagsService(IUnitOfWork unitOfWork, IGenericRepository<Tags> genericRepository) : base(unitOfWork, genericRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }
    }
}