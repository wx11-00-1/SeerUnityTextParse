using System;

namespace core.config.sp_hide_moves
{
	// Token: 0x02001F1B RID: 7963
	public class ISpMovesItem : IConfigItem
	{
		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x0600EE88 RID: 61064 RVA: 0x003F2874 File Offset: 0x003F0A74
		// (set) Token: 0x0600EE89 RID: 61065 RVA: 0x003F287C File Offset: 0x003F0A7C
		public string itemname { get; set; }

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x0600EE8A RID: 61066 RVA: 0x003F2885 File Offset: 0x003F0A85
		// (set) Token: 0x0600EE8B RID: 61067 RVA: 0x003F288D File Offset: 0x003F0A8D
		public string movesname { get; set; }

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x0600EE8C RID: 61068 RVA: 0x003F2896 File Offset: 0x003F0A96
		// (set) Token: 0x0600EE8D RID: 61069 RVA: 0x003F289E File Offset: 0x003F0A9E
		public int id { get; set; }

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x0600EE8E RID: 61070 RVA: 0x003F28A7 File Offset: 0x003F0AA7
		// (set) Token: 0x0600EE8F RID: 61071 RVA: 0x003F28AF File Offset: 0x003F0AAF
		public int item { get; set; }

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x0600EE90 RID: 61072 RVA: 0x003F28B8 File Offset: 0x003F0AB8
		// (set) Token: 0x0600EE91 RID: 61073 RVA: 0x003F28C0 File Offset: 0x003F0AC0
		public int itemnumber { get; set; }

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x0600EE92 RID: 61074 RVA: 0x003F28C9 File Offset: 0x003F0AC9
		// (set) Token: 0x0600EE93 RID: 61075 RVA: 0x003F28D1 File Offset: 0x003F0AD1
		public int monster { get; set; }

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x0600EE94 RID: 61076 RVA: 0x003F28DA File Offset: 0x003F0ADA
		// (set) Token: 0x0600EE95 RID: 61077 RVA: 0x003F28E2 File Offset: 0x003F0AE2
		public int moves { get; set; }

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x0600EE96 RID: 61078 RVA: 0x003F28EB File Offset: 0x003F0AEB
		// (set) Token: 0x0600EE97 RID: 61079 RVA: 0x003F28F3 File Offset: 0x003F0AF3
		public int movetype { get; set; }

		// Token: 0x0600EE98 RID: 61080 RVA: 0x003F28FC File Offset: 0x003F0AFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.itemnumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moves = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.movesname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.movetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
