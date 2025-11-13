using System;

namespace core.config.effectbuff
{
	// Token: 0x0200205E RID: 8286
	public class IRoot
	{
		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x0600FD1B RID: 64795 RVA: 0x00402BB7 File Offset: 0x00400DB7
		// (set) Token: 0x0600FD1C RID: 64796 RVA: 0x00402BBF File Offset: 0x00400DBF
		public IBuffItem[] Buff { get; set; }

		// Token: 0x0600FD1D RID: 64797 RVA: 0x00402BC8 File Offset: 0x00400DC8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Buff = new IBuffItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Buff[i] = new IBuffItem();
					this.Buff[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
