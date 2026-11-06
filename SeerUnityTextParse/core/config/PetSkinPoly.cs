namespace core.config
{
	public class PetSkinPoly : XlsConfigBase<PetSkinPoly, IPetSkinPolyInfo>
	{
		public override string fileName
		{
			get
			{
				return "pet_skin_poly";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPetSkinPolyInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPetSkinPolyInfo();
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
