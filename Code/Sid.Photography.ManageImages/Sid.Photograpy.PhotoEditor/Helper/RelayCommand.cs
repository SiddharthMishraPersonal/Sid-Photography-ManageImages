﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sid.Photograpy.PhotoEditor.Helper
{
    /// <summary>
    /// To register commands in MMVM pattern
    /// </summary>
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        /// <summary>
        /// Constructer takes Execute events to register in CommandManager.
        /// </summary>
        /// <param name="execute">Execute method as action.</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
            try
            {
                if (null == execute)
                {
                    throw new NotImplementedException("Not implemented");
                }

                _execute = execute;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Constructer takes Execute and CanExcecute events to register in CommandManager.
        /// </summary>
        /// <param name="execute">Execute method as action.</param>
        /// <param name="canExecute">CanExecute method as return bool type.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            try
            {
                if (null == execute)
                {
                    _execute = null;
                    throw new NotImplementedException("Not implemented");
                }

                _execute = execute;
                _canExecute = canExecute;
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Can Executed Changed Event
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        /// <summary>
        /// Execute method.
        /// </summary>
        /// <param name="parameter">Method paramenter.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// CanExecute method.
        /// </summary>
        /// <param name="parameter">Method paramenter.</param>
        /// <returns>Return true if can execute.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }
    }
}
