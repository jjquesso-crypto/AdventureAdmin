using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ShipMethodService(AdventureWorksContext context) : IService<Data.Models.ShipMethod, int>
{
    public Task<ShipMethod?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ShipMethod>> GetList(Expression<Func<ShipMethod, bool>> criterio)
    {
        return await context.ShipMethods.Where(criterio)
         .ToListAsync();

    }

    public Task<bool> Guardar(ShipMethod entidad)
    {
        throw new NotImplementedException();
    }
}
