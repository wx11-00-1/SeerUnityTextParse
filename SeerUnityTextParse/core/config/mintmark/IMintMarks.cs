using System;

namespace core.config.mintmark
{
	// Token: 0x02001FC3 RID: 8131
	public class IMintMarks
	{
		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x0600F520 RID: 62752 RVA: 0x003FA7FB File Offset: 0x003F89FB
		// (set) Token: 0x0600F521 RID: 62753 RVA: 0x003FA803 File Offset: 0x003F8A03
		public IMintMarkItem[] MintMark { get; set; }

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600F522 RID: 62754 RVA: 0x003FA80C File Offset: 0x003F8A0C
		// (set) Token: 0x0600F523 RID: 62755 RVA: 0x003FA814 File Offset: 0x003F8A14
		public IMintmarkClassItem[] MintmarkClass { get; set; }

		// Token: 0x0600F524 RID: 62756 RVA: 0x003FA820 File Offset: 0x003F8A20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MintMark = new IMintMarkItem[num];
				for (int i = 0; i < num; i++)
				{
					this.MintMark[i] = new IMintMarkItem();
					this.MintMark[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MintmarkClass = new IMintmarkClassItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.MintmarkClass[j] = new IMintmarkClassItem();
					this.MintmarkClass[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
