using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NoteBase.Core.DTOs;
using NoteBase.SharedLibrary.Dtos;

namespace NoteBase.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}