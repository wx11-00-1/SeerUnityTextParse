using System;

namespace core.config.monstersOptimize
{
	// Token: 0x02001ECC RID: 7884
	public class monstersOptimizeMonsterDef
	{
		// Token: 0x0600EBDB RID: 60379 RVA: 0x003EF2F0 File Offset: 0x003ED4F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SpAtk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SpDef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Spd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.EvolvesTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.EvolvingLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.FreeForbidden = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Gender = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetClass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.CharacterAttrParam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.EvolvFlag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isRidePet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isFlyPet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Combo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Transform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RealId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF09 RID: 61193
		public int ID;

		// Token: 0x0400EF0A RID: 61194
		public string DefName;

		// Token: 0x0400EF0B RID: 61195
		public int Type;

		// Token: 0x0400EF0C RID: 61196
		public int HP;

		// Token: 0x0400EF0D RID: 61197
		public int Atk;

		// Token: 0x0400EF0E RID: 61198
		public int Def;

		// Token: 0x0400EF0F RID: 61199
		public int SpAtk;

		// Token: 0x0400EF10 RID: 61200
		public int SpDef;

		// Token: 0x0400EF11 RID: 61201
		public int Spd;

		// Token: 0x0400EF12 RID: 61202
		public int EvolvesTo;

		// Token: 0x0400EF13 RID: 61203
		public int EvolvingLv;

		// Token: 0x0400EF14 RID: 61204
		public int FreeForbidden;

		// Token: 0x0400EF15 RID: 61205
		public int Gender;

		// Token: 0x0400EF16 RID: 61206
		public int PetClass;

		// Token: 0x0400EF17 RID: 61207
		public int CharacterAttrParam;

		// Token: 0x0400EF18 RID: 61208
		public int EvolvFlag;

		// Token: 0x0400EF19 RID: 61209
		public int isRidePet;

		// Token: 0x0400EF1A RID: 61210
		public int Vip;

		// Token: 0x0400EF1B RID: 61211
		public int isFlyPet;

		// Token: 0x0400EF1C RID: 61212
		public int Combo;

		// Token: 0x0400EF1D RID: 61213
		public int Transform;

		// Token: 0x0400EF1E RID: 61214
		public int RealId;
	}
}
