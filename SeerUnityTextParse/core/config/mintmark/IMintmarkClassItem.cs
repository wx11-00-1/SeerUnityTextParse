using System;

namespace core.config.mintmark
{
	// Token: 0x02001FC4 RID: 8132
	public class IMintmarkClassItem
	{
		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x0600F526 RID: 62758 RVA: 0x003FA8BF File Offset: 0x003F8ABF
		// (set) Token: 0x0600F527 RID: 62759 RVA: 0x003FA8C7 File Offset: 0x003F8AC7
		public string ClassName { get; set; }

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x0600F528 RID: 62760 RVA: 0x003FA8D0 File Offset: 0x003F8AD0
		// (set) Token: 0x0600F529 RID: 62761 RVA: 0x003FA8D8 File Offset: 0x003F8AD8
		public int ID { get; set; }

		// Token: 0x0600F52A RID: 62762 RVA: 0x003FA8E1 File Offset: 0x003F8AE1
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ClassName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
