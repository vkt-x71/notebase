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
    [ApiController]
    [Route("api/{controller}")]
    public class TagsController : CustomBaseController
    {
        private readonly TagsService _tagsService;

        public TagsController(TagsService tagsService)
        {
            _tagsService = tagsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return ActionResultInstance(await _tagsService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(TagsDto tags)
        {
            return ActionResultInstance(await _tagsService.AddAsync(tags));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(TagsDto tags)
        {
            return ActionResultInstance(await _tagsService.Update(tags, tags.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _tagsService.Remove(id));
        }

    }
}
