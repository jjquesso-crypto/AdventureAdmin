using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ContactTypeService(AdventureWorksContext context) : IService<Data.Models.ContactType, int>
{
    public Task<Data.Models.ContactType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.ContactType>> GetList(Expression<Func<Data.Models.ContactType, bool>> criterio)
    {
        return await context.ContactTypes
    .Where(criterio)
    .ToListAsync();

    }

    public Task<bool> Guardar(Data.Models.ContactType entidad)
    {
        throw new NotImplementedException();
    }
}
