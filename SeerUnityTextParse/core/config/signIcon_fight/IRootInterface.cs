using System;

namespace core.config.signIcon_fight
{
	// Token: 0x02001F25 RID: 7973
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x0600EEF8 RID: 61176 RVA: 0x003F30F6 File Offset: 0x003F12F6
		public override string fileName
		{
			get
			{
				return "signIcon_fight";
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x0600EEF9 RID: 61177 RVA: 0x003F30FD File Offset: 0x003F12FD
		// (set) Token: 0x0600EEFA RID: 61178 RVA: 0x003F3105 File Offset: 0x003F1305
		public IConfig config { get; set; }

		// Token: 0x0600EEFB RID: 61179 RVA: 0x003F310E File Offset: 0x003F130E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.config = new IConfig();
				this.config.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EEFC RID: 61180 RVA: 0x003F3134 File Offset: 0x003F1334
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
