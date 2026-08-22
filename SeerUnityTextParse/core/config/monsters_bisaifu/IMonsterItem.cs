namespace core.config.monsters_bisaifu
{
	public class IMonsterItem
	{
		public string DefName { get; set; }

		public ILearnableMoves ExtraMoves { get; set; }

		public ILearnableMoves LearnableMoves { get; set; }

		public IMoveItem Move { get; set; }

		public ILearnableMoves ShowExtraMoves { get; set; }

		public ILearnableMoves SpExtraMoves { get; set; }

		public int Atk { get; set; }

		public int CharacterAttrParam { get; set; }

		public int Combo { get; set; }

		public int Def { get; set; }

		public int EvolvesTo { get; set; }

		public int EvolvFlag { get; set; }

		public int EvolvingLv { get; set; }

		public int FreeForbidden { get; set; }

		public int Gender { get; set; }

		public int HP { get; set; }

		public int ID { get; set; }

		public int isFlyPet { get; set; }

		public int isRidePet { get; set; }

		public int PetClass { get; set; }

		public int RealId { get; set; }

		public int SpAtk { get; set; }

		public int Spd { get; set; }

		public int SpDef { get; set; }

		public int Support { get; set; }

		public int Transform { get; set; }

		public int Type { get; set; }

		public int Vip { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			CharacterAttrParam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Combo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			EvolvFlag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			EvolvesTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			EvolvingLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				ExtraMoves = new ILearnableMoves();
				ExtraMoves.Parse(bytes, ref byteIndex);
			}
			FreeForbidden = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Gender = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				LearnableMoves = new ILearnableMoves();
				LearnableMoves.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Move = new IMoveItem();
				Move.Parse(bytes, ref byteIndex);
			}
			PetClass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RealId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				ShowExtraMoves = new ILearnableMoves();
				ShowExtraMoves.Parse(bytes, ref byteIndex);
			}
			SpAtk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SpDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				SpExtraMoves = new ILearnableMoves();
				SpExtraMoves.Parse(bytes, ref byteIndex);
			}
			Spd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Support = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Transform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isFlyPet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isRidePet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
