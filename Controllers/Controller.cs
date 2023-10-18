using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly GameDbContext _db;

    public GameController(GameDbContext db)
    {
        _db = db;
    }

    [HttpPost]
    public async Task<IActionResult> CreateGame([FromForm] GameRequest req)
    {
        Game newGame = new()
        {
            Title = req.Title,
            GameSystemId = req.GameSystemId,
            GenreId = req.GenreId
        };

        _db.Games.Add(newGame);
        await _db.SaveChangesAsync();

        return Ok(newGame);
    }