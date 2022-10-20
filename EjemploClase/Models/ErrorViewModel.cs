namespace Taller2_clase5.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

}

    public class Cliente
    {
        private int edad;
        private string name;

        public Cliente()
        {
        }

        public int Edad { get => edad; set => edad = value; }
        public string Name { get => name; set => name = value; }
    }
