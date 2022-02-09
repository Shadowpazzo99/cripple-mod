﻿using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Items.Placeable
{
	internal class ExampleLamp : ModItem
	{
		public override void SetDefaults() {
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.ExampleLamp>();
			item.width = 10;
			item.height = 24;
			item.value = 500;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenChair);
			recipe.AddIngredient(ModContent.ItemType<ExampleBlock>(), 10);
			recipe.AddTile(ModContent.TileType<Tiles.ExampleWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}