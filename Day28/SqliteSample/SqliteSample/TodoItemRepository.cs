using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqliteSample
{
    public class TodoItemRepository
    {
        private readonly SQLiteAsyncConnection sqlConnection;

        public TodoItemRepository()
        {
            sqlConnection = new SQLiteAsyncConnection(DatabaseFilePathRetriever.GetPath());
            sqlConnection.CreateTableAsync<ToDoItem>();
        }

        //Get all ToDoItems
        public async Task<List<ToDoItem>> GetToDoItems()
        {
            return  await sqlConnection.Table<ToDoItem>().ToListAsync(); //Careful with ToList calls on databases!
        }

        //Get specific ToDoItem
        public async Task<ToDoItem> GetToDoItem(int id)
        {
            return await sqlConnection.Table<ToDoItem>().Where(tdi => tdi.Id == id).FirstOrDefaultAsync();
        }

        //Delete specific ToDoItem
        public async Task DeleteToDoItem(ToDoItem todoItem)
        {
            await sqlConnection.DeleteAsync(todoItem);
        }

        //Add new ToDoItem to DB
        public async Task AddToDoItem(ToDoItem todoItem)
        {
            await sqlConnection.InsertAsync(todoItem);
        }
    }
}

