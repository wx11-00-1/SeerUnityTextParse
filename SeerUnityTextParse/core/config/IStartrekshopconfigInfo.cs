using System;

namespace core.config
{
	// Token: 0x02001E40 RID: 7744
	public class IStartrekshopconfigInfo : IConfigItem
	{
		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x0600E586 RID: 58758 RVA: 0x003DFC64 File Offset: 0x003DDE64
		// (set) Token: 0x0600E587 RID: 58759 RVA: 0x003DFC6C File Offset: 0x003DDE6C
		public string GoodsName { get; set; }

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600E588 RID: 58760 RVA: 0x003DFC75 File Offset: 0x003DDE75
		// (set) Token: 0x0600E589 RID: 58761 RVA: 0x003DFC7D File Offset: 0x003DDE7D
		public string PetID { get; set; }

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x0600E58A RID: 58762 RVA: 0x003DFC86 File Offset: 0x003DDE86
		// (set) Token: 0x0600E58B RID: 58763 RVA: 0x003DFC8E File Offset: 0x003DDE8E
		public string PetName { get; set; }

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x0600E58C RID: 58764 RVA: 0x003DFC97 File Offset: 0x003DDE97
		// (set) Token: 0x0600E58D RID: 58765 RVA: 0x003DFC9F File Offset: 0x003DDE9F
		public int[] rewardinfo { get; set; }

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x0600E58E RID: 58766 RVA: 0x003DFCA8 File Offset: 0x003DDEA8
		// (set) Token: 0x0600E58F RID: 58767 RVA: 0x003DFCB0 File Offset: 0x003DDEB0
		public int[] title { get; set; }

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x0600E590 RID: 58768 RVA: 0x003DFCB9 File Offset: 0x003DDEB9
		// (set) Token: 0x0600E591 RID: 58769 RVA: 0x003DFCC1 File Offset: 0x003DDEC1
		public int Atk { get; set; }

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x0600E592 RID: 58770 RVA: 0x003DFCCA File Offset: 0x003DDECA
		// (set) Token: 0x0600E593 RID: 58771 RVA: 0x003DFCD2 File Offset: 0x003DDED2
		public int Def { get; set; }

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x0600E594 RID: 58772 RVA: 0x003DFCDB File Offset: 0x003DDEDB
		// (set) Token: 0x0600E595 RID: 58773 RVA: 0x003DFCE3 File Offset: 0x003DDEE3
		public int GoodsBuffType { get; set; }

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x0600E596 RID: 58774 RVA: 0x003DFCEC File Offset: 0x003DDEEC
		// (set) Token: 0x0600E597 RID: 58775 RVA: 0x003DFCF4 File Offset: 0x003DDEF4
		public int GoodsID { get; set; }

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x0600E598 RID: 58776 RVA: 0x003DFCFD File Offset: 0x003DDEFD
		// (set) Token: 0x0600E599 RID: 58777 RVA: 0x003DFD05 File Offset: 0x003DDF05
		public int GoodsPrice { get; set; }

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x0600E59A RID: 58778 RVA: 0x003DFD0E File Offset: 0x003DDF0E
		// (set) Token: 0x0600E59B RID: 58779 RVA: 0x003DFD16 File Offset: 0x003DDF16
		public int GoodsType { get; set; }

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x0600E59C RID: 58780 RVA: 0x003DFD1F File Offset: 0x003DDF1F
		// (set) Token: 0x0600E59D RID: 58781 RVA: 0x003DFD27 File Offset: 0x003DDF27
		public int HP { get; set; }

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x0600E59E RID: 58782 RVA: 0x003DFD30 File Offset: 0x003DDF30
		// (set) Token: 0x0600E59F RID: 58783 RVA: 0x003DFD38 File Offset: 0x003DDF38
		public int id { get; set; }

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x0600E5A0 RID: 58784 RVA: 0x003DFD41 File Offset: 0x003DDF41
		// (set) Token: 0x0600E5A1 RID: 58785 RVA: 0x003DFD49 File Offset: 0x003DDF49
		public int SP_Atk { get; set; }

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x003DFD52 File Offset: 0x003DDF52
		// (set) Token: 0x0600E5A3 RID: 58787 RVA: 0x003DFD5A File Offset: 0x003DDF5A
		public int SP_Def { get; set; }

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600E5A4 RID: 58788 RVA: 0x003DFD63 File Offset: 0x003DDF63
		// (set) Token: 0x0600E5A5 RID: 58789 RVA: 0x003DFD6B File Offset: 0x003DDF6B
		public int Spd { get; set; }

		// Token: 0x0600E5A6 RID: 58790 RVA: 0x003DFD74 File Offset: 0x003DDF74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.GoodsBuffType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.GoodsID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.GoodsName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GoodsPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.GoodsType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.PetName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SP_Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SP_Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Spd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.title = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.title[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
