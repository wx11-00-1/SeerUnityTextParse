using System;

namespace core.config.Attirerecycle
{
	// Token: 0x02002070 RID: 8304
	public class IAttirerecycles
	{
		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600FD95 RID: 64917 RVA: 0x00403476 File Offset: 0x00401676
		// (set) Token: 0x0600FD96 RID: 64918 RVA: 0x0040347E File Offset: 0x0040167E
		public IAttirerecycleItem[] Attirerecycle { get; set; }

		// Token: 0x0600FD97 RID: 64919 RVA: 0x00403488 File Offset: 0x00401688
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Attirerecycle = new IAttirerecycleItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Attirerecycle[i] = new IAttirerecycleItem();
					this.Attirerecycle[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
