namespace core.config.monstersOptimize
{
	public class monstersOptimizeMonsterMovesDef
	{
		public int MonsterID;

		public int ID;

		public int LearningLv;

		public int Rec;

		public int Tag;

		public int MoveType;

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LearningLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MoveType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
