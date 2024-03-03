using Microsoft.EntityFrameworkCore;

namespace myTestApp
{
    public class ExpenseService : IExpenseService
    {
        private readonly AppDbContext _dbContext;

        public ExpenseService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ExpenseEntity>> GetExpensesAsync() 
        {
            return await _dbContext.Expenses.ToListAsync();
        }

        public async Task AddAsync(Expense expense)
        {
            await _dbContext.Expenses.AddAsync(new ExpenseEntity { 
                Description = expense.Description,
                Value = expense.Value,
                Category = expense.Category,
                PaymentForm = expense.PaymentForm
            });

            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Expense expense)
        {
            var storedExpense = await _dbContext.Expenses.FindAsync(expense.Id);
            if (storedExpense == null)
                throw new Exception();

            storedExpense.Description = expense.Description;
            storedExpense.Value = expense.Value;
            storedExpense.PaymentForm = expense.PaymentForm;
            storedExpense.Category = expense.Category;

            _dbContext.Expenses.Update(storedExpense);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Expense expense)
        {
            var storedExpense = await _dbContext.Expenses.FindAsync(expense.Id);
            if (storedExpense == null)
                throw new Exception();
            _dbContext.Expenses.Remove(storedExpense);
            await _dbContext.SaveChangesAsync();
        }
    }
}
