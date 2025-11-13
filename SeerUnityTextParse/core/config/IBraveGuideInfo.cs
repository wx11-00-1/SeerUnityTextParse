using System;

namespace core.config
{
	// Token: 0x02001CDA RID: 7386
	public class IBraveGuideInfo : IConfigItem
	{
		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x0600D66C RID: 54892 RVA: 0x003CCDF4 File Offset: 0x003CAFF4
		// (set) Token: 0x0600D66D RID: 54893 RVA: 0x003CCDFC File Offset: 0x003CAFFC
		public string[] guideparam { get; set; }

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x0600D66E RID: 54894 RVA: 0x003CCE05 File Offset: 0x003CB005
		// (set) Token: 0x0600D66F RID: 54895 RVA: 0x003CCE0D File Offset: 0x003CB00D
		public int guidetype { get; set; }

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x0600D670 RID: 54896 RVA: 0x003CCE16 File Offset: 0x003CB016
		// (set) Token: 0x0600D671 RID: 54897 RVA: 0x003CCE1E File Offset: 0x003CB01E
		public int id { get; set; }

		// Token: 0x0600D672 RID: 54898 RVA: 0x003CCE28 File Offset: 0x003CB028
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.guideparam = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.guideparam[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.guidetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
