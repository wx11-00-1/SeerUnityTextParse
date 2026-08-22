namespace core.config
{
	public class BraveTowerReverseDefenseStrengthen : XlsConfigBase<BraveTowerReverseDefenseStrengthen, IBraveTowerReverseDefenseStrengthenInfo>
	{
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_strengthen";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBraveTowerReverseDefenseStrengthenInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBraveTowerReverseDefenseStrengthenInfo();
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
