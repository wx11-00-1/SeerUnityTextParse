using System;

namespace core.config
{
	// Token: 0x0200212B RID: 8491
	public class IAutocardClientEffectInfo : IConfigItem
	{
		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x0600FC1E RID: 64542 RVA: 0x0047C828 File Offset: 0x0047AA28
		// (set) Token: 0x0600FC1F RID: 64543 RVA: 0x0047C830 File Offset: 0x0047AA30
		public string param { get; set; }

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x0600FC20 RID: 64544 RVA: 0x0047C839 File Offset: 0x0047AA39
		// (set) Token: 0x0600FC21 RID: 64545 RVA: 0x0047C841 File Offset: 0x0047AA41
		public string paramDes { get; set; }

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x0600FC22 RID: 64546 RVA: 0x0047C84A File Offset: 0x0047AA4A
		// (set) Token: 0x0600FC23 RID: 64547 RVA: 0x0047C852 File Offset: 0x0047AA52
		public int id { get; set; }

		// Token: 0x0600FC24 RID: 64548 RVA: 0x0047C85B File Offset: 0x0047AA5B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.paramDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
