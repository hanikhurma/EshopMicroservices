using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;
using System.Windows.Input;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category,
        string Description, string ImageFile, decimal Price)
        :ICommand<CreateProductResult>;
  

    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler :
        ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle
            (CreateProductCommand command, CancellationToken cancellationToken)
        {
            //create Product entity from command object 1
            //save to database 2
            //return CreateProductResult result 3

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price,
            };
            return new CreateProductResult(Guid.NewGuid());           
        }
    }
}
