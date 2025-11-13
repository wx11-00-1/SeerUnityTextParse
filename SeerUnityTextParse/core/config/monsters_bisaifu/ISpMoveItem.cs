using System;

namespace core.config.monsters_bisaifu
{
	// Token: 0x02001FB2 RID: 8114
	public class ISpMoveItem
	{
		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x0600F44E RID: 62542 RVA: 0x003F9874 File Offset: 0x003F7A74
		// (set) Token: 0x0600F44F RID: 62543 RVA: 0x003F987C File Offset: 0x003F7A7C
		public int ID { get; set; }

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x0600F450 RID: 62544 RVA: 0x003F9885 File Offset: 0x003F7A85
		// (set) Token: 0x0600F451 RID: 62545 RVA: 0x003F988D File Offset: 0x003F7A8D
		public int Rec { get; set; }

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x0600F452 RID: 62546 RVA: 0x003F9896 File Offset: 0x003F7A96
		// (set) Token: 0x0600F453 RID: 62547 RVA: 0x003F989E File Offset: 0x003F7A9E
		public int Tag { get; set; }

		// Token: 0x0600F454 RID: 62548 RVA: 0x003F98A7 File Offset: 0x003F7AA7
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
