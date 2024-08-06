
namespace ProductManager.Services
{
    public sealed class ProductService(ILogger<ProductService> logger) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.LogInformation("ProductService running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1_000, stoppingToken);
            }
        }
    }
}
