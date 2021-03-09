using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PaperMods.Items
{
    public class WandOfBiomes : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Changes its attack based on what biome you are in.");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;

            item.rare = ItemRarityID.Green;
            item.value = Item.buyPrice(gold: 1);
            item.useTime = 40;
            item.useAnimation = 20;

            item.magic = true;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.shoot = ModContent.ProjectileType<>
            item.damage = 20;

        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ItemID.DirtBlock, 1);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }

        public override void OnConsumeItem(Player player)
        {
        }
    }

}