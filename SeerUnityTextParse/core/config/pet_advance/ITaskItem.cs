namespace core.config.pet_advance
{
	public class ITaskItem
	{
		public IAdvances Advances { get; set; }

		public IBattle Battle { get; set; }

		public string Desc { get; set; }

		public IExchange Exchange { get; set; }

		public int AllProgress { get; set; }

		public int BattleBoss { get; set; }

		public int ID { get; set; }

		public int OutItemKey { get; set; }

		public int PerCostCoinA { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Advances = new IAdvances();
				Advances.Parse(bytes, ref byteIndex);
			}
			AllProgress = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Battle = new IBattle();
				Battle.Parse(bytes, ref byteIndex);
			}
			BattleBoss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Exchange = new IExchange();
				Exchange.Parse(bytes, ref byteIndex);
			}
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			OutItemKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PerCostCoinA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
