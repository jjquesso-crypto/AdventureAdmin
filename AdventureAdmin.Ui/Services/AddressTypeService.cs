using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class AddressTypeService : IService<Data.Models.AddressType, int>
{
    public Task<AddressType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<AddressType>> GetList(Expression<Func<AddressType, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(AddressType entidad)
    {
        throw new NotImplementedException();
    }
}
