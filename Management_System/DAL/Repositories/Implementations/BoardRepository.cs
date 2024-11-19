using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations;

public class BoardRepository (ManagementSystemDBContext db) : Repository<BoardEntity>(db), IBoardRepository 
{
    public async Task<BoardEntity?> GetBoard(Guid id, CancellationToken cancellationToken)
    {
        var board = await GetById(b => b.Id == id)
            .Include(b => b.Tables)
            .Include(b => b.UserBoards)
            .FirstOrDefaultAsync(cancellationToken);
        return board;
    }
}
