using System;

namespace core.config.hide_moves
{
	// Token: 0x02002028 RID: 8232
	public class IItemItem
	{
		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600FB5D RID: 64349 RVA: 0x00400ADE File Offset: 0x003FECDE
		// (set) Token: 0x0600FB5E RID: 64350 RVA: 0x00400AE6 File Offset: 0x003FECE6
		public string moveName1 { get; set; }

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600FB5F RID: 64351 RVA: 0x00400AEF File Offset: 0x003FECEF
		// (set) Token: 0x0600FB60 RID: 64352 RVA: 0x00400AF7 File Offset: 0x003FECF7
		public string moveName2 { get; set; }

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600FB61 RID: 64353 RVA: 0x00400B00 File Offset: 0x003FED00
		// (set) Token: 0x0600FB62 RID: 64354 RVA: 0x00400B08 File Offset: 0x003FED08
		public int moveId { get; set; }

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600FB63 RID: 64355 RVA: 0x00400B11 File Offset: 0x003FED11
		// (set) Token: 0x0600FB64 RID: 64356 RVA: 0x00400B19 File Offset: 0x003FED19
		public int petId { get; set; }

		// Token: 0x0600FB65 RID: 64357 RVA: 0x00400B24 File Offset: 0x003FED24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.moveId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moveName1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.moveName2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
