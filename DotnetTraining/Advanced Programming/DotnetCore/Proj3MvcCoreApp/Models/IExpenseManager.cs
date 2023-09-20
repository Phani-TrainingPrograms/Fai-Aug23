using Microsoft.EntityFrameworkCore;

namespace Proj3MvcCoreApp.Models
{
    public interface IExpenseManager
    {
        void AddExpense(Expense expense);
        void RemoveExpense(int expenseId);
        
        List<Expense> GetAllExpenses();
        void UpdateExpense(Expense expense);
        Expense GetExpense(int expenseId);  
    }

    public class ExpenseManager : IExpenseManager
    {
        private readonly ExpenseDbContext context;
        public ExpenseManager(ExpenseDbContext context)
        {
            this.context = context;
        }
        public void AddExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        public List<Expense> GetAllExpenses()
        {
            return context.Expenses.ToList();
        }

        public Expense GetExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public void RemoveExpense(int expenseId)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpense(Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
