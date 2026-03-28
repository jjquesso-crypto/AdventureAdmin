using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class SpecialOfferService : IService<Data.Models.SpecialOffer, int>
{
    public Task<SpecialOffer?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<SpecialOffer>> GetList(Expression<Func<SpecialOffer, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(SpecialOffer entidad)
    {
        throw new NotImplementedException();
    }
}
