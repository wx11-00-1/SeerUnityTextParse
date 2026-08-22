namespace core.config.PetFightSkinSkillReplace
{
	public class ISkill : IConfigItem
	{
		public string action { get; set; }

		public int id { get; set; }

		public int replaceId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			action = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			replaceId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
