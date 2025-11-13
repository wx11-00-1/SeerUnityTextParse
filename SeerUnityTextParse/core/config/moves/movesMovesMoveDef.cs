using System;

namespace core.config.moves
{
	// Token: 0x02001FA9 RID: 8105
	public class movesMovesMoveDef
	{
		// Token: 0x0600F3AE RID: 62382 RVA: 0x003F8C08 File Offset: 0x003F6E08
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Category = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Power = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MaxPP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SideEffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SideEffectArg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MustHit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.info = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.AtkNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.FriendSideEffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.FriendSideEffectArg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.AtkType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.animation = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ordinary = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400F2A6 RID: 62118
		public int ID;

		// Token: 0x0400F2A7 RID: 62119
		public string Name;

		// Token: 0x0400F2A8 RID: 62120
		public int Category;

		// Token: 0x0400F2A9 RID: 62121
		public int Type;

		// Token: 0x0400F2AA RID: 62122
		public int Power;

		// Token: 0x0400F2AB RID: 62123
		public int MaxPP;

		// Token: 0x0400F2AC RID: 62124
		public string SideEffect;

		// Token: 0x0400F2AD RID: 62125
		public string SideEffectArg;

		// Token: 0x0400F2AE RID: 62126
		public int Priority;

		// Token: 0x0400F2AF RID: 62127
		public int MustHit;

		// Token: 0x0400F2B0 RID: 62128
		public string info;

		// Token: 0x0400F2B1 RID: 62129
		public int AtkNum;

		// Token: 0x0400F2B2 RID: 62130
		public string FriendSideEffect;

		// Token: 0x0400F2B3 RID: 62131
		public string FriendSideEffectArg;

		// Token: 0x0400F2B4 RID: 62132
		public int AtkType;

		// Token: 0x0400F2B5 RID: 62133
		public int MonID;

		// Token: 0x0400F2B6 RID: 62134
		public int animation;

		// Token: 0x0400F2B7 RID: 62135
		public int ordinary;
	}
}
