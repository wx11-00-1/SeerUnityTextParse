namespace core.config.petbook_temp
{
	public class IHotPet
	{
		public IPetDataItem[] PetData { get; set; }

		public ITypeItem[] type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				PetData = new IPetDataItem[num];
				for (int i = 0; i < num; i++)
				{
					PetData[i] = new IPetDataItem();
					PetData[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				type = new ITypeItem[num2];
				for (int j = 0; j < num2; j++)
				{
					type[j] = new ITypeItem();
					type[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
