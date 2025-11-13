using System;

namespace core.config
{
	// Token: 0x02001DA8 RID: 7592
	public class INewSeerWelfareInfo : IConfigItem
	{
		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x0600DEDE RID: 57054 RVA: 0x003D7678 File Offset: 0x003D5878
		// (set) Token: 0x0600DEDF RID: 57055 RVA: 0x003D7680 File Offset: 0x003D5880
		public string beginning { get; set; }

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x0600DEE0 RID: 57056 RVA: 0x003D7689 File Offset: 0x003D5889
		// (set) Token: 0x0600DEE1 RID: 57057 RVA: 0x003D7691 File Offset: 0x003D5891
		public string ending { get; set; }

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x0600DEE2 RID: 57058 RVA: 0x003D769A File Offset: 0x003D589A
		// (set) Token: 0x0600DEE3 RID: 57059 RVA: 0x003D76A2 File Offset: 0x003D58A2
		public string name { get; set; }

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x0600DEE4 RID: 57060 RVA: 0x003D76AB File Offset: 0x003D58AB
		// (set) Token: 0x0600DEE5 RID: 57061 RVA: 0x003D76B3 File Offset: 0x003D58B3
		public string statLog { get; set; }

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x0600DEE6 RID: 57062 RVA: 0x003D76BC File Offset: 0x003D58BC
		// (set) Token: 0x0600DEE7 RID: 57063 RVA: 0x003D76C4 File Offset: 0x003D58C4
		public int Go { get; set; }

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x0600DEE8 RID: 57064 RVA: 0x003D76CD File Offset: 0x003D58CD
		// (set) Token: 0x0600DEE9 RID: 57065 RVA: 0x003D76D5 File Offset: 0x003D58D5
		public int id { get; set; }

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x0600DEEA RID: 57066 RVA: 0x003D76DE File Offset: 0x003D58DE
		// (set) Token: 0x0600DEEB RID: 57067 RVA: 0x003D76E6 File Offset: 0x003D58E6
		public int redPointID { get; set; }

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x0600DEEC RID: 57068 RVA: 0x003D76EF File Offset: 0x003D58EF
		// (set) Token: 0x0600DEED RID: 57069 RVA: 0x003D76F7 File Offset: 0x003D58F7
		public int sorting { get; set; }

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x0600DEEE RID: 57070 RVA: 0x003D7700 File Offset: 0x003D5900
		// (set) Token: 0x0600DEEF RID: 57071 RVA: 0x003D7708 File Offset: 0x003D5908
		public int type { get; set; }

		// Token: 0x0600DEF0 RID: 57072 RVA: 0x003D7714 File Offset: 0x003D5914
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.redPointID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.statLog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
