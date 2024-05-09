﻿using Domain.Interfaces.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.UnitOfWorks;

public abstract class UnitOfWork : IUnitOfWork
{
    protected readonly DbContext _dbContext;

    public UnitOfWork(DbContext dbContext) => _dbContext = dbContext;

    public virtual void Dispose() => _dbContext?.Dispose();
    public virtual void Save() => _dbContext?.SaveChanges();
}
