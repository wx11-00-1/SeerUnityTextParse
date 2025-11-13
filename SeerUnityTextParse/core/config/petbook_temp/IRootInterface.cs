using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F5A RID: 8026
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x0600F0D0 RID: 61648 RVA: 0x003F548D File Offset: 0x003F368D
		public override string fileName
		{
			get
			{
				return "petbook_temp";
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x0600F0D1 RID: 61649 RVA: 0x003F5494 File Offset: 0x003F3694
		// (set) Token: 0x0600F0D2 RID: 61650 RVA: 0x003F549C File Offset: 0x003F369C
		public IRoot root { get; set; }

		// Token: 0x0600F0D3 RID: 61651 RVA: 0x003F54A5 File Offset: 0x003F36A5
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F0D4 RID: 61652 RVA: 0x003F54C8 File Offset: 0x003F36C8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
