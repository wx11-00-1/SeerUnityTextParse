using System;

namespace core.config.itemFilter
{
	// Token: 0x02002027 RID: 8231
	public class ITopLevel
	{
		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600FB59 RID: 64345 RVA: 0x00400A70 File Offset: 0x003FEC70
		// (set) Token: 0x0600FB5A RID: 64346 RVA: 0x00400A78 File Offset: 0x003FEC78
		public IItemItem[] Item { get; set; }

		// Token: 0x0600FB5B RID: 64347 RVA: 0x00400A84 File Offset: 0x003FEC84
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
		}
	}
}
