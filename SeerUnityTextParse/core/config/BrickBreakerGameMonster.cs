namespace core.config
{
	public class BrickBreakerGameMonster : XlsConfigBase<BrickBreakerGameMonster, IBrickBreakerGameMonsterInfo>
	{
		public override string fileName
		{
			get
			{
				return "brickBreakerGameMonster";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBrickBreakerGameMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBrickBreakerGameMonsterInfo();
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
