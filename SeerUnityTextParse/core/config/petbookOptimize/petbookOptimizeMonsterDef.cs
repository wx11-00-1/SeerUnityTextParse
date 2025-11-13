using System;

namespace core.config.petbookOptimize
{
	// Token: 0x02001ECB RID: 7883
	public class petbookOptimizeMonsterDef
	{
		// Token: 0x0600EBD9 RID: 60377 RVA: 0x003EF2B0 File Offset: 0x003ED4B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Features = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.jumptarget = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}

		// Token: 0x0400EF06 RID: 61190
		public int ID;

		// Token: 0x0400EF07 RID: 61191
		public string Features;

		// Token: 0x0400EF08 RID: 61192
		public string jumptarget;
	}
}
