using Terraria.ModLoader;
using Terraria.ID;

namespace VanitiesOfRyuse
{
	public class VanitiesOfRyuse : Mod
	{
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this.GetItem("MAIDChanHair"), 1);
            recipe.AddRecipe();
        }
	}
}