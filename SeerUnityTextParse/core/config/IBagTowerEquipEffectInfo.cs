using System;

namespace core.config
{
	// Token: 0x02001EF5 RID: 7925
	public class IBagTowerEquipEffectInfo : IConfigItem
	{
		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x0600EA54 RID: 59988 RVA: 0x0042BCF8 File Offset: 0x00429EF8
		// (set) Token: 0x0600EA55 RID: 59989 RVA: 0x0042BD00 File Offset: 0x00429F00
		public string desc { get; set; }

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x0600EA56 RID: 59990 RVA: 0x0042BD09 File Offset: 0x00429F09
		// (set) Token: 0x0600EA57 RID: 59991 RVA: 0x0042BD11 File Offset: 0x00429F11
		public string image { get; set; }

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x0600EA58 RID: 59992 RVA: 0x0042BD1A File Offset: 0x00429F1A
		// (set) Token: 0x0600EA59 RID: 59993 RVA: 0x0042BD22 File Offset: 0x00429F22
		public int[] param2 { get; set; }

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x0600EA5A RID: 59994 RVA: 0x0042BD2B File Offset: 0x00429F2B
		// (set) Token: 0x0600EA5B RID: 59995 RVA: 0x0042BD33 File Offset: 0x00429F33
		public int effectclass { get; set; }

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x0600EA5C RID: 59996 RVA: 0x0042BD3C File Offset: 0x00429F3C
		// (set) Token: 0x0600EA5D RID: 59997 RVA: 0x0042BD44 File Offset: 0x00429F44
		public int effectsubtype { get; set; }

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x0600EA5E RID: 59998 RVA: 0x0042BD4D File Offset: 0x00429F4D
		// (set) Token: 0x0600EA5F RID: 59999 RVA: 0x0042BD55 File Offset: 0x00429F55
		public int effecttype { get; set; }

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x0600EA60 RID: 60000 RVA: 0x0042BD5E File Offset: 0x00429F5E
		// (set) Token: 0x0600EA61 RID: 60001 RVA: 0x0042BD66 File Offset: 0x00429F66
		public int front { get; set; }

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x0600EA62 RID: 60002 RVA: 0x0042BD6F File Offset: 0x00429F6F
		// (set) Token: 0x0600EA63 RID: 60003 RVA: 0x0042BD77 File Offset: 0x00429F77
		public int id { get; set; }

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x0600EA64 RID: 60004 RVA: 0x0042BD80 File Offset: 0x00429F80
		// (set) Token: 0x0600EA65 RID: 60005 RVA: 0x0042BD88 File Offset: 0x00429F88
		public int isfive { get; set; }

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x0600EA66 RID: 60006 RVA: 0x0042BD91 File Offset: 0x00429F91
		// (set) Token: 0x0600EA67 RID: 60007 RVA: 0x0042BD99 File Offset: 0x00429F99
		public int needsynthesis { get; set; }

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x0600EA68 RID: 60008 RVA: 0x0042BDA2 File Offset: 0x00429FA2
		// (set) Token: 0x0600EA69 RID: 60009 RVA: 0x0042BDAA File Offset: 0x00429FAA
		public int @object { get; set; }

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x0600EA6A RID: 60010 RVA: 0x0042BDB3 File Offset: 0x00429FB3
		// (set) Token: 0x0600EA6B RID: 60011 RVA: 0x0042BDBB File Offset: 0x00429FBB
		public int param1 { get; set; }

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x0600EA6C RID: 60012 RVA: 0x0042BDC4 File Offset: 0x00429FC4
		// (set) Token: 0x0600EA6D RID: 60013 RVA: 0x0042BDCC File Offset: 0x00429FCC
		public int quality { get; set; }

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x0600EA6E RID: 60014 RVA: 0x0042BDD5 File Offset: 0x00429FD5
		// (set) Token: 0x0600EA6F RID: 60015 RVA: 0x0042BDDD File Offset: 0x00429FDD
		public int repeat { get; set; }

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x0600EA70 RID: 60016 RVA: 0x0042BDE6 File Offset: 0x00429FE6
		// (set) Token: 0x0600EA71 RID: 60017 RVA: 0x0042BDEE File Offset: 0x00429FEE
		public int taketime { get; set; }

		// Token: 0x0600EA72 RID: 60018 RVA: 0x0042BDF8 File Offset: 0x00429FF8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.effectclass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.effectsubtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.effecttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.front = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isfive = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.needsynthesis = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.@object = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.param2 = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.param2[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.repeat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.taketime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
