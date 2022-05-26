namespace ConferencePlanner.GraphQL;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.DataLoader;
using HotChocolate;

public class Query
{
    public Task<IQueryable<Speaker>> GetSpeakers([Service] ApplicationDbContext context) =>
        context.Speakers;

}