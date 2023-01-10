using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JMGMN
{
    internal class GodModeProjectile : ModProjectile
    {
        //set the sprite for the projectile
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 1;
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            //set the stats for it
            Projectile.netImportant = true;
            Projectile.friendly = true;
            Projectile.aiStyle = -1;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.timeLeft = 9999999;
        }

        public override void AI()
        {
            //check if the player not is dead and is in godmode. if so, the constanly move and hover. if not, then kill it.
            Projectile.timeLeft = 9999999;
            Player player = Main.player[Projectile.owner];
            if (player.creativeGodMode && !player.dead)
            {
                Projectile.position = player.position + new Vector2(-2.5f, -60);
            }
            else
            {
                Projectile.Kill();
            }
        }
    }
}
