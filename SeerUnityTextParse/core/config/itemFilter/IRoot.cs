using System;

namespace core.config.itemFilter
{
	// Token: 0x02002025 RID: 8229
	public class IRoot
	{
		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600FB4D RID: 64333 RVA: 0x0040099A File Offset: 0x003FEB9A
		// (set) Token: 0x0600FB4E RID: 64334 RVA: 0x004009A2 File Offset: 0x003FEBA2
		public IBlood Blood { get; set; }

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600FB4F RID: 64335 RVA: 0x004009AB File Offset: 0x003FEBAB
		// (set) Token: 0x0600FB50 RID: 64336 RVA: 0x004009B3 File Offset: 0x003FEBB3
		public ICatch Catch { get; set; }

		// Token: 0x0600FB51 RID: 64337 RVA: 0x004009BC File Offset: 0x003FEBBC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Blood = new IBlood();
				this.Blood.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Catch = new ICatch();
				this.Catch.Parse(bytes, ref byteIndex);
			}
		}
	}
}
