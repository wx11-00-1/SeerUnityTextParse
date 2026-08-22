namespace core.config.effectIcon
{
	public class IEffectItem
	{
		public string analyze { get; set; }

		public string args { get; set; }

		public string come { get; set; }

		public string[] des { get; set; }

		public string[] tag { get; set; }

		public string tips { get; set; }

		public int[] kind { get; set; }

		public int[] petId { get; set; }

		public int[] specificId { get; set; }

		public int effectId { get; set; }

		public int iconId { get; set; }

		public int Id { get; set; }

		public int intensify { get; set; }

		public int isAdv { get; set; }

		public int label { get; set; }

		public int limitedType { get; set; }

		public int target { get; set; }

		public int to { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			analyze = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			come = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				des = new string[num];
				for (int i = 0; i < num; i++)
				{
					des[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			effectId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			iconId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			intensify = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isAdv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				kind = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					kind[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitedType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				petId = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					petId[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				specificId = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					specificId[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				tag = new string[num5];
				for (int m = 0; m < num5; m++)
				{
					tag[m] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			to = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
