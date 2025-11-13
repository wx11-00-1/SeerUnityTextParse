using System;

namespace core.config.open_bonus
{
	// Token: 0x02001F7D RID: 8061
	public class IBonusItem
	{
		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x0600F1DA RID: 61914 RVA: 0x003F6962 File Offset: 0x003F4B62
		// (set) Token: 0x0600F1DB RID: 61915 RVA: 0x003F696A File Offset: 0x003F4B6A
		public IOutItem[] Out { get; set; }

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x0600F1DC RID: 61916 RVA: 0x003F6973 File Offset: 0x003F4B73
		// (set) Token: 0x0600F1DD RID: 61917 RVA: 0x003F697B File Offset: 0x003F4B7B
		public int ID { get; set; }

		// Token: 0x0600F1DE RID: 61918 RVA: 0x003F6984 File Offset: 0x003F4B84
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Out = new IOutItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Out[i] = new IOutItem();
					this.Out[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
