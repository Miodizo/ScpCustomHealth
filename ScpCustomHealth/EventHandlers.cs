using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScpCustomHealth
{
    public class EventHandlers
    {
        public void Spawned(SpawnedEventArgs ev)
        {
            switch (ev.Player.Role.Type)
            {
                case PlayerRoles.RoleTypeId.Scp173:
                    ev.Player.Health = Plugin.Singleton.Config.Scp173helath;
                    break;
                case PlayerRoles.RoleTypeId.Scp049:
                    ev.Player.Health = Plugin.Singleton.Config.Scp049helath;
                    break;
                case PlayerRoles.RoleTypeId.Scp106:
                    ev.Player.Health = Plugin.Singleton.Config.Scp106helath;
                    break;
                case PlayerRoles.RoleTypeId.Scp939:
                    ev.Player.Health = Plugin.Singleton.Config.Scp939helath;
                    break;
                case PlayerRoles.RoleTypeId.Scp096:
                    ev.Player.Health = Plugin.Singleton.Config.Scp096helath;
                    break;
            }
        }
    }
}
