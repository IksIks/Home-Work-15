﻿using System.Collections.ObjectModel;
using ДЗ_11.Models;

namespace ДЗ_11.Data
{
    internal class HelpClass
    {
        public static ObservableCollection<Client> Clients { get; set; }
        public static Client TempClient { get; set; } = new Client();

        //public static Tuple<string, string, double> ValuteUSDCurse;
        //public static Tuple<string, string, double> ValuteEURCurse;
        //public static double GetDigitPath(string temp) => double.Parse(string.Join( "", temp.Where(d => char.IsDigit(d))));

        public HelpClass()
        {

        }
    }
}
