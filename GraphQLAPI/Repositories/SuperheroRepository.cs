﻿namespace GraphQLAPI.Repositories;

public class SuperheroRepository : ISuperheroRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public SuperheroRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}