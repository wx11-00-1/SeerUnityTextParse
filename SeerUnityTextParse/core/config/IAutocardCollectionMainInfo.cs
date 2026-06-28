using System;

namespace core.config
{
	// Token: 0x02002569 RID: 9577
	public class IAutocardCollectionMainInfo : IConfigItem
	{
		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x060128ED RID: 76013 RVA: 0x00545BC0 File Offset: 0x00543DC0
		// (set) Token: 0x060128EE RID: 76014 RVA: 0x00545BC8 File Offset: 0x00543DC8
		public string animation { get; set; }

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x060128EF RID: 76015 RVA: 0x00545BD1 File Offset: 0x00543DD1
		// (set) Token: 0x060128F0 RID: 76016 RVA: 0x00545BD9 File Offset: 0x00543DD9
		public int id { get; set; }

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x060128F1 RID: 76017 RVA: 0x00545BE2 File Offset: 0x00543DE2
		// (set) Token: 0x060128F2 RID: 76018 RVA: 0x00545BEA File Offset: 0x00543DEA
		public int itemid { get; set; }

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x060128F3 RID: 76019 RVA: 0x00545BF3 File Offset: 0x00543DF3
		// (set) Token: 0x060128F4 RID: 76020 RVA: 0x00545BFB File Offset: 0x00543DFB
		public int rank { get; set; }

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x060128F5 RID: 76021 RVA: 0x00545C04 File Offset: 0x00543E04
		// (set) Token: 0x060128F6 RID: 76022 RVA: 0x00545C0C File Offset: 0x00543E0C
		public int sesisson { get; set; }

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x060128F7 RID: 76023 RVA: 0x00545C15 File Offset: 0x00543E15
		// (set) Token: 0x060128F8 RID: 76024 RVA: 0x00545C1D File Offset: 0x00543E1D
		public int tips { get; set; }

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x060128F9 RID: 76025 RVA: 0x00545C26 File Offset: 0x00543E26
		// (set) Token: 0x060128FA RID: 76026 RVA: 0x00545C2E File Offset: 0x00543E2E
		public int type { get; set; }

		// Token: 0x060128FB RID: 76027 RVA: 0x00545C38 File Offset: 0x00543E38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.animation = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sesisson = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tips = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
