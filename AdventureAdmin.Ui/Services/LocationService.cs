using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class LocationService : IService<Data.Models.Location, int>
{
    public Task<Data.Models.Location?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Data.Models.Location>> GetList(Expression<Func<Data.Models.Location, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Data.Models.Location entidad)
    {
        throw new NotImplementedException();
    }
}
