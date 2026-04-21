using AdventureAdmin.Ui.Tests.Infrastructure;
using AdventureAdmin.Ui.Services;
using Microsoft.EntityFrameworkCore;
using ProductDescriptionEntity = AdventureAdmin.Data.Models.ProductDescription;

namespace AdventureAdmin.Ui.Tests.Services;

public class ProductDescriptionServiceTests
{
    [Fact]
    public async Task Buscar_CuandoExisteProductDescription_RetornaEntidad()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.ProductDescriptions.Add(CreateProductDescription(id: 1, description: "Es gris"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ProductDescriptionService(context);

        var result = await service.Buscar(1);

        Assert.NotNull(result);
        Assert.Equal(1, result!.ProductDescriptionId);
        Assert.Equal("Es gris", result.Description);
    }

    [Fact]
    public async Task Buscar_CuandoNoExisteProductDescription_RetornaNull()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new ProductDescriptionService(context);

        var result = await service.Buscar(999);

        Assert.Null(result);
    }

    [Fact]
    public async Task GetList_CuandoSeFiltraPorDescripcion_RetornaCoincidencias()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.ProductDescriptions.AddRange(
                CreateProductDescription(id: 1, description: "Es gris"),
                CreateProductDescription(id: 2, description: "Es verde"),
                CreateProductDescription(id: 3, description: "Es negro"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ProductDescriptionService(context);

        var result = await service.GetList(p => p.Description.Contains("Es"));

        Assert.Equal(2, result.Count);
        Assert.Contains(result, p => p.ProductDescriptionId == 1);
        Assert.Contains(result, p => p.ProductDescriptionId == 3);
        Assert.DoesNotContain(result, p => p.ProductDescriptionId == 2);
    }

    [Fact]
    public async Task Guardar_CuandoProductDescriptionEsValida_InsertaCorrectamente()
    {
        // Arrange
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new ProductDescriptionService(context);
        var newDescription = CreateProductDescription(id: 10, description: "Parte gris");

        // Act
        var result = await service.Guardar(newDescription);

        // Assert
        Assert.True(result);
        var savedEntity = await context.ProductDescriptions.FirstOrDefaultAsync(p => p.ProductDescriptionId == 10);
        Assert.NotNull(savedEntity);
        Assert.Equal("Parte gris", savedEntity!.Description);
    }

    [Fact]
    public async Task Modificar_CuandoProductDescriptionExiste_ActualizaDatosYFecha()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.ProductDescriptions.Add(CreateProductDescription(id: 20, description: "Original description"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ProductDescriptionService(context);
        var updated = CreateProductDescription(id: 20, description: "Modificar la descripcion");
        var beforeUpdate = DateTime.Now;

        var wasUpdated = await service.Modificar(updated);

        Assert.True(wasUpdated);
        Assert.True(updated.ModifiedDate >= beforeUpdate);

        var saved = await context.ProductDescriptions.FirstOrDefaultAsync(p => p.ProductDescriptionId == 20);
        Assert.NotNull(saved);
        Assert.Equal("Modificar la descripcion\"", saved!.Description);
    }

    [Fact]
    public async Task Eliminar_CuandoExisteProductDescription_EliminaCorrectamente()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.ProductDescriptions.Add(CreateProductDescription(id: 5, description: "Elimina"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new ProductDescriptionService(context);

        var result = await service.Eliminar(5);

        Assert.True(result);
        Assert.Empty(context.ProductDescriptions);
    }

    private static ProductDescriptionEntity CreateProductDescription(int id, string description)
    {
        return new ProductDescriptionEntity
        {
            ProductDescriptionId = id,
            Description = description,
            Rowguid = Guid.NewGuid(),
            ModifiedDate = DateTime.Now
        };
    }
}