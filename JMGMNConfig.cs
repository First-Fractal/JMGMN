using System;
using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace JMGMN
{
    [Label("$Mods.JMGMN.Config.Label")]
    public class JMGMNConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        public static JMGMNConfig Instance;

        [Header("$Mods.JMGMN.Config.Header.GeneralOptions")]

        [Label("$Mods.JMGMN.Config.Hover.Label")]
        [Tooltip("$Mods.JMGMN.Config.Hover.Tooltip")]
        [DefaultValue(60)]
        public int hover;
    }
}
