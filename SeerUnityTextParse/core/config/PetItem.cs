namespace core.config
{
	public class PetItem : XlsConfigBase<PetItem, IPetItemInfo>
	{
		public override string fileName
		{
			get
			{
				return "pet_item";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPetItemInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPetItemInfo();
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
