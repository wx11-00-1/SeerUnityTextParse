namespace core.config
{
	public class BattlepassTask : XlsConfigBase<BattlepassTask, IBattlepassTaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "battlepass_task";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBattlepassTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBattlepassTaskInfo();
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
