using System;

namespace core.config.ninjaroom
{
	// Token: 0x02002515 RID: 9493
	public class IRoot
	{
		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x06012624 RID: 75300 RVA: 0x004B7E3A File Offset: 0x004B603A
		// (set) Token: 0x06012625 RID: 75301 RVA: 0x004B7E42 File Offset: 0x004B6042
		public INinbous ninbous { get; set; }

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x06012626 RID: 75302 RVA: 0x004B7E4B File Offset: 0x004B604B
		// (set) Token: 0x06012627 RID: 75303 RVA: 0x004B7E53 File Offset: 0x004B6053
		public INinjas ninjas { get; set; }

		// Token: 0x06012628 RID: 75304 RVA: 0x004B7E5C File Offset: 0x004B605C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.ninbous = new INinbous();
				this.ninbous.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.ninjas = new INinjas();
				this.ninjas.Parse(bytes, ref byteIndex);
			}
		}
	}
}
