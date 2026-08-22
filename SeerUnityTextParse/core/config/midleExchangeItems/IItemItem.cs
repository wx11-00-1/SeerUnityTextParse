using core.config.commonItem;

namespace core.config.midleExchangeItems
{
	public class IItemItem : CommonItem
	{
		public int TargetId;

		public int ExchangeId;

		public string ExchangeOutId = string.Empty;

		public string ExchangeOutCnt = string.Empty;

		public int SkinId;

		public int ExchangeType;

		public override int GetTargetId()
		{
			return TargetId;
		}

		public override int GetExchangeId()
		{
			return ExchangeId;
		}

		public override string GetExchangeOutId()
		{
			return ExchangeOutId;
		}

		public override string GetExchangeOutCnt()
		{
			return ExchangeOutCnt;
		}

		public override int GetSkinId()
		{
			return SkinId;
		}

		public override int GetExchangeType()
		{
			return ExchangeType;
		}
	}
}
