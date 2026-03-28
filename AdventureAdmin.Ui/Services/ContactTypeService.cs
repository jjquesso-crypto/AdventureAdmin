using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ContactTypeService : IService<Data.Models.ContactType, int>
{
    public Task<ContactType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ContactType>> GetList(Expression<Func<ContactType, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(ContactType entidad)
    {
        throw new NotImplementedException();
    }
}
