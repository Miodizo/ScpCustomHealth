using Exiled.Events.EventArgs.Player;
using PlayerRoles;
namespace ScpCustomHealth
{
    public class EventHandlers
    {
        public void Spawned(SpawnedEventArgs ev)
        {
            switch (ev.Player.Role.Type)
            {
                case RoleTypeId.Scp173:
                    ev.Player.Health = Plugin.Singleton.Config.Scp173health;
                    break;
                case RoleTypeId.Scp049:
                    ev.Player.Health = Plugin.Singleton.Config.Scp049health;
                    break;
                case RoleTypeId.Scp106:
                    ev.Player.Health = Plugin.Singleton.Config.Scp106health;
                    break;
                case RoleTypeId.Scp939:
                    ev.Player.Health = Plugin.Singleton.Config.Scp939health;
                    break;
                case RoleTypeId.Scp096:
                    ev.Player.Health = Plugin.Singleton.Config.Scp096health;
                    break;
                case RoleTypeId.Scp3114:
                    ev.Player.Health = Plugin.Singleton.Config.Scp3114health;
                    break;
            }
        }
    }
}
