using core.config.itemsOptimize;

namespace core.config.commonItem
{
	public class CommonItem : ItemData
	{
		public int ID;

		public string Name = string.Empty;

		public int Max;

		public int catID;

		public override int GetID()
		{
			return ID;
		}

		public override string GetName()
		{
			return Name;
		}

		public override int GetMax()
		{
			return Max;
		}

		public override int GetCatID()
		{
			return catID;
		}
	}
}
