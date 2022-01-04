using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;

namespace PopUpPlugin
{
    public class Plugin : Plugin<Config>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 0);

        public Handlers.Player2 player;

        public override void OnEnabled()
        {

            player = new Handlers.Player2(this);

            Player.Verified += player.OnPlayerVerified;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Verified -= player.OnPlayerVerified;

            player = null;

            base.OnDisabled();
        }
    }
}