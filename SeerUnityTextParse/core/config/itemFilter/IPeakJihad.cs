using System;

namespace core.config.itemFilter
{
	// Token: 0x02002024 RID: 8228
	public class IPeakJihad
	{
		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x0600FB47 RID: 64327 RVA: 0x00400908 File Offset: 0x003FEB08
		// (set) Token: 0x0600FB48 RID: 64328 RVA: 0x00400910 File Offset: 0x003FEB10
		public string des { get; set; }

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x0600FB49 RID: 64329 RVA: 0x00400919 File Offset: 0x003FEB19
		// (set) Token: 0x0600FB4A RID: 64330 RVA: 0x00400921 File Offset: 0x003FEB21
		public IItemItem[] Item { get; set; }

		// Token: 0x0600FB4B RID: 64331 RVA: 0x0040092C File Offset: 0x003FEB2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Item[i] = new IItemItem();
					this.Item[i].Parse(bytes, ref byteIndex);
				}
			}
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
