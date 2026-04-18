using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class ProductDescriptionService(AdventureWorksContext context) : Aplicada1.Core.IService<ProductDescription, int>
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

    public async Task<bool> Insertar(ProductDescription entidad)
    {
        entidad.Rowguid = Guid.NewGuid();
        entidad.ModifiedDate = DateTime.Now;
        await context.ProductDescriptions.AddAsync(entidad);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(ProductDescription entidad)
    {
        if (entidad.ProductDescriptionId == 0)
            return await Insertar(entidad);
        else
            return await Modificar(entidad);
    }
    public async Task<bool> Modificar(ProductDescription entidad)
    {
        entidad.ModifiedDate = DateTime.Now;
        context.ProductDescriptions.Update(entidad);
        return await context.SaveChangesAsync() > 0;
    }
    private async Task<bool> Existe(int id)
    {
        return await context.ProductDescriptions
            .AnyAsync(p => p.ProductDescriptionId == id);
    }
}