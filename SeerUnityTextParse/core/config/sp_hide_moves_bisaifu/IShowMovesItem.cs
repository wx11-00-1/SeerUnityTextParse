using System;

namespace core.config.sp_hide_moves_bisaifu
{
	// Token: 0x02001F17 RID: 7959
	public class IShowMovesItem : IConfigItem
	{
		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x0600EE52 RID: 61010 RVA: 0x003F24B8 File Offset: 0x003F06B8
		// (set) Token: 0x0600EE53 RID: 61011 RVA: 0x003F24C0 File Offset: 0x003F06C0
		public string itemname { get; set; }

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x0600EE54 RID: 61012 RVA: 0x003F24C9 File Offset: 0x003F06C9
		// (set) Token: 0x0600EE55 RID: 61013 RVA: 0x003F24D1 File Offset: 0x003F06D1
		public string monstername { get; set; }

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x0600EE56 RID: 61014 RVA: 0x003F24DA File Offset: 0x003F06DA
		// (set) Token: 0x0600EE57 RID: 61015 RVA: 0x003F24E2 File Offset: 0x003F06E2
		public string movesname { get; set; }

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x0600EE58 RID: 61016 RVA: 0x003F24EB File Offset: 0x003F06EB
		// (set) Token: 0x0600EE59 RID: 61017 RVA: 0x003F24F3 File Offset: 0x003F06F3
		public int id { get; set; }

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x0600EE5A RID: 61018 RVA: 0x003F24FC File Offset: 0x003F06FC
		// (set) Token: 0x0600EE5B RID: 61019 RVA: 0x003F2504 File Offset: 0x003F0704
		public int item { get; set; }

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x0600EE5C RID: 61020 RVA: 0x003F250D File Offset: 0x003F070D
		// (set) Token: 0x0600EE5D RID: 61021 RVA: 0x003F2515 File Offset: 0x003F0715
		public int itemnumber { get; set; }

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x0600EE5E RID: 61022 RVA: 0x003F251E File Offset: 0x003F071E
		// (set) Token: 0x0600EE5F RID: 61023 RVA: 0x003F2526 File Offset: 0x003F0726
		public int monster { get; set; }

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x0600EE60 RID: 61024 RVA: 0x003F252F File Offset: 0x003F072F
		// (set) Token: 0x0600EE61 RID: 61025 RVA: 0x003F2537 File Offset: 0x003F0737
		public int moves { get; set; }

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x0600EE62 RID: 61026 RVA: 0x003F2540 File Offset: 0x003F0740
		// (set) Token: 0x0600EE63 RID: 61027 RVA: 0x003F2548 File Offset: 0x003F0748
		public int movetype { get; set; }

		// Token: 0x0600EE64 RID: 61028 RVA: 0x003F2554 File Offset: 0x003F0754
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.itemnumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monstername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.moves = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.movesname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.movetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
