using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F4A RID: 8010
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x0600F046 RID: 61510 RVA: 0x003F49FB File Offset: 0x003F2BFB
		public override string fileName
		{
			get
			{
				return "pet_advance";
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x0600F047 RID: 61511 RVA: 0x003F4A02 File Offset: 0x003F2C02
		// (set) Token: 0x0600F048 RID: 61512 RVA: 0x003F4A0A File Offset: 0x003F2C0A
		public IRoot root { get; set; }

		// Token: 0x0600F049 RID: 61513 RVA: 0x003F4A13 File Offset: 0x003F2C13
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F04A RID: 61514 RVA: 0x003F4A38 File Offset: 0x003F2C38
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
