namespace core.config
{
	public class AutocardbattlepassTask : XlsConfigBase<AutocardbattlepassTask, IAutocardbattlepassTaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardbattlepass_task";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardbattlepassTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardbattlepassTaskInfo();
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
