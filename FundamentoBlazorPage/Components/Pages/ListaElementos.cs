using Microsoft.AspNetCore.Components;

namespace FundamentoBlazorPage.Components.Pages
{
    public partial class ListaElementos : ComponentBase
    {
        private List<string> elementos = new();
        private string nuevoElemento; 

        private void AgregarElementos()
        {
            if(!string.IsNullOrWhiteSpace(nuevoElemento))
            {
                elemento.Add(nuevoElemento);    
                nuevoElemento = string.Empty;   
            }
        }
    }
}
