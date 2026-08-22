namespace core.config.free_monster_list
{
	public class IMonsterItem
	{
		public int isNew { get; set; }

		public int petId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			isNew = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
