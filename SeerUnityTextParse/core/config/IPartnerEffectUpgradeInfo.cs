using System;

namespace core.config
{
	// Token: 0x02001DB6 RID: 7606
	public class IPartnerEffectUpgradeInfo : IConfigItem
	{
		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x0600DFBC RID: 57276 RVA: 0x003D872C File Offset: 0x003D692C
		// (set) Token: 0x0600DFBD RID: 57277 RVA: 0x003D8734 File Offset: 0x003D6934
		public string descAfter { get; set; }

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x0600DFBE RID: 57278 RVA: 0x003D873D File Offset: 0x003D693D
		// (set) Token: 0x0600DFBF RID: 57279 RVA: 0x003D8745 File Offset: 0x003D6945
		public string descBefore { get; set; }

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x0600DFC0 RID: 57280 RVA: 0x003D874E File Offset: 0x003D694E
		// (set) Token: 0x0600DFC1 RID: 57281 RVA: 0x003D8756 File Offset: 0x003D6956
		public string[] skill { get; set; }

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x0600DFC2 RID: 57282 RVA: 0x003D875F File Offset: 0x003D695F
		// (set) Token: 0x0600DFC3 RID: 57283 RVA: 0x003D8767 File Offset: 0x003D6967
		public int id { get; set; }

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x0600DFC4 RID: 57284 RVA: 0x003D8770 File Offset: 0x003D6970
		// (set) Token: 0x0600DFC5 RID: 57285 RVA: 0x003D8778 File Offset: 0x003D6978
		public int monID { get; set; }

		// Token: 0x0600DFC6 RID: 57286 RVA: 0x003D8784 File Offset: 0x003D6984
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.descAfter = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.descBefore = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.skill = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.skill[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
