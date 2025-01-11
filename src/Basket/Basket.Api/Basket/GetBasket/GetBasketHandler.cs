namespace Basket.Api.Basket.GetBasket
{
    public record GetBasketQuery(Guid Id) : IQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart Cart);

    public class GetBasketQueryHandler
        : IQueryHandler<GetBasketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
        {
            //var basket = await repository.GetBasket(query.UserId);

            return new GetBasketResult(new ShoppingCart(Guid.NewGuid()));
        }
    }
}
