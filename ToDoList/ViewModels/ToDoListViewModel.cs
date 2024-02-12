using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using ToDoList.DataModels;

namespace ToDoList.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {
        public ToDoListViewModel(IEnumerable<ToDoItem> items)
        {
            ListItems = new ObservableCollection<ToDoItem>(items);
        }

        public ObservableCollection<ToDoItem> ListItems { get; }

        public void CheckBox_Checked(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.DataContext is ToDoItem task)
            {
                task.IsChecked = checkBox.IsChecked ?? false;
            }
        }
    }
}