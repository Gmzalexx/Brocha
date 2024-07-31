using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brocha
{
    partial class brochamvvm : ObservableObject
    {
        [ObservableProperty]
        public string area;

        [ObservableProperty]
        public string precioPorM2;

        [ObservableProperty]
        public string costoTotal;

        [RelayCommand]
        private void CalcularCosto()
        {
            if (double.TryParse(Area, out double areaValue) && double.TryParse(PrecioPorM2, out double precioPorM2Value))
            {
                double costoTotalValue = areaValue * precioPorM2Value;
                CostoTotal = costoTotalValue.ToString("F2"); 
            }
            else
            {
                CostoTotal = "Ingresa los metros deseados";
            }
        }
    }
}
