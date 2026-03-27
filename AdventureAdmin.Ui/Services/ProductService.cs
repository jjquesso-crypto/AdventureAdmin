using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ProductService : Aplicada1.Core.IService<Product, int>
{
    public Task<Product?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetList(System.Linq.Expressions.Expression<Func<Product, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Product entidad)
    {
        throw new NotImplementedException();
    }
}
