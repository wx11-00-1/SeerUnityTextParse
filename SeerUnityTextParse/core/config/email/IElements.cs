using System;

namespace core.config.email
{
	// Token: 0x02002048 RID: 8264
	public class IElements
	{
		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x0600FC5F RID: 64607 RVA: 0x00401D32 File Offset: 0x003FFF32
		// (set) Token: 0x0600FC60 RID: 64608 RVA: 0x00401D3A File Offset: 0x003FFF3A
		public IElementItem[] element { get; set; }

		// Token: 0x0600FC61 RID: 64609 RVA: 0x00401D44 File Offset: 0x003FFF44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.element = new IElementItem[num];
				for (int i = 0; i < num; i++)
				{
					this.element[i] = new IElementItem();
					this.element[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
