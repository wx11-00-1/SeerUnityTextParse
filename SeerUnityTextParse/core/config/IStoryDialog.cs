using System;

namespace core.config
{
	// Token: 0x02001E44 RID: 7748
	public class IStoryDialog : IConfigItem
	{
		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x0600E5B6 RID: 58806 RVA: 0x003E0063 File Offset: 0x003DE263
		// (set) Token: 0x0600E5B7 RID: 58807 RVA: 0x003E006B File Offset: 0x003DE26B
		public float control { get; set; }

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x0600E5B8 RID: 58808 RVA: 0x003E0074 File Offset: 0x003DE274
		// (set) Token: 0x0600E5B9 RID: 58809 RVA: 0x003E007C File Offset: 0x003DE27C
		public int id { get; set; }

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x003E0085 File Offset: 0x003DE285
		// (set) Token: 0x0600E5BB RID: 58811 RVA: 0x003E008D File Offset: 0x003DE28D
		public int logic { get; set; }

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x003E0096 File Offset: 0x003DE296
		// (set) Token: 0x0600E5BD RID: 58813 RVA: 0x003E009E File Offset: 0x003DE29E
		public int next { get; set; }

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600E5BE RID: 58814 RVA: 0x003E00A7 File Offset: 0x003DE2A7
		// (set) Token: 0x0600E5BF RID: 58815 RVA: 0x003E00AF File Offset: 0x003DE2AF
		public string param1 { get; set; }

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x003E00B8 File Offset: 0x003DE2B8
		// (set) Token: 0x0600E5C1 RID: 58817 RVA: 0x003E00C0 File Offset: 0x003DE2C0
		public string param2 { get; set; }

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x003E00C9 File Offset: 0x003DE2C9
		// (set) Token: 0x0600E5C3 RID: 58819 RVA: 0x003E00D1 File Offset: 0x003DE2D1
		public string param3 { get; set; }

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x0600E5C4 RID: 58820 RVA: 0x003E00DA File Offset: 0x003DE2DA
		// (set) Token: 0x0600E5C5 RID: 58821 RVA: 0x003E00E2 File Offset: 0x003DE2E2
		public string param4 { get; set; }

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x0600E5C6 RID: 58822 RVA: 0x003E00EB File Offset: 0x003DE2EB
		// (set) Token: 0x0600E5C7 RID: 58823 RVA: 0x003E00F3 File Offset: 0x003DE2F3
		public string param5 { get; set; }

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x003E00FC File Offset: 0x003DE2FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			if (float.IsNaN(this.control))
			{
				byteIndex = num;
				this.control = (float)ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
