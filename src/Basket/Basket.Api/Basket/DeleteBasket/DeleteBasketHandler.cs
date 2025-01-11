namespace Basket.Api.Basket.DeleteBasket
{
    public record DeleteBasketCommand(Guid Id) : ICommand<DeleteBasketResult>;
    public record DeleteBasketResult(bool IsSuccessful);

    public class DeleteBasketCommandValidator : AbstractValidator<DeleteBasketCommand>
    {
        public DeleteBasketCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");
        }
    }

    public class DeleteBasketCommandHandler
        : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
        {
            return new DeleteBasketResult(true);
        }
    }
}
