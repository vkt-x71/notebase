using System;
using System.Collections.Generic;
using System.Text;
using NoteBase.Core.Configuration;
using NoteBase.Core.DTOs;
using NoteBase.Core.Models;

namespace NoteBase.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}