using Microsoft.AspNetCore.Mvc;
using WebDiaryApi.Data;
using WebDiaryApi.Models;

namespace WebDiaryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DiaryEntriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    private DiaryEntriesController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public IEnumerable<DiaryEntry> GetDiaryEntries()
    {
        return _context.DiaryEntries.ToList();
    }
}