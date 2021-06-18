using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using NoteBase.Core.DTOs;
using NoteBase.Core.Models;

namespace NoteBase.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}