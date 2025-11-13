using System;

namespace core.config
{
	// Token: 0x02001D72 RID: 7538
	public class ILatestActivityInfo : IConfigItem
	{
		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x0600DCD6 RID: 56534 RVA: 0x003D4D24 File Offset: 0x003D2F24
		// (set) Token: 0x0600DCD7 RID: 56535 RVA: 0x003D4D2C File Offset: 0x003D2F2C
		public string[] @goto { get; set; }

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x0600DCD8 RID: 56536 RVA: 0x003D4D35 File Offset: 0x003D2F35
		// (set) Token: 0x0600DCD9 RID: 56537 RVA: 0x003D4D3D File Offset: 0x003D2F3D
		public string showEnd { get; set; }

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x0600DCDA RID: 56538 RVA: 0x003D4D46 File Offset: 0x003D2F46
		// (set) Token: 0x0600DCDB RID: 56539 RVA: 0x003D4D4E File Offset: 0x003D2F4E
		public string showStart { get; set; }

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x0600DCDC RID: 56540 RVA: 0x003D4D57 File Offset: 0x003D2F57
		// (set) Token: 0x0600DCDD RID: 56541 RVA: 0x003D4D5F File Offset: 0x003D2F5F
		public int id { get; set; }

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x0600DCDE RID: 56542 RVA: 0x003D4D68 File Offset: 0x003D2F68
		// (set) Token: 0x0600DCDF RID: 56543 RVA: 0x003D4D70 File Offset: 0x003D2F70
		public int page { get; set; }

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x0600DCE0 RID: 56544 RVA: 0x003D4D79 File Offset: 0x003D2F79
		// (set) Token: 0x0600DCE1 RID: 56545 RVA: 0x003D4D81 File Offset: 0x003D2F81
		public int pic { get; set; }

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x0600DCE2 RID: 56546 RVA: 0x003D4D8A File Offset: 0x003D2F8A
		// (set) Token: 0x0600DCE3 RID: 56547 RVA: 0x003D4D92 File Offset: 0x003D2F92
		public int tag { get; set; }

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x0600DCE4 RID: 56548 RVA: 0x003D4D9B File Offset: 0x003D2F9B
		// (set) Token: 0x0600DCE5 RID: 56549 RVA: 0x003D4DA3 File Offset: 0x003D2FA3
		public int type { get; set; }

		// Token: 0x0600DCE6 RID: 56550 RVA: 0x003D4DAC File Offset: 0x003D2FAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.@goto = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.@goto[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.page = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showStart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
