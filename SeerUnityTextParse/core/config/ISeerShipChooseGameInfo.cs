using System;

namespace core.config
{
	// Token: 0x020027BB RID: 10171
	public class ISeerShipChooseGameInfo : IConfigItem
	{
		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06014303 RID: 82691 RVA: 0x00565424 File Offset: 0x00563624
		// (set) Token: 0x06014304 RID: 82692 RVA: 0x0056542C File Offset: 0x0056362C
		public string @event { get; set; }

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06014305 RID: 82693 RVA: 0x00565435 File Offset: 0x00563635
		// (set) Token: 0x06014306 RID: 82694 RVA: 0x0056543D File Offset: 0x0056363D
		public string eventA { get; set; }

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06014307 RID: 82695 RVA: 0x00565446 File Offset: 0x00563646
		// (set) Token: 0x06014308 RID: 82696 RVA: 0x0056544E File Offset: 0x0056364E
		public string eventAAnswer { get; set; }

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06014309 RID: 82697 RVA: 0x00565457 File Offset: 0x00563657
		// (set) Token: 0x0601430A RID: 82698 RVA: 0x0056545F File Offset: 0x0056365F
		public string eventB { get; set; }

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x0601430B RID: 82699 RVA: 0x00565468 File Offset: 0x00563668
		// (set) Token: 0x0601430C RID: 82700 RVA: 0x00565470 File Offset: 0x00563670
		public string eventBAnswer { get; set; }

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x0601430D RID: 82701 RVA: 0x00565479 File Offset: 0x00563679
		// (set) Token: 0x0601430E RID: 82702 RVA: 0x00565481 File Offset: 0x00563681
		public string eventC { get; set; }

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x0601430F RID: 82703 RVA: 0x0056548A File Offset: 0x0056368A
		// (set) Token: 0x06014310 RID: 82704 RVA: 0x00565492 File Offset: 0x00563692
		public string eventCAnswer { get; set; }

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06014311 RID: 82705 RVA: 0x0056549B File Offset: 0x0056369B
		// (set) Token: 0x06014312 RID: 82706 RVA: 0x005654A3 File Offset: 0x005636A3
		public string eventDes { get; set; }

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x06014313 RID: 82707 RVA: 0x005654AC File Offset: 0x005636AC
		// (set) Token: 0x06014314 RID: 82708 RVA: 0x005654B4 File Offset: 0x005636B4
		public string eventHelp { get; set; }

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x06014315 RID: 82709 RVA: 0x005654BD File Offset: 0x005636BD
		// (set) Token: 0x06014316 RID: 82710 RVA: 0x005654C5 File Offset: 0x005636C5
		public string score1 { get; set; }

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06014317 RID: 82711 RVA: 0x005654CE File Offset: 0x005636CE
		// (set) Token: 0x06014318 RID: 82712 RVA: 0x005654D6 File Offset: 0x005636D6
		public string score2 { get; set; }

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06014319 RID: 82713 RVA: 0x005654DF File Offset: 0x005636DF
		// (set) Token: 0x0601431A RID: 82714 RVA: 0x005654E7 File Offset: 0x005636E7
		public string score3 { get; set; }

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x0601431B RID: 82715 RVA: 0x005654F0 File Offset: 0x005636F0
		// (set) Token: 0x0601431C RID: 82716 RVA: 0x005654F8 File Offset: 0x005636F8
		public int id { get; set; }

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x0601431D RID: 82717 RVA: 0x00565501 File Offset: 0x00563701
		// (set) Token: 0x0601431E RID: 82718 RVA: 0x00565509 File Offset: 0x00563709
		public int specialAnswer { get; set; }

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x0601431F RID: 82719 RVA: 0x00565512 File Offset: 0x00563712
		// (set) Token: 0x06014320 RID: 82720 RVA: 0x0056551A File Offset: 0x0056371A
		public int trueAnswer { get; set; }

		// Token: 0x06014321 RID: 82721 RVA: 0x00565524 File Offset: 0x00563724
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.@event = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventA = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventAAnswer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventB = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventBAnswer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventC = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventCAnswer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventHelp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.score1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.score2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.score3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.specialAnswer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.trueAnswer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
