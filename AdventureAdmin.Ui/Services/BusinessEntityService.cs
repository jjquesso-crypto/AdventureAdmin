using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class BusinessEntityService : IService<Data.Models.BusinessEntity, int>
{
    public Task<BusinessEntity?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<BusinessEntity>> GetList(Expression<Func<BusinessEntity, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(BusinessEntity entidad)
    {
        throw new NotImplementedException();
    }
}
