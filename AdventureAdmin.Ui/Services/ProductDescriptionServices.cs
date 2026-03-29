using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ProductDescriptionServices(AdventureWorksContext context) : Aplicada1.Core.IService<ProductDescription, int>
{
    public Task<ProductDescription?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductDescription>> GetList(Expression<Func<ProductDescription, bool>> criterio)
    {
        return await context.ProductDescriptions.Where(criterio)
         .ToListAsync();

    }

    public Task<bool> Guardar(ProductDescription entidad)
    {
        throw new NotImplementedException();
    }
}