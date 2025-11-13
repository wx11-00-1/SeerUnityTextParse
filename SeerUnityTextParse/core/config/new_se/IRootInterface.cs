using System;

namespace core.config.new_se
{
	// Token: 0x02001F91 RID: 8081
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x0600F292 RID: 62098 RVA: 0x003F76C4 File Offset: 0x003F58C4
		public override string fileName
		{
			get
			{
				return "new_se";
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x0600F293 RID: 62099 RVA: 0x003F76CB File Offset: 0x003F58CB
		// (set) Token: 0x0600F294 RID: 62100 RVA: 0x003F76D3 File Offset: 0x003F58D3
		public INewSe NewSe { get; set; }

		// Token: 0x0600F295 RID: 62101 RVA: 0x003F76DC File Offset: 0x003F58DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.NewSe = new INewSe();
				this.NewSe.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F296 RID: 62102 RVA: 0x003F7700 File Offset: 0x003F5900
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
