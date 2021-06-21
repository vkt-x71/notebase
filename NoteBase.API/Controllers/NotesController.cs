using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NoteBase.Core.DTOs;
using NoteBase.Service.Services;

namespace NoteBase.API.Controllers
{
    [Authorize]
    [Route("api/{controller}")]
    [ApiController]
    public class NotesController : CustomBaseController
    {
        private readonly NotesService _notesService;

        public NotesController(NotesService noteService)
        {
            _notesService = noteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return ActionResultInstance(await _notesService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(NotesDto note)
        {
            return ActionResultInstance(await _notesService.AddAsync(note));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(NotesDto note)
        {
            return ActionResultInstance(await _notesService.Update(note,note.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _notesService.Remove(id));
        }
    }
}
