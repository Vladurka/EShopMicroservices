namespace Basket.Api.Basket.DeleteBasket
{
    public record DeleteBasketResponse(bool IsSuccessful);

    public class DeleteBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/basket/{id : Guid}", async (Guid id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteBasketCommand(id));

                var response = result.Adapt<DeleteBasketResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteBasket")
            .Produces<DeleteBasketResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete Basket")
            .WithDescription("Delete Basket");
        }
    }
}
