namespace core.config
{
	public class LuckyrocketIEquip : XlsConfigBase<LuckyrocketIEquip, ILuckyrocketIEquipInfo>
	{
		public override string fileName
		{
			get
			{
				return "luckyrocketIEquip";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILuckyrocketIEquipInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILuckyrocketIEquipInfo();
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
