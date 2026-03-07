using System;

namespace core.config
{
	// Token: 0x02002036 RID: 8246
	public class MountTail : XlsConfigBase<MountTail, IMountTailInfo>
	{
		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x0600F820 RID: 63520 RVA: 0x0043C7EE File Offset: 0x0043A9EE
		public override string fileName
		{
			get
			{
				return "mount_tail";
			}
		}

		// Token: 0x0600F821 RID: 63521 RVA: 0x0043C7F8 File Offset: 0x0043A9F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMountTailInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMountTailInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F822 RID: 63522 RVA: 0x0043C84C File Offset: 0x0043AA4C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
