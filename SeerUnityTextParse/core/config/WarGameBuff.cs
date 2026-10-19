namespace core.config
{
	public class WarGameBuff : XlsConfigBase<WarGameBuff, IWarGameBuffInfo>
	{
		public override string fileName
		{
			get
			{
				return "warGame_Buff";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IWarGameBuffInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IWarGameBuffInfo();
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
