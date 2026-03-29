using System;

namespace core.config
{
	// Token: 0x02002249 RID: 8777
	public class IFightLabBossConfigInfo : IConfigItem
	{
		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060108C2 RID: 67778 RVA: 0x0048B604 File Offset: 0x00489804
		// (set) Token: 0x060108C3 RID: 67779 RVA: 0x0048B60C File Offset: 0x0048980C
		public string monsterData { get; set; }

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x060108C4 RID: 67780 RVA: 0x0048B615 File Offset: 0x00489815
		// (set) Token: 0x060108C5 RID: 67781 RVA: 0x0048B61D File Offset: 0x0048981D
		public string monsterIntro { get; set; }

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x060108C6 RID: 67782 RVA: 0x0048B626 File Offset: 0x00489826
		// (set) Token: 0x060108C7 RID: 67783 RVA: 0x0048B62E File Offset: 0x0048982E
		public string monsterMove { get; set; }

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x060108C8 RID: 67784 RVA: 0x0048B637 File Offset: 0x00489837
		// (set) Token: 0x060108C9 RID: 67785 RVA: 0x0048B63F File Offset: 0x0048983F
		public string monsterNewse { get; set; }

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x060108CA RID: 67786 RVA: 0x0048B648 File Offset: 0x00489848
		// (set) Token: 0x060108CB RID: 67787 RVA: 0x0048B650 File Offset: 0x00489850
		public int id { get; set; }

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x060108CC RID: 67788 RVA: 0x0048B659 File Offset: 0x00489859
		// (set) Token: 0x060108CD RID: 67789 RVA: 0x0048B661 File Offset: 0x00489861
		public int index { get; set; }

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x060108CE RID: 67790 RVA: 0x0048B66A File Offset: 0x0048986A
		// (set) Token: 0x060108CF RID: 67791 RVA: 0x0048B672 File Offset: 0x00489872
		public int monsterId { get; set; }

		// Token: 0x060108D0 RID: 67792 RVA: 0x0048B67C File Offset: 0x0048987C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.index = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterData = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterMove = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.monsterNewse = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
