using System;

namespace core.config
{
	// Token: 0x02001DB8 RID: 7608
	public class IPassRewardInfo : IConfigItem
	{
		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x0600DFCC RID: 57292 RVA: 0x003D8898 File Offset: 0x003D6A98
		// (set) Token: 0x0600DFCD RID: 57293 RVA: 0x003D88A0 File Offset: 0x003D6AA0
		public string freereward { get; set; }

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x0600DFCE RID: 57294 RVA: 0x003D88A9 File Offset: 0x003D6AA9
		// (set) Token: 0x0600DFCF RID: 57295 RVA: 0x003D88B1 File Offset: 0x003D6AB1
		public string paidreward { get; set; }

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x0600DFD0 RID: 57296 RVA: 0x003D88BA File Offset: 0x003D6ABA
		// (set) Token: 0x0600DFD1 RID: 57297 RVA: 0x003D88C2 File Offset: 0x003D6AC2
		public int diamondnum { get; set; }

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x0600DFD2 RID: 57298 RVA: 0x003D88CB File Offset: 0x003D6ACB
		// (set) Token: 0x0600DFD3 RID: 57299 RVA: 0x003D88D3 File Offset: 0x003D6AD3
		public int exp { get; set; }

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x0600DFD4 RID: 57300 RVA: 0x003D88DC File Offset: 0x003D6ADC
		// (set) Token: 0x0600DFD5 RID: 57301 RVA: 0x003D88E4 File Offset: 0x003D6AE4
		public int id { get; set; }

		// Token: 0x0600DFD6 RID: 57302 RVA: 0x003D88F0 File Offset: 0x003D6AF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.diamondnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.freereward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.paidreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
