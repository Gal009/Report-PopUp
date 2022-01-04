using Exiled.API.Interfaces;
using System.ComponentModel;

namespace PopUpPlugin
{
    public sealed class Config : IConfig
    {

        [Description("Se o plugin ta habilitado")]
        public bool IsEnabled { get; set; } = true;

        [Description("A mensagem que aparece no poput")]
        public string JoinedServerMessage { get; set; } = "Bem vindo ao servidor de jogos do zEscurera";
    }
}