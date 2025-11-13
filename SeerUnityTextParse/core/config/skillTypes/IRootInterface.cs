using System;

namespace core.config.skillTypes
{
	// Token: 0x02001F22 RID: 7970
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x0600EED0 RID: 61136 RVA: 0x003F2D76 File Offset: 0x003F0F76
		public override string fileName
		{
			get
			{
				return "skillTypes";
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x0600EED1 RID: 61137 RVA: 0x003F2D7D File Offset: 0x003F0F7D
		// (set) Token: 0x0600EED2 RID: 61138 RVA: 0x003F2D85 File Offset: 0x003F0F85
		public IRoot root { get; set; }

		// Token: 0x0600EED3 RID: 61139 RVA: 0x003F2D8E File Offset: 0x003F0F8E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EED4 RID: 61140 RVA: 0x003F2DB4 File Offset: 0x003F0FB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
