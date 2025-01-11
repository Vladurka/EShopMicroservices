namespace Basket.Api.Basket.GetBasket
{
    public record GetBasketResponse(ShoppingCart Cart);

    public class GetBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/basket/{id : Guid}", async (Guid id, ISender sender) =>
            {
                var result = await sender.Send(new GetBasketQuery(id));

                var respose = result.Adapt<GetBasketResponse>();

                return Results.Ok(respose);
            })
            .WithName("GetBasketById")
            .Produces<GetBasketResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get Basket By Id")
            .WithDescription("Get Basket By Id");
        }
    }
}
