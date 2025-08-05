using Crm.Redis.Application.Services;
using Crm.Redis.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crm.Redis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelUploadController : ControllerBase
    {
        private readonly ExcelFolderProcessingService _folderService;

        public ExcelUploadController(ExcelFolderProcessingService folderService)
        {
            _folderService = folderService;
        }

        [HttpPost("import-folder")]
        public async Task<IActionResult> ImportFolder([FromBody] FolderImportRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _folderService.ProcessFolderAsync(request.FolderPath);
            return Ok(new { message = "Dosyalar başarıyla işlendi." });
        }
    }
}
