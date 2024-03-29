﻿using System.Windows;
using System.Windows.Input;
using ДЗ_11.Data;
using ДЗ_11.Infrastructure.Commands;
using ДЗ_11.Models;
using ДЗ_11.ViewModels.Base;

namespace ДЗ_11.ViewModels
{
    internal class AddClientViewModel : ViewModel
    {
        public Client NewClient
        {
            get { return newClient; }
            set { Set(ref newClient, value); }
        }
        private Client newClient;
        public AddClientViewModel()
        {
            CreateNewClientCommand = new RelayCommand(OnCreateNewClientCommandExecuted, CanCreateNewClientCommandExecute);
            StopCreateNewClientCommand = new RelayCommand(OnStopCreateNewClientCommandExecuted, CanStopCreateNewClientCommandExecute);
            NewClient = new Client();
        }

        #region Команда добавления нового клиента
        /// <summary>Команда добавления нового клиента</summary>
        public ICommand CreateNewClientCommand { get; }
        private void OnCreateNewClientCommandExecuted(object parameter)
        {
            HelpClass.TempClient = NewClient;
            Application.Current.Windows[1].Close();
        }
        private bool CanCreateNewClientCommandExecute(object parameter)
        {
            if (newClient.Name != null && NewClient.LastName != null && NewClient.Patronymic != null && NewClient.Passport != null && NewClient.PhoneNumber != null)
                return true;
            return false;
        }
        #endregion


        #region Команда отмены создания нового клиента
        /// <summary>Команда отмены создания нового клиента</summary>
        public ICommand StopCreateNewClientCommand { get; }
        private void OnStopCreateNewClientCommandExecuted(object parameter)
        {
            Application.Current.Windows[1].Close();
            HelpClass.TempClient = new Client();
        }
        private bool CanStopCreateNewClientCommandExecute(object parameter) => true;
        #endregion

    }
}
