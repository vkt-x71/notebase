using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NoteBase.Core.DTOs;
using NoteBase.Core.Models;
using NoteBase.Service.Services;

namespace NoteBase.API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    [Authorize]
    public class NoteTagsController : CustomBaseController
    {
        private readonly NoteTagsService _noteTagsService;

        public NoteTagsController(NoteTagsService noteTagsService)
        {
            _noteTagsService = noteTagsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return ActionResultInstance(await _noteTagsService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(NoteTagsDto noteTags)
        {
            return ActionResultInstance(await _noteTagsService.AddAsync(noteTags));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(NoteTagsDto noteTags)
        {
            return ActionResultInstance(await _noteTagsService.Update(noteTags,noteTags.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _noteTagsService.Remove(id));
        }
    }
}
