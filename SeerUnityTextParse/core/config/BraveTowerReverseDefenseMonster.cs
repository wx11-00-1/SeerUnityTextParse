namespace core.config
{
	public class BraveTowerReverseDefenseMonster : XlsConfigBase<BraveTowerReverseDefenseMonster, IBraveTowerReverseDefenseMonsterInfo>
	{
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_monster";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBraveTowerReverseDefenseMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBraveTowerReverseDefenseMonsterInfo();
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
