namespace core.config.Fragment
{
	public class IFragmentItem
	{
		public int effectId { get; set; }

		public int ID { get; set; }

		public int MonsterID { get; set; }

		public int MoveID { get; set; }

		public int MovesConsume { get; set; }

		public int NeedmonID { get; set; }

		public int NewseConsume { get; set; }

		public int NewSeIdx { get; set; }

		public int PetConsume { get; set; }

		public int PetLimit { get; set; }

		public int Rarity { get; set; }

		public int show { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MoveID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MovesConsume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NeedmonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewSeIdx = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewseConsume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PetConsume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PetLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			effectId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
