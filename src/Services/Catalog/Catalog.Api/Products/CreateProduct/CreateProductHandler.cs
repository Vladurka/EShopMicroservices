using BuildingBlocks.CQRS;
using Catalog.Api.Models;

namespace Catalog.Api.Products.CreateProduct
{
    public record CreateProductCommand (string Name, List<string> Category, string Description,
        string ImageFile, decimal Price) : ICommand<CreateProductResult>;

    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product(command);
            return new CreateProductResult(product.Id);
        }
    }
}
