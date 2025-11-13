using System;

namespace core.config.itemFilter
{
	// Token: 0x02002022 RID: 8226
	public class ICatch
	{
		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600FB19 RID: 64281 RVA: 0x004005F2 File Offset: 0x003FE7F2
		// (set) Token: 0x0600FB1A RID: 64282 RVA: 0x004005FA File Offset: 0x003FE7FA
		public string _text { get; set; }

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x0600FB1B RID: 64283 RVA: 0x00400603 File Offset: 0x003FE803
		// (set) Token: 0x0600FB1C RID: 64284 RVA: 0x0040060B File Offset: 0x003FE80B
		public string des { get; set; }

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x0600FB1D RID: 64285 RVA: 0x00400614 File Offset: 0x003FE814
		// (set) Token: 0x0600FB1E RID: 64286 RVA: 0x0040061C File Offset: 0x003FE81C
		public IItemItem[] Item { get; set; }

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x0600FB1F RID: 64287 RVA: 0x00400625 File Offset: 0x003FE825
		// (set) Token: 0x0600FB20 RID: 64288 RVA: 0x0040062D File Offset: 0x003FE82D
		public ITopLevel SP { get; set; }

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x0600FB21 RID: 64289 RVA: 0x00400636 File Offset: 0x003FE836
		// (set) Token: 0x0600FB22 RID: 64290 RVA: 0x0040063E File Offset: 0x003FE83E
		public IPeakJihad SUPER_ID { get; set; }

		// Token: 0x0600FB23 RID: 64291 RVA: 0x00400648 File Offset: 0x003FE848
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
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.SP = new ITopLevel();
				this.SP.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.SUPER_ID = new IPeakJihad();
				this.SUPER_ID.Parse(bytes, ref byteIndex);
			}
			this._text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
