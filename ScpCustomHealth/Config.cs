using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ScpCustomHealth
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Defines SCP-173 Health")]
        public float Scp173health { get; set; } = 4500f;

        [Description("Defines SCP-106 Health")]
        public float Scp106health { get; set; } = 2300f;

        [Description("Defines SCP-049 Health")]
        public float Scp049health { get; set; } = 2300f;

        [Description("Defines SCP-096 Health")]
        public float Scp096health { get; set; } = 2500f;

        [Description("Defines SCP-939 Health")]
        public float Scp939health { get; set; } = 1250f;

        [Description("Defines SCP-3114 Health")]
        public float Scp3114health { get; set; } = 2700f;
    }
}
