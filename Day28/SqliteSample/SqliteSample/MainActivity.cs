using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace SqliteSample
{
    [Activity(Label = "SqliteSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private TodoItemRepository repository;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            repository = new TodoItemRepository();

            // Get our button from the layout resource,
            // and attach an event to it
            Button createItemButton = FindViewById<Button>(Resource.Id.createItemButton);
            
            createItemButton.Click += CreateItemButton_Click;
        }

        async void CreateItemButton_Click(object sender, EventArgs e)
        {
            var newToDoItem = new ToDoItem
            {
                Title = "New Item",
                Description = "Some Description",
                CreatedAt = DateTime.UtcNow,
                IsComplete = false
            };
            await repository.AddToDoItem(newToDoItem); 

            var items = await repository.GetToDoItems();
            Toast.MakeText(this, "Item created, there are " + items.Count + " in the database", ToastLength.Long).Show();
        }
    }
}