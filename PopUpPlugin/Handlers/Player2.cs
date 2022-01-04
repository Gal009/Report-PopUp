using Exiled.Events.EventArgs;
using CustomPlayerEffects;
using Exiled.API.Enums;

namespace PopUpPlugin.Handlers
{
    public class Player2
    {

        private readonly Plugin plugin;
        public Player2(Plugin plugin) => this.plugin = plugin;

        public void OnPlayerVerified(VerifiedEventArgs ev)
        {
            ev.Player.OpenReportWindow(plugin.Config.JoinedServerMessage);
        }
    }
}