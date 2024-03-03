namespace myTestApp
{
    public interface IExpenseService
    {
        Task<List<ExpenseEntity>> GetExpensesAsync();
        Task AddAsync(Expense expense);

        Task UpdateAsync(Expense expense);
        Task DeleteAsync(Expense expense);
    }
}