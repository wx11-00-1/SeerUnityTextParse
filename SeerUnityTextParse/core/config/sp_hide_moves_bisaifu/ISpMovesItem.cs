using System;

namespace core.config.sp_hide_moves_bisaifu
{
	// Token: 0x02001F18 RID: 7960
	public class ISpMovesItem : IConfigItem
	{
		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x0600EE66 RID: 61030 RVA: 0x003F25F3 File Offset: 0x003F07F3
		// (set) Token: 0x0600EE67 RID: 61031 RVA: 0x003F25FB File Offset: 0x003F07FB
		public string itemname { get; set; }

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x0600EE68 RID: 61032 RVA: 0x003F2604 File Offset: 0x003F0804
		// (set) Token: 0x0600EE69 RID: 61033 RVA: 0x003F260C File Offset: 0x003F080C
		public string itemtips { get; set; }

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x0600EE6A RID: 61034 RVA: 0x003F2615 File Offset: 0x003F0815
		// (set) Token: 0x0600EE6B RID: 61035 RVA: 0x003F261D File Offset: 0x003F081D
		public string monstername { get; set; }

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x0600EE6C RID: 61036 RVA: 0x003F2626 File Offset: 0x003F0826
		// (set) Token: 0x0600EE6D RID: 61037 RVA: 0x003F262E File Offset: 0x003F082E
		public string movesname { get; set; }

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x0600EE6E RID: 61038 RVA: 0x003F2637 File Offset: 0x003F0837
		// (set) Token: 0x0600EE6F RID: 61039 RVA: 0x003F263F File Offset: 0x003F083F
		public int id { get; set; }

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x0600EE70 RID: 61040 RVA: 0x003F2648 File Offset: 0x003F0848
		// (set) Token: 0x0600EE71 RID: 61041 RVA: 0x003F2650 File Offset: 0x003F0850
		public int item { get; set; }

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x0600EE72 RID: 61042 RVA: 0x003F2659 File Offset: 0x003F0859
		// (set) Token: 0x0600EE73 RID: 61043 RVA: 0x003F2661 File Offset: 0x003F0861
		public int itemnumber { get; set; }

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x0600EE74 RID: 61044 RVA: 0x003F266A File Offset: 0x003F086A
		// (set) Token: 0x0600EE75 RID: 61045 RVA: 0x003F2672 File Offset: 0x003F0872
		public int monster { get; set; }

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x0600EE76 RID: 61046 RVA: 0x003F267B File Offset: 0x003F087B
		// (set) Token: 0x0600EE77 RID: 61047 RVA: 0x003F2683 File Offset: 0x003F0883
		public int moves { get; set; }

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x0600EE78 RID: 61048 RVA: 0x003F268C File Offset: 0x003F088C
		// (set) Token: 0x0600EE79 RID: 61049 RVA: 0x003F2694 File Offset: 0x003F0894
		public int movetype { get; set; }

		// Token: 0x0600EE7A RID: 61050 RVA: 0x003F26A0 File Offset: 0x003F08A0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.itemnumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemtips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monstername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.moves = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.movesname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.movetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
