namespace core.config
{
	public class IRoleInformationInfo : IConfigItem
	{
		public string activeSkills { get; set; }

		public string name { get; set; }

		public string passiveSkills { get; set; }

		public string resources { get; set; }

		public int attack { get; set; }

		public int combatEffectiveness { get; set; }

		public int defense { get; set; }

		public int healthPoints { get; set; }

		public int id { get; set; }

		public int petid { get; set; }

		public int speed { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			activeSkills = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			attack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			combatEffectiveness = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			defense = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			healthPoints = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			passiveSkills = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			resources = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
