using AdventureAdmin.Data.Context;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class DepartmentService(AdventureWorksContext context) : IService<Data.Models.Department, int>
{
    public Task<Data.Models.Department?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.Department>> GetList(Expression<Func<Data.Models.Department, bool>> criterio)
    {
        return await context.Departments.Where(criterio)
         .ToListAsync();

    }

    public Task<bool> Guardar(Data.Models.Department entidad)
    {
        throw new NotImplementedException();
    }
}
