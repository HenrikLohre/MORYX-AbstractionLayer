﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Marvin.ClientFramework.Base;
using Marvin.Container;
using Marvin.Controls;
using Marvin.Serialization;

namespace Marvin.Resources.UI.Interaction
{
    /// <summary>
    /// View model for editing method parameters
    /// </summary>
    [Plugin(LifeCycle.Transient, typeof(IMethodInvocationViewModel))]
    internal class MethodInvocationViewModel : DialogScreen, IMethodInvocationViewModel
    {
        #region Dependencies

        /// <summary>
        /// Resource controller for the method invocation
        /// </summary>
        public IResourceController ResourceController { get; set; }

        #endregion

        private readonly ResourceMethodViewModel _methodViewModel;

        public EntryViewModel Parameters { get; private set; }

        public string Description => _methodViewModel.Description;

        public ICommand InvokeCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        private EntryViewModel _invocationResult;
        public EntryViewModel InvocationResult
        {
            get
            {
                return _invocationResult;
            }
            private set
            {
                _invocationResult = value;
                NotifyOfPropertyChange();
            }
        }

        public MethodInvocationViewModel(IResourceMethodViewModel methodViewModel)
        {
            // TODO: I don't really like this
            _methodViewModel = (ResourceMethodViewModel)methodViewModel;
            // Clone the given parameters
            Parameters = new EntryViewModel(methodViewModel.Parameters);
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            InvokeCommand = new AsyncCommand(Invoke, CanInvoke);
            CloseCommand = new DelegateCommand(Cancel);

            DisplayName = $"{_methodViewModel.DisplayName} Parameters:";
        }

        private async Task Invoke(object obj)
        {
            var result = await ResourceController.InvokeMethod(_methodViewModel.ResourceId, _methodViewModel.Model);

            if (result == null)
                InvocationResult = null;
            else if (result.Value.Type >= EntryValueType.Class)
                InvocationResult = new EntryViewModel(result);
            else
                InvocationResult = new EntryViewModel(new List<Entry> {result});
        }

        private bool CanInvoke(object obj)
        {
            return true; // Validate parameters
        }

        private void Cancel(object obj)
        {
            TryClose(true);
        }
    }
}