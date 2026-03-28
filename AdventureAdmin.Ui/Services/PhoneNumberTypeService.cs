using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class PhoneNumberTypeService : IService<Data.Models.PhoneNumberType, int>
{
    public Task<PhoneNumberType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<PhoneNumberType>> GetList(Expression<Func<PhoneNumberType, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(PhoneNumberType entidad)
    {
        throw new NotImplementedException();
    }
}
