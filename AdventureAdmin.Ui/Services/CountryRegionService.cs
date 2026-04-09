using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class CountryRegionService(AdventureWorksContext context) : IService<Data.Models.CountryRegion, int>
{
    public Task<CountryRegion?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CountryRegion>> GetList(Expression<Func<CountryRegion, bool>> criterio)
    {
        return await context.CountryRegions
    .Where(criterio)
    .ToListAsync();

    }

    public Task<bool> Guardar(CountryRegion entidad)
    {
        throw new NotImplementedException();
    }
}
