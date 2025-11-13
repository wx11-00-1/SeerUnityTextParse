using System;

namespace core.config.effectInfo
{
	// Token: 0x02002054 RID: 8276
	public class IParamTypeItem : IConfigItem
	{
		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x0600FCB7 RID: 64695 RVA: 0x004023F3 File Offset: 0x004005F3
		// (set) Token: 0x0600FCB8 RID: 64696 RVA: 0x004023FB File Offset: 0x004005FB
		public string @params { get; set; }

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x0600FCB9 RID: 64697 RVA: 0x00402404 File Offset: 0x00400604
		// (set) Token: 0x0600FCBA RID: 64698 RVA: 0x0040240C File Offset: 0x0040060C
		public int id { get; set; }

		// Token: 0x0600FCBB RID: 64699 RVA: 0x00402415 File Offset: 0x00400615
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.@params = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
