
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FormulaCuadraticaApp.Models;

namespace FormulaCuadraticaApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double c;

        [ObservableProperty]
        private double x1;

        [ObservableProperty]
        private double x2;

        [RelayCommand]
        private async Task Calcular()
        {
            FormulaCuadratica formula = new FormulaCuadratica(A, B, C);

            if (formula.A == 0)
            {
                await Application.Current!.MainPage!.DisplayAlert("ADVERTENCIA", "El coeficiente 'a' no puede ser cero.", "Aceptar");
            } else
            {
                double discriminante = Math.Pow(formula.B, 2) - (4 * formula.A * formula.C);

                if (discriminante >= 0) {
                    X1 = (- formula.B + Math.Sqrt(discriminante)) / (2 * formula.A);
                    X2 = (- formula.B - Math.Sqrt(discriminante)) / (2 * formula.A);
                } else
                {
                    await Application.Current!.MainPage!.DisplayAlert("ADVERTENCIA", "No se puede calcular la raíz con números negativos.", "Aceptar");
                }
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            C = 0;
            X1 = 0;
            X2 = 0;
        }
    }
}
