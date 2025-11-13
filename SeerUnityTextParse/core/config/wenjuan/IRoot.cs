using System;

namespace core.config.wenjuan
{
	// Token: 0x02001EF3 RID: 7923
	public class IRoot
	{
		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x0600ED28 RID: 60712 RVA: 0x003F0EBD File Offset: 0x003EF0BD
		// (set) Token: 0x0600ED29 RID: 60713 RVA: 0x003F0EC5 File Offset: 0x003EF0C5
		public IDetail detail { get; set; }

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x0600ED2A RID: 60714 RVA: 0x003F0ECE File Offset: 0x003EF0CE
		// (set) Token: 0x0600ED2B RID: 60715 RVA: 0x003F0ED6 File Offset: 0x003EF0D6
		public IWjmain wjmain { get; set; }

		// Token: 0x0600ED2C RID: 60716 RVA: 0x003F0EE0 File Offset: 0x003EF0E0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.detail = new IDetail();
				this.detail.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.wjmain = new IWjmain();
				this.wjmain.Parse(bytes, ref byteIndex);
			}
		}
	}
}
