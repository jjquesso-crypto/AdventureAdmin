using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class CultureService(
   AdventureWorksContext context
    ) : IService<Data.Models.Culture, string>
{
    public async Task<Data.Models.Culture?> Buscar(string id)
    {
        return await context.Cultures
                   .FirstOrDefaultAsync(c => c.CultureId == id);
    }

    public async Task<bool> Eliminar(string id)
    {
        var culture = await context.Cultures
                    .FirstOrDefaultAsync(c => c.CultureId == id);

        if (culture == null)
            return false;

        context.Cultures.Remove(culture);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
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
