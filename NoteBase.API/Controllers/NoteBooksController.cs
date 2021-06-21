using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Query.Internal;
using NoteBase.Core.DTOs;
using NoteBase.Core.Services;

namespace NoteBase.API.Controllers
{
    [Authorize]
    [Route("api/{controller}")]
    [ApiController]
    public class NoteBooksController : CustomBaseController
    {
        private readonly INoteBooksService _noteBooksService;

        public NoteBooksController(INoteBooksService noteBookService)
        {
            _noteBooksService = noteBookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetNoteBooks()
        {
            return ActionResultInstance(await _noteBooksService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveNoteBooks(NoteBooksDto noteBooks)
        {
            return ActionResultInstance(await _noteBooksService.AddAsync(noteBooks));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNoteBooks(NoteBooksDto noteBooks)
        {
            return ActionResultInstance(await _noteBooksService.Update(noteBooks,noteBooks.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNoteBooks(int id)
        {
            return ActionResultInstance(await _noteBooksService.Remove(id));
        }
     }
}
