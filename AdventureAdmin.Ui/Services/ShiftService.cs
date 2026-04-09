using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ShiftService(AdventureWorksContext context) : IService<Data.Models.Shift, int>
{
    public Task<Shift?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Shift>> GetList(Expression<Func<Shift, bool>> criterio)
    {
        return await context.Shifts.Where(criterio)
         .ToListAsync();

    }

    public Task<bool> Guardar(Shift entidad)
    {
        throw new NotImplementedException();
    }
}
