using System;

namespace core.config.petbook
{
	public class IHotPet
	{
		public IPetDataItem[] PetData { get; set; }

		public ITypeItem[] type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int byteIndex2 = byteIndex;
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				if (byteIndex2 + 4 > bytes.Length)
				{
					return;
				}
				int num = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num > 0)
				{
					PetData = new IPetDataItem[num];
					for (int i = 0; i < num; i++)
					{
						PetData[i] = new IPetDataItem();
						PetData[i].Parse(bytes, ref byteIndex2);
					}
				}
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				if (byteIndex2 + 4 > bytes.Length)
				{
					return;
				}
				int num2 = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num2 > 0)
				{
					type = new ITypeItem[num2];
					for (int j = 0; j < num2; j++)
					{
						type[j] = new ITypeItem();
						type[j].Parse(bytes, ref byteIndex2);
					}
				}
			}
			byteIndex = byteIndex2;
		}
	}
}
