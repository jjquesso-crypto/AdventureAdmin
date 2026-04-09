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
    public Task<ContactType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ContactType>> GetList(Expression<Func<ContactType, bool>> criterio)
    {
        return await context.ContactTypes
    .Where(criterio)
    .ToListAsync();

    }

    public Task<bool> Guardar(ContactType entidad)
    {
        throw new NotImplementedException();
    }
}
