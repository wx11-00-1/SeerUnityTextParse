namespace core.config
{
	public class ChessGameEquip : XlsConfigBase<ChessGameEquip, IChessGameEquipInfo>
	{
		public override string fileName
		{
			get
			{
				return "chessGame_equip";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IChessGameEquipInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IChessGameEquipInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
