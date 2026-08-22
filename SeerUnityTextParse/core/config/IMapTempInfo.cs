namespace core.config
{
	public class IMapTempInfo : IConfigItem
	{
		public string DeviceID { get; set; }

		public string Ename { get; set; }

		public string name { get; set; }

		public string notes { get; set; }

		public string sound { get; set; }

		public int[] NPCID { get; set; }

		public int[] NPCXYZ { get; set; }

		public int[] PlayerXYZ { get; set; }

		public int[] WildBossID { get; set; }

		public int[] WildBossPoint { get; set; }

		public int[] WildBossWeight { get; set; }

		public int enterMap { get; set; }

		public int GroupID { get; set; }

		public int id { get; set; }

		public int MapRatio { get; set; }

		public int pic { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			DeviceID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Ename = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			GroupID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MapRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				NPCID = new int[num];
				for (int i = 0; i < num; i++)
				{
					NPCID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				NPCXYZ = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					NPCXYZ[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				PlayerXYZ = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					PlayerXYZ[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				WildBossID = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					WildBossID[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				WildBossPoint = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					WildBossPoint[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				WildBossWeight = new int[num6];
				for (int n = 0; n < num6; n++)
				{
					WildBossWeight[n] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			enterMap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			notes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sound = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
