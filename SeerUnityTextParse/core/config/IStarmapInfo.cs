using System;

namespace core.config
{
	// Token: 0x02001E38 RID: 7736
	public class IStarmapInfo : IConfigItem
	{
		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600E538 RID: 58680 RVA: 0x003DF5B8 File Offset: 0x003DD7B8
		// (set) Token: 0x0600E539 RID: 58681 RVA: 0x003DF5C0 File Offset: 0x003DD7C0
		public string[] fun { get; set; }

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x0600E53A RID: 58682 RVA: 0x003DF5C9 File Offset: 0x003DD7C9
		// (set) Token: 0x0600E53B RID: 58683 RVA: 0x003DF5D1 File Offset: 0x003DD7D1
		public string intro { get; set; }

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x0600E53C RID: 58684 RVA: 0x003DF5DA File Offset: 0x003DD7DA
		// (set) Token: 0x0600E53D RID: 58685 RVA: 0x003DF5E2 File Offset: 0x003DD7E2
		public string name { get; set; }

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x0600E53E RID: 58686 RVA: 0x003DF5EB File Offset: 0x003DD7EB
		// (set) Token: 0x0600E53F RID: 58687 RVA: 0x003DF5F3 File Offset: 0x003DD7F3
		public int[] submap { get; set; }

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x0600E540 RID: 58688 RVA: 0x003DF5FC File Offset: 0x003DD7FC
		// (set) Token: 0x0600E541 RID: 58689 RVA: 0x003DF604 File Offset: 0x003DD804
		public int Gotomap { get; set; }

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x0600E542 RID: 58690 RVA: 0x003DF60D File Offset: 0x003DD80D
		// (set) Token: 0x0600E543 RID: 58691 RVA: 0x003DF615 File Offset: 0x003DD815
		public int id { get; set; }

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600E544 RID: 58692 RVA: 0x003DF61E File Offset: 0x003DD81E
		// (set) Token: 0x0600E545 RID: 58693 RVA: 0x003DF626 File Offset: 0x003DD826
		public int isopen { get; set; }

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600E546 RID: 58694 RVA: 0x003DF62F File Offset: 0x003DD82F
		// (set) Token: 0x0600E547 RID: 58695 RVA: 0x003DF637 File Offset: 0x003DD837
		public int shipArea { get; set; }

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x0600E548 RID: 58696 RVA: 0x003DF640 File Offset: 0x003DD840
		// (set) Token: 0x0600E549 RID: 58697 RVA: 0x003DF648 File Offset: 0x003DD848
		public int showOut { get; set; }

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x0600E54A RID: 58698 RVA: 0x003DF651 File Offset: 0x003DD851
		// (set) Token: 0x0600E54B RID: 58699 RVA: 0x003DF659 File Offset: 0x003DD859
		public int type { get; set; }

		// Token: 0x0600E54C RID: 58700 RVA: 0x003DF664 File Offset: 0x003DD864
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Gotomap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.fun = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.fun[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.shipArea = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showOut = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.submap = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.submap[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
