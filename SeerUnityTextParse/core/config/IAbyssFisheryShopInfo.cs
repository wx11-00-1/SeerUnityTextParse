using System;

namespace core.config
{
	// Token: 0x020026B5 RID: 9909
	public class IAbyssFisheryShopInfo : IConfigItem
	{
		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x060137A3 RID: 79779 RVA: 0x00583B10 File Offset: 0x00581D10
		// (set) Token: 0x060137A4 RID: 79780 RVA: 0x00583B18 File Offset: 0x00581D18
		public string des { get; set; }

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x060137A5 RID: 79781 RVA: 0x00583B21 File Offset: 0x00581D21
		// (set) Token: 0x060137A6 RID: 79782 RVA: 0x00583B29 File Offset: 0x00581D29
		public string functiondes { get; set; }

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x060137A7 RID: 79783 RVA: 0x00583B32 File Offset: 0x00581D32
		// (set) Token: 0x060137A8 RID: 79784 RVA: 0x00583B3A File Offset: 0x00581D3A
		public string name { get; set; }

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x060137A9 RID: 79785 RVA: 0x00583B43 File Offset: 0x00581D43
		// (set) Token: 0x060137AA RID: 79786 RVA: 0x00583B4B File Offset: 0x00581D4B
		public int functiontype { get; set; }

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x060137AB RID: 79787 RVA: 0x00583B54 File Offset: 0x00581D54
		// (set) Token: 0x060137AC RID: 79788 RVA: 0x00583B5C File Offset: 0x00581D5C
		public int functionvalue { get; set; }

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x060137AD RID: 79789 RVA: 0x00583B65 File Offset: 0x00581D65
		// (set) Token: 0x060137AE RID: 79790 RVA: 0x00583B6D File Offset: 0x00581D6D
		public int id { get; set; }

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x060137AF RID: 79791 RVA: 0x00583B76 File Offset: 0x00581D76
		// (set) Token: 0x060137B0 RID: 79792 RVA: 0x00583B7E File Offset: 0x00581D7E
		public int price { get; set; }

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x060137B1 RID: 79793 RVA: 0x00583B87 File Offset: 0x00581D87
		// (set) Token: 0x060137B2 RID: 79794 RVA: 0x00583B8F File Offset: 0x00581D8F
		public int subtype { get; set; }

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x060137B3 RID: 79795 RVA: 0x00583B98 File Offset: 0x00581D98
		// (set) Token: 0x060137B4 RID: 79796 RVA: 0x00583BA0 File Offset: 0x00581DA0
		public int type { get; set; }

		// Token: 0x060137B5 RID: 79797 RVA: 0x00583BAC File Offset: 0x00581DAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.functiondes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.functiontype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.functionvalue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
