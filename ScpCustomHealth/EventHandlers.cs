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
                    ev.Player.Health = Plugin.Singleton.Config.Scp173helath;
                    break;
                case RoleTypeId.Scp049:
                    ev.Player.Health = Plugin.Singleton.Config.Scp049helath;
                    break;
                case RoleTypeId.Scp106:
                    ev.Player.Health = Plugin.Singleton.Config.Scp106helath;
                    break;
                case RoleTypeId.Scp939:
                    ev.Player.Health = Plugin.Singleton.Config.Scp939helath;
                    break;
                case RoleTypeId.Scp096:
                    ev.Player.Health = Plugin.Singleton.Config.Scp096helath;
                    break;
                case RoleTypeId.Scp3114:
                    ev.Player.Health = Plugin.Singleton.Config.Scp3114helath;
                    break;
            }
        }
    }
}
