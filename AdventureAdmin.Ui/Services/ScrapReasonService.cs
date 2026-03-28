using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ScrapReasonService : IService<Data.Models.ScrapReason, int>
{
    public Task<Data.Models.ScrapReason?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Data.Models.ScrapReason>> GetList(Expression<Func<Data.Models.ScrapReason, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Data.Models.ScrapReason entidad)
    {
        throw new NotImplementedException();
    }
}
