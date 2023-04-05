using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCRUD.ViewModel;

//observableObject
partial class TestViewModel : ObservableObject
{
    //con toolkits dice q se crea la propiedad de la class
    //privada para que el observableproperty me cree la publica
    [ObservableProperty]//con esta clase defino que va a ser accedida en una vista
    //propiedad publica
    private string text;//propiedad de la clase privada

    //creamos una propiedad contador
    [ObservableProperty]
    private int count;

    //generar un Command o metodo publico
    //el metodo es para cuando haga clic cambie la propiedad de la clase text
    //publica
    //para poder usar el binding con el command se debe usar el decorador relay
    [RelayCommand] //usado para publicar el metodo o que sea exportable
    public void CambiarText()
    {
        Count++;
        Text = $"Holi mor, esta es la publica!!  {Count}";
    }


}

