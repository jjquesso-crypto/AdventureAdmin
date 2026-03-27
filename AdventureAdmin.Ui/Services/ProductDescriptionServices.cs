using AdventureAdmin.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ProductDescriptionServices : Aplicada1.Core.IService<ProductDescription, int>
{
    public Task<ProductDescription?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProductDescription>> GetList(Expression<Func<ProductDescription, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(ProductDescription entidad)
    {
        throw new NotImplementedException();
    }
}