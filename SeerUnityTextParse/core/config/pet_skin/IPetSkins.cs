namespace core.config.pet_skin
{
	public class IPetSkins
	{
		public ISkinItem[] Skin { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Skin = new ISkinItem[num];
				for (int i = 0; i < num; i++)
				{
					Skin[i] = new ISkinItem();
					Skin[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
