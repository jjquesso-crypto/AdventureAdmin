using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ProductCategoryService : IService<Data.Models.ProductCategory, int>
{
    public Task<ProductCategory?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProductCategory>> GetList(Expression<Func<ProductCategory, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(ProductCategory entidad)
    {
        throw new NotImplementedException();
    }
}
