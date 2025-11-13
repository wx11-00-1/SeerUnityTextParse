using System;

namespace core.config
{
	// Token: 0x02001D8E RID: 7566
	public class ILuckyrocketRareInfo : IConfigItem
	{
		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x0600DDF8 RID: 56824 RVA: 0x003D6258 File Offset: 0x003D4458
		// (set) Token: 0x0600DDF9 RID: 56825 RVA: 0x003D6260 File Offset: 0x003D4460
		public string equiprare { get; set; }

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x0600DDFA RID: 56826 RVA: 0x003D6269 File Offset: 0x003D4469
		// (set) Token: 0x0600DDFB RID: 56827 RVA: 0x003D6271 File Offset: 0x003D4471
		public string itemrare { get; set; }

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600DDFC RID: 56828 RVA: 0x003D627A File Offset: 0x003D447A
		// (set) Token: 0x0600DDFD RID: 56829 RVA: 0x003D6282 File Offset: 0x003D4482
		public string requirement { get; set; }

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x0600DDFE RID: 56830 RVA: 0x003D628B File Offset: 0x003D448B
		// (set) Token: 0x0600DDFF RID: 56831 RVA: 0x003D6293 File Offset: 0x003D4493
		public string reward { get; set; }

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x0600DE00 RID: 56832 RVA: 0x003D629C File Offset: 0x003D449C
		// (set) Token: 0x0600DE01 RID: 56833 RVA: 0x003D62A4 File Offset: 0x003D44A4
		public int id { get; set; }

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x0600DE02 RID: 56834 RVA: 0x003D62AD File Offset: 0x003D44AD
		// (set) Token: 0x0600DE03 RID: 56835 RVA: 0x003D62B5 File Offset: 0x003D44B5
		public int isequip { get; set; }

		// Token: 0x0600DE04 RID: 56836 RVA: 0x003D62C0 File Offset: 0x003D44C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.equiprare = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isequip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemrare = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.requirement = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
