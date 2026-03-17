using AdventureAdmin.Data.Context;
using AdventureAdmin.Data.Models;

namespace AdventureAdmin.Data.Services;

public class ProductDescriptionService
{
    private readonly AdventureWorksContext _context;

    public ProductDescriptionService(AdventureWorksContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("La descripción es obligatoria.");

        if (description.Length > 400)
            throw new ArgumentException("Máximo 400 caracteres.");

        var productDescription = new ProductDescription
        {
            Description = description.Trim(),
            Rowguid = Guid.NewGuid(),
            ModifiedDate = DateTime.Now
        };

        _context.ProductDescriptions.Add(productDescription);
        await _context.SaveChangesAsync();
    }
}