using System;

namespace core.config.typesRelation
{
	// Token: 0x02001F04 RID: 7940
	public class IOpponentItem
	{
		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x0600EDC0 RID: 60864 RVA: 0x003F1964 File Offset: 0x003EFB64
		// (set) Token: 0x0600EDC1 RID: 60865 RVA: 0x003F196C File Offset: 0x003EFB6C
		public string type { get; set; }

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x0600EDC2 RID: 60866 RVA: 0x003F1975 File Offset: 0x003EFB75
		// (set) Token: 0x0600EDC3 RID: 60867 RVA: 0x003F197D File Offset: 0x003EFB7D
		public float multiple { get; set; }

		// Token: 0x0600EDC4 RID: 60868 RVA: 0x003F1986 File Offset: 0x003EFB86
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.multiple = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
