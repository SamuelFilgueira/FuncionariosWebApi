using System.Text.Json.Serialization;

namespace FuncionariosWebApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria

    }
}
