using System;

namespace core.config
{
	// Token: 0x02002567 RID: 9575
	public class IAutocardCollectInfo : IConfigItem
	{
		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x060128CF RID: 75983 RVA: 0x00545994 File Offset: 0x00543B94
		// (set) Token: 0x060128D0 RID: 75984 RVA: 0x0054599C File Offset: 0x00543B9C
		public string decompose { get; set; }

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x060128D1 RID: 75985 RVA: 0x005459A5 File Offset: 0x00543BA5
		// (set) Token: 0x060128D2 RID: 75986 RVA: 0x005459AD File Offset: 0x00543BAD
		public string ExpTotal { get; set; }

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x060128D3 RID: 75987 RVA: 0x005459B6 File Offset: 0x00543BB6
		// (set) Token: 0x060128D4 RID: 75988 RVA: 0x005459BE File Offset: 0x00543BBE
		public string levelinfo { get; set; }

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x060128D5 RID: 75989 RVA: 0x005459C7 File Offset: 0x00543BC7
		// (set) Token: 0x060128D6 RID: 75990 RVA: 0x005459CF File Offset: 0x00543BCF
		public string Reward_1 { get; set; }

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x060128D7 RID: 75991 RVA: 0x005459D8 File Offset: 0x00543BD8
		// (set) Token: 0x060128D8 RID: 75992 RVA: 0x005459E0 File Offset: 0x00543BE0
		public string Reward_2 { get; set; }

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x060128D9 RID: 75993 RVA: 0x005459E9 File Offset: 0x00543BE9
		// (set) Token: 0x060128DA RID: 75994 RVA: 0x005459F1 File Offset: 0x00543BF1
		public string Reward_3 { get; set; }

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x060128DB RID: 75995 RVA: 0x005459FA File Offset: 0x00543BFA
		// (set) Token: 0x060128DC RID: 75996 RVA: 0x00545A02 File Offset: 0x00543C02
		public string rewardbit { get; set; }

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x060128DD RID: 75997 RVA: 0x00545A0B File Offset: 0x00543C0B
		// (set) Token: 0x060128DE RID: 75998 RVA: 0x00545A13 File Offset: 0x00543C13
		public int card_id { get; set; }

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x060128DF RID: 75999 RVA: 0x00545A1C File Offset: 0x00543C1C
		// (set) Token: 0x060128E0 RID: 76000 RVA: 0x00545A24 File Offset: 0x00543C24
		public int Expforever { get; set; }

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x060128E1 RID: 76001 RVA: 0x00545A2D File Offset: 0x00543C2D
		// (set) Token: 0x060128E2 RID: 76002 RVA: 0x00545A35 File Offset: 0x00543C35
		public int id { get; set; }

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x060128E3 RID: 76003 RVA: 0x00545A3E File Offset: 0x00543C3E
		// (set) Token: 0x060128E4 RID: 76004 RVA: 0x00545A46 File Offset: 0x00543C46
		public int Rewarduserinfo { get; set; }

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x060128E5 RID: 76005 RVA: 0x00545A4F File Offset: 0x00543C4F
		// (set) Token: 0x060128E6 RID: 76006 RVA: 0x00545A57 File Offset: 0x00543C57
		public int sesisson { get; set; }

		// Token: 0x060128E7 RID: 76007 RVA: 0x00545A60 File Offset: 0x00543C60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExpTotal = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Expforever = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Reward_1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Reward_2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Reward_3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rewarduserinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.card_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.decompose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.levelinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardbit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sesisson = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
