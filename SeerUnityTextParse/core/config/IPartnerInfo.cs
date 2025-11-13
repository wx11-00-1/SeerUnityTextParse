using System;

namespace core.config
{
	// Token: 0x02001DB4 RID: 7604
	public class IPartnerInfo : IConfigItem
	{
		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x0600DFA6 RID: 57254 RVA: 0x003D8570 File Offset: 0x003D6770
		// (set) Token: 0x0600DFA7 RID: 57255 RVA: 0x003D8578 File Offset: 0x003D6778
		public string partnerName { get; set; }

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x0600DFA8 RID: 57256 RVA: 0x003D8581 File Offset: 0x003D6781
		// (set) Token: 0x0600DFA9 RID: 57257 RVA: 0x003D8589 File Offset: 0x003D6789
		public string type { get; set; }

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x0600DFAA RID: 57258 RVA: 0x003D8592 File Offset: 0x003D6792
		// (set) Token: 0x0600DFAB RID: 57259 RVA: 0x003D859A File Offset: 0x003D679A
		public int[] partnerMonsterId { get; set; }

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x0600DFAC RID: 57260 RVA: 0x003D85A3 File Offset: 0x003D67A3
		// (set) Token: 0x0600DFAD RID: 57261 RVA: 0x003D85AB File Offset: 0x003D67AB
		public int bitbuf { get; set; }

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x0600DFAE RID: 57262 RVA: 0x003D85B4 File Offset: 0x003D67B4
		// (set) Token: 0x0600DFAF RID: 57263 RVA: 0x003D85BC File Offset: 0x003D67BC
		public int choice { get; set; }

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x0600DFB0 RID: 57264 RVA: 0x003D85C5 File Offset: 0x003D67C5
		// (set) Token: 0x0600DFB1 RID: 57265 RVA: 0x003D85CD File Offset: 0x003D67CD
		public int cost { get; set; }

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x0600DFB2 RID: 57266 RVA: 0x003D85D6 File Offset: 0x003D67D6
		// (set) Token: 0x0600DFB3 RID: 57267 RVA: 0x003D85DE File Offset: 0x003D67DE
		public int id { get; set; }

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x0600DFB4 RID: 57268 RVA: 0x003D85E7 File Offset: 0x003D67E7
		// (set) Token: 0x0600DFB5 RID: 57269 RVA: 0x003D85EF File Offset: 0x003D67EF
		public int partnerNumber { get; set; }

		// Token: 0x0600DFB6 RID: 57270 RVA: 0x003D85F8 File Offset: 0x003D67F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bitbuf = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.choice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.partnerMonsterId = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.partnerMonsterId[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.partnerName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.partnerNumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
