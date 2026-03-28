using AdventureAdmin.Data.Models;
using Aplicada1.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdventureAdmin.Ui.Services;

public class CurrencyService : IService<Data.Models.Currency, int>
{
    public Task<Currency?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Currency>> GetList(Expression<Func<Currency, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Currency entidad)
    {
        throw new NotImplementedException();
    }
}
