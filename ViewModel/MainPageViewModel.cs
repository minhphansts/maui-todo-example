using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TODO.Model;

namespace TODO.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _count = 0;

        private ObservableCollection<TodoItem> _todoItems;
        public ObservableCollection<TodoItem> TodoItems
        {
            get => _todoItems;
            set
            {
                _todoItems = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddTodoCommand { get; }
        public ICommand ToggleCompletionCommand { get; }

        public MainPageViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            AddTodoCommand = new Command(AddTodo);
            ToggleCompletionCommand = new Command<TodoItem>(ToggleCompletion);
        }

        private void AddTodo()
        {
            TodoItems.Add(new TodoItem { Title = $"New Task {++_count}", IsCompleted = false, CreateDate = DateTime.Now });
        }

        private void ToggleCompletion(TodoItem item)
        {
            item.IsCompleted = !item.IsCompleted;
            item.CompleteDate = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}