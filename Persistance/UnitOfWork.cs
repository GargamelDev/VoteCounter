namespace VoutesCounter.Persistance;

public class UnitOfWork : IUnitOfWork
{
    private VoutesCounterDbContext context;

    public UnitOfWork(VoutesCounterDbContext context)
    {
        this.context = context;
    }

    public async Task Complete()
    {
        await this.context.SaveChangesAsync();
    }
}