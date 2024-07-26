using Exiled.API.Features;
using System;
using Event = Exiled.Events.Handlers;
namespace ScpCustomHealth
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "Miodzio";
        public override string Name => "ScpCustomHealth";
        public override Version Version => new(1, 0, 2);
        public override Version RequiredExiledVersion => new(8, 11, 0);

        public static Plugin Singleton;
        public static EventHandlers Handlers;

        public override void OnEnabled()
        {
            Singleton = this;
            Handlers = new EventHandlers();
            Event.Player.Spawned += Handlers.Spawned;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;
            Handlers = null;
            Event.Player.Spawned -= Handlers.Spawned;
            base.OnDisabled();
        }
    }
}
