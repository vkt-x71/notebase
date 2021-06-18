using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NoteBase.Core.DTOs;
using NoteBase.SharedLibrary.Dtos;

namespace NoteBase.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);

        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);

        Response<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}