namespace core.config.move_stones
{
	public class IMoveStoneItem
	{
		public IMoveEffectItem[] MoveEffect { get; set; }

		public string Name { get; set; }

		public int Accuracy { get; set; }

		public int ID { get; set; }

		public int MaxPP { get; set; }

		public int Power { get; set; }

		public int Type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Accuracy = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MaxPP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				MoveEffect = new IMoveEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					MoveEffect[i] = new IMoveEffectItem();
					MoveEffect[i].Parse(bytes, ref byteIndex);
				}
			}
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Power = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
