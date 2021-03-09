using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PaperMods.Items
{
	public class HelloSword: ModItem
	{
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Does more damage to slimes.");
        }

        public override void SetDefaults()
        {
            item.width = 40;
			item.height = 40;
			item.maxStack = 1;
			item.rare = 12;
			item.damage = 1;
			item.melee = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.knockBack = 10;
			item.value = Item.buyPrice(gold:1);
			item.autoReuse = true;
			item.crit = 50;
			item.useStyle = ItemUseStyleID.SwingThrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.AddIngredient(ItemID.Gel);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {

			//if (target.netID == NPCID.BlueSlime)
			//{
			//    target.StrikeNPCNoInteraction(10, item.knockBack, 1);
			//}
			target.AddBuff(BuffID.Frostburn, 10 * 60);
			if(target.netID == NPCID.BlueSlime ||
				target.netID == NPCID.GreenSlime)
            {
				target.StrikeNPCNoInteraction(900, 50, 1);
            }
        }



























    }
	
}