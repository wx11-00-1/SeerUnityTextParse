namespace core.config
{
	public class INewMonsterLevelTempInfo : IConfigItem
	{
		public string hide { get; set; }

		public string image { get; set; }

		public string isnew { get; set; }

		public string param { get; set; }

		public string quality { get; set; }

		public string recommendTime { get; set; }

		public string statlog { get; set; }

		public string upgradeHide { get; set; }

		public string upgradeNew { get; set; }

		public int[] isrecommend { get; set; }

		public int[] menutype { get; set; }

		public int[] petTag { get; set; }

		public int[] upgrade { get; set; }

		public int collective { get; set; }

		public int difficult { get; set; }

		public int fightType { get; set; }

		public int id { get; set; }

		public int moduleid { get; set; }

		public int monsterid { get; set; }

		public int newSort { get; set; }

		public int sort { get; set; }

		public int upgradeSort { get; set; }

		public int upgradeSource { get; set; }

		public int weekly { get; set; }

		public int weeklyAdd { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			collective = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			difficult = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			fightType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hide = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			isnew = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				isrecommend = new int[num];
				for (int i = 0; i < num; i++)
				{
					isrecommend[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				menutype = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					menutype[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			moduleid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			newSort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				petTag = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					petTag[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			quality = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			recommendTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			statlog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				upgrade = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					upgrade[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			upgradeHide = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			upgradeNew = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			upgradeSort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			upgradeSource = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weekly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weeklyAdd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
