using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using ForgottenMemories;

namespace ForgottenMemories.Buffs
{
	public class BlightCell : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = false;
			DisplayName.SetDefault("BlightCell");
		}
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<BTFANPC>(mod).BlightCelled = true;
		}
	}
}