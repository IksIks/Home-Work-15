﻿using System.Linq;
using ДЗ_11.Models;
using ДЗ_11.Services;

namespace ДЗ_11.Data
{
    internal class HelpClass
    {
        //public static ObservableCollection<Client> Clients { get; set; } = new ObservableCollection<Client>();
        public static Client TempClient { get; set; } = new Client();
        //private double account;
        //public double GetCurrentAccount(Cash cash, NonDepositAccount nonDepositAccount, DepositAccount deposit)
        //{
        //    switch(cash)
        //    {
        //        case Cash.RUB: return 
        //    }
        //}

        public static double GetDigitPath(string temp) => double.Parse(string.Join( "", temp.Where(d => char.IsDigit(d))));

    }
}
