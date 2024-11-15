﻿using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations;
public class BoardRepository (ManagementSystemDBContext db) : Repository<BoardEntity>(db), IBoardRepository 
{
    public async Task<IEnumerable<BoardEntity>> GetBoards(CancellationToken cancellationToken)
    {
        var boards = await GetAll(cancellationToken).ToListAsync(cancellationToken);
        return boards;
    }
    public async Task<BoardEntity?> GetBoard(Guid id, CancellationToken cancellationToken)
    {
        var board = await db.Boards.Include(b => b.Tables).Include(b => b.UserBoards).FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
        return board;
    }
}