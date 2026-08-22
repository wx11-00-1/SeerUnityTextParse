namespace core.config.monstersOptimize
{
	public class monstersOptimizeMonsterDef
	{
		public int ID;

		public string DefName;

		public int Type;

		public int HP;

		public int Atk;

		public int Def;

		public int SpAtk;

		public int SpDef;

		public int Spd;

		public int EvolvesTo;

		public int EvolvingLv;

		public int FreeForbidden;

		public int Gender;

		public int PetClass;

		public int CharacterAttrParam;

		public int EvolvFlag;

		public int isRidePet;

		public int Vip;

		public int isFlyPet;

		public int Combo;

		public int Transform;

		public int RealId;

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SpAtk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SpDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Spd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			EvolvesTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			EvolvingLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			FreeForbidden = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Gender = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PetClass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			CharacterAttrParam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			EvolvFlag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isRidePet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isFlyPet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Combo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Transform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RealId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
