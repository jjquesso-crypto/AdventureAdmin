using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class CultureService(AdventureWorksContext context) : IService<Data.Models.Culture, int>
{
    public Task<Data.Models.Culture?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.Culture>> GetList(Expression<Func<Data.Models.Culture, bool>> criterio)
    {
        return await context.Cultures.Where(criterio)
           .ToListAsync();

    }

    public Task<bool> Guardar(Data.Models.Culture entidad)
    {
        throw new NotImplementedException();
    }
}
