using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JMGMN
{
    class ModdedPlayer : ModPlayer
    {
        public bool SpawnedInGod = false;
        public override void PostUpdate()
        {
            //check if the player is in godmode, and spawn in the icon when in godmode
            if (Player.creativeGodMode)
            {
                if (SpawnedInGod == false)
                {
                    Projectile.NewProjectile(Player.GetSource_FromThis(), Player.position, Vector2.Zero, ModContent.ProjectileType<GodModeProjectile>(), 0, 0f, Player.whoAmI);
                    SpawnedInGod = true;
                }
            } else
            {
                SpawnedInGod = false;
            }
            base.PostUpdate();
        }
    }
}
