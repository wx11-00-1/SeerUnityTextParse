using System;

namespace core.config.monstersOptimize
{
	// Token: 0x02001ECD RID: 7885
	public class monstersOptimizeMonsterMovesDef
	{
		// Token: 0x0600EBDD RID: 60381 RVA: 0x003EF42C File Offset: 0x003ED62C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LearningLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MoveType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF1F RID: 61215
		public int MonsterID;

		// Token: 0x0400EF20 RID: 61216
		public int ID;

		// Token: 0x0400EF21 RID: 61217
		public int LearningLv;

		// Token: 0x0400EF22 RID: 61218
		public int Rec;

		// Token: 0x0400EF23 RID: 61219
		public int Tag;

		// Token: 0x0400EF24 RID: 61220
		public int MoveType;
	}
}
