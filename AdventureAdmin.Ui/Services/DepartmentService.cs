using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class DepartmentService : IService<Data.Models.Department, int>
{
    public Task<Data.Models.Department?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Data.Models.Department>> GetList(Expression<Func<Data.Models.Department, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Data.Models.Department entidad)
    {
        throw new NotImplementedException();
    }
}
