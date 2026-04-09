using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class SpecialOfferService(AdventureWorksContext context) : IService<Data.Models.SpecialOffer, int>
{
    public Task<SpecialOffer?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<SpecialOffer>> GetList(Expression<Func<SpecialOffer, bool>> criterio)
    {
        return await context.SpecialOffers.Where(criterio)
         .ToListAsync();

    }

    public Task<bool> Guardar(SpecialOffer entidad)
    {
        throw new NotImplementedException();
    }
}
