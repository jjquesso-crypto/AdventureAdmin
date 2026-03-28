using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class PersonService : IService<Data.Models.Person, int>
{
    public Task<Data.Models.Person?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Data.Models.Person>> GetList(Expression<Func<Data.Models.Person, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Data.Models.Person entidad)
    {
        throw new NotImplementedException();
    }
}
