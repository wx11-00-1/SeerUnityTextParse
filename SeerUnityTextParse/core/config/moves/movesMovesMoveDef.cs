namespace core.config.moves
{
	public class movesMovesMoveDef
	{
		public int ID;

		public string Name;

		public int Category;

		public int Type;

		public int Power;

		public int MaxPP;

		public string SideEffect;

		public string SideEffectArg;

		public int Priority;

		public int MustHit;

		public string info;

		public int AtkNum;

		public string FriendSideEffect;

		public string FriendSideEffectArg;

		public int AtkType;

		public int MonID;

		public int animation;

		public int ordinary;

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Category = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Power = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MaxPP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SideEffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			SideEffectArg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MustHit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			info = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			AtkNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			FriendSideEffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			FriendSideEffectArg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			AtkType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			animation = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ordinary = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
