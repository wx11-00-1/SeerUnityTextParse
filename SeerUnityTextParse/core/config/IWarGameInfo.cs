namespace core.config
{
	public class IWarGameInfo : IConfigItem
	{
		public string Evolution { get; set; }

		public string name { get; set; }

		public int addAOE { get; set; }

		public int addas { get; set; }

		public float addATK { get; set; }

		public int addHP { get; set; }

		public int addMS { get; set; }

		public int AOE { get; set; }

		public int ATK { get; set; }

		public int attackspeed { get; set; }

		public int group { get; set; }

		public int HP { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int Lv { get; set; }

		public int MS { get; set; }

		public int skill { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			AOE = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ATK = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Evolution = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MS = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			addAOE = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			addATK = ByteUtil.ReadFloat(bytes, ref byteIndex);
			addHP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			addMS = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			addas = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			attackspeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
