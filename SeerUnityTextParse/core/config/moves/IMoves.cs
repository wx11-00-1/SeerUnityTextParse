using System;

namespace core.config.moves
{
	// Token: 0x02001FA6 RID: 8102
	public class IMoves
	{
		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600F39E RID: 62366 RVA: 0x003F8ADC File Offset: 0x003F6CDC
		// (set) Token: 0x0600F39F RID: 62367 RVA: 0x003F8AE4 File Offset: 0x003F6CE4
		public string _text { get; set; }

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x0600F3A0 RID: 62368 RVA: 0x003F8AED File Offset: 0x003F6CED
		// (set) Token: 0x0600F3A1 RID: 62369 RVA: 0x003F8AF5 File Offset: 0x003F6CF5
		public IMoveItem[] Move { get; set; }

		// Token: 0x0600F3A2 RID: 62370 RVA: 0x003F8B00 File Offset: 0x003F6D00
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Move = new IMoveItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Move[i] = new IMoveItem();
					this.Move[i].Parse(bytes, ref byteIndex);
				}
			}
			this._text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
