using System;

namespace core.config.ResistanceSpecifiedItem
{
	// Token: 0x02001F2F RID: 7983
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x0600EF76 RID: 61302 RVA: 0x003F39EE File Offset: 0x003F1BEE
		public override string fileName
		{
			get
			{
				return "ResistanceSpecifiedItem";
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x0600EF77 RID: 61303 RVA: 0x003F39F5 File Offset: 0x003F1BF5
		// (set) Token: 0x0600EF78 RID: 61304 RVA: 0x003F39FD File Offset: 0x003F1BFD
		public IRoot root { get; set; }

		// Token: 0x0600EF79 RID: 61305 RVA: 0x003F3A06 File Offset: 0x003F1C06
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EF7A RID: 61306 RVA: 0x003F3A2C File Offset: 0x003F1C2C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
