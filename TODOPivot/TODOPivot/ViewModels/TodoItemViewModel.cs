﻿using System;
using System.Collections.Generic;
using System.Linq;
using TODOPivot.Models;

namespace TODOPivot.ViewModels
{
    public class TodoItemViewModel : Mvvm.ViewModelBase
    {
        public TodoItemViewModel(Models.TodoItem todo)
        {
            this.TodoItem = todo;
        }

        private Models.TodoItem _TodoItem = default(Models.TodoItem);
        public Models.TodoItem TodoItem { get { return _TodoItem; } set { Set(ref _TodoItem, value); } }
    }
}
