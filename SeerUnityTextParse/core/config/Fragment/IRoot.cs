using System;

namespace core.config.Fragment
{
	// Token: 0x02002034 RID: 8244
	public class IRoot
	{
		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x0600FBC7 RID: 64455 RVA: 0x0040120D File Offset: 0x003FF40D
		// (set) Token: 0x0600FBC8 RID: 64456 RVA: 0x00401215 File Offset: 0x003FF415
		public IFragmentItem[] Fragment { get; set; }

		// Token: 0x0600FBC9 RID: 64457 RVA: 0x00401220 File Offset: 0x003FF420
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Fragment = new IFragmentItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Fragment[i] = new IFragmentItem();
					this.Fragment[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
