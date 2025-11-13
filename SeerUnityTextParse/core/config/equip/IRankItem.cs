using System;

namespace core.config.equip
{
	// Token: 0x02002042 RID: 8258
	public class IRankItem
	{
		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x0600FC33 RID: 64563 RVA: 0x00401A6A File Offset: 0x003FFC6A
		// (set) Token: 0x0600FC34 RID: 64564 RVA: 0x00401A72 File Offset: 0x003FFC72
		public string Desc { get; set; }

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x0600FC35 RID: 64565 RVA: 0x00401A7B File Offset: 0x003FFC7B
		// (set) Token: 0x0600FC36 RID: 64566 RVA: 0x00401A83 File Offset: 0x003FFC83
		public int Lv { get; set; }

		// Token: 0x0600FC37 RID: 64567 RVA: 0x00401A8C File Offset: 0x003FFC8C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
