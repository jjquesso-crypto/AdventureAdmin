using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class CultureService : IService<Data.Models.Culture, int>
{
    public Task<Culture?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Culture>> GetList(Expression<Func<Culture, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Culture entidad)
    {
        throw new NotImplementedException();
    }
}
