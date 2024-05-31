using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace Test.Content.Items.Materials { //����� ���������� ���
	public class CoolStar : ModItem {
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10; //���-�� ��������� ��� �������� ����������� � ������ �����������
		}

		public override void SetDefaults() {
			Item.width = 32; //������ �������
			Item.height = 32; //������ �������
			Item.maxStack = 9999; //������������ ���-�� ��������� � ������
			Item.value = 100; //���� � ������ �������
			Item.rare = ItemRarityID.Green; //��������
		}

		public override void AddRecipes() { //������
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FallenStar,1); //������ 75
			recipe.AddIngredient(ItemID.CrimtaneOre,3); //����������� ����
			recipe.AddTile(TileID.Anvils); //�� ����������
			recipe.Register();
		}
	}
}