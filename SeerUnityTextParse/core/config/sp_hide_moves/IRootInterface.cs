using System;

namespace core.config.sp_hide_moves
{
	// Token: 0x02001F1A RID: 7962
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x0600EE82 RID: 61058 RVA: 0x003F2817 File Offset: 0x003F0A17
		public override string fileName
		{
			get
			{
				return "sp_hide_moves";
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x0600EE83 RID: 61059 RVA: 0x003F281E File Offset: 0x003F0A1E
		// (set) Token: 0x0600EE84 RID: 61060 RVA: 0x003F2826 File Offset: 0x003F0A26
		public IConfig config { get; set; }

		// Token: 0x0600EE85 RID: 61061 RVA: 0x003F282F File Offset: 0x003F0A2F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.config = new IConfig();
				this.config.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EE86 RID: 61062 RVA: 0x003F2854 File Offset: 0x003F0A54
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
