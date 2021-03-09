using Terraria.ID;
using Terraria.ModLoader;

namespace PaperMods.Items
{
    public class Fitbit : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a fitbit!");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = ItemRarityID.Yellow;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock,5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,2);
			recipe.AddRecipe();
            // Recipes here. See Basic Recipe Guide

        }
    }
}