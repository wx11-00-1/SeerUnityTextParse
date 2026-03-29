using System;

namespace core.config
{
	// Token: 0x020023EF RID: 9199
	public class ITutorialRecruitlevelInfo : IConfigItem
	{
		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06011B3A RID: 72506 RVA: 0x004A2510 File Offset: 0x004A0710
		// (set) Token: 0x06011B3B RID: 72507 RVA: 0x004A2518 File Offset: 0x004A0718
		public string des { get; set; }

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06011B3C RID: 72508 RVA: 0x004A2521 File Offset: 0x004A0721
		// (set) Token: 0x06011B3D RID: 72509 RVA: 0x004A2529 File Offset: 0x004A0729
		public string icon { get; set; }

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06011B3E RID: 72510 RVA: 0x004A2532 File Offset: 0x004A0732
		// (set) Token: 0x06011B3F RID: 72511 RVA: 0x004A253A File Offset: 0x004A073A
		public string rewardcnt { get; set; }

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06011B40 RID: 72512 RVA: 0x004A2543 File Offset: 0x004A0743
		// (set) Token: 0x06011B41 RID: 72513 RVA: 0x004A254B File Offset: 0x004A074B
		public string rewardid { get; set; }

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06011B42 RID: 72514 RVA: 0x004A2554 File Offset: 0x004A0754
		// (set) Token: 0x06011B43 RID: 72515 RVA: 0x004A255C File Offset: 0x004A075C
		public string rewardtype { get; set; }

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06011B44 RID: 72516 RVA: 0x004A2565 File Offset: 0x004A0765
		// (set) Token: 0x06011B45 RID: 72517 RVA: 0x004A256D File Offset: 0x004A076D
		public string tipsdes { get; set; }

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06011B46 RID: 72518 RVA: 0x004A2576 File Offset: 0x004A0776
		// (set) Token: 0x06011B47 RID: 72519 RVA: 0x004A257E File Offset: 0x004A077E
		public string tipspet { get; set; }

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06011B48 RID: 72520 RVA: 0x004A2587 File Offset: 0x004A0787
		// (set) Token: 0x06011B49 RID: 72521 RVA: 0x004A258F File Offset: 0x004A078F
		public int degree { get; set; }

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06011B4A RID: 72522 RVA: 0x004A2598 File Offset: 0x004A0798
		// (set) Token: 0x06011B4B RID: 72523 RVA: 0x004A25A0 File Offset: 0x004A07A0
		public int id { get; set; }

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06011B4C RID: 72524 RVA: 0x004A25A9 File Offset: 0x004A07A9
		// (set) Token: 0x06011B4D RID: 72525 RVA: 0x004A25B1 File Offset: 0x004A07B1
		public int InTutorial { get; set; }

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06011B4E RID: 72526 RVA: 0x004A25BA File Offset: 0x004A07BA
		// (set) Token: 0x06011B4F RID: 72527 RVA: 0x004A25C2 File Offset: 0x004A07C2
		public int level { get; set; }

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06011B50 RID: 72528 RVA: 0x004A25CB File Offset: 0x004A07CB
		// (set) Token: 0x06011B51 RID: 72529 RVA: 0x004A25D3 File Offset: 0x004A07D3
		public int monsterid { get; set; }

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06011B52 RID: 72530 RVA: 0x004A25DC File Offset: 0x004A07DC
		// (set) Token: 0x06011B53 RID: 72531 RVA: 0x004A25E4 File Offset: 0x004A07E4
		public int star { get; set; }

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06011B54 RID: 72532 RVA: 0x004A25ED File Offset: 0x004A07ED
		// (set) Token: 0x06011B55 RID: 72533 RVA: 0x004A25F5 File Offset: 0x004A07F5
		public int type { get; set; }

		// Token: 0x06011B56 RID: 72534 RVA: 0x004A2600 File Offset: 0x004A0800
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.InTutorial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.degree = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tipsdes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tipspet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
