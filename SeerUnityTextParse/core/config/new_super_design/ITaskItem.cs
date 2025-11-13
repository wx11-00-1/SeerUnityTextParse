using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F8E RID: 8078
	public class ITaskItem
	{
		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x0600F26A RID: 62058 RVA: 0x003F7425 File Offset: 0x003F5625
		// (set) Token: 0x0600F26B RID: 62059 RVA: 0x003F742D File Offset: 0x003F562D
		public string Desc { get; set; }

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x0600F26C RID: 62060 RVA: 0x003F7436 File Offset: 0x003F5636
		// (set) Token: 0x0600F26D RID: 62061 RVA: 0x003F743E File Offset: 0x003F563E
		public int BattleBoss { get; set; }

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x0600F26E RID: 62062 RVA: 0x003F7447 File Offset: 0x003F5647
		// (set) Token: 0x0600F26F RID: 62063 RVA: 0x003F744F File Offset: 0x003F564F
		public int Battlelevel { get; set; }

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x0600F270 RID: 62064 RVA: 0x003F7458 File Offset: 0x003F5658
		// (set) Token: 0x0600F271 RID: 62065 RVA: 0x003F7460 File Offset: 0x003F5660
		public int BattleType { get; set; }

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x0600F272 RID: 62066 RVA: 0x003F7469 File Offset: 0x003F5669
		// (set) Token: 0x0600F273 RID: 62067 RVA: 0x003F7471 File Offset: 0x003F5671
		public int ID { get; set; }

		// Token: 0x0600F274 RID: 62068 RVA: 0x003F747C File Offset: 0x003F567C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BattleBoss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.BattleType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Battlelevel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
