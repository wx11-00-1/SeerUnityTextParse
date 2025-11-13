using System;

namespace core.config.advancedPetPanelConfig
{
	// Token: 0x0200207C RID: 8316
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600FDDF RID: 64991 RVA: 0x004039B6 File Offset: 0x00401BB6
		public override string fileName
		{
			get
			{
				return "advancedPetPanelConfig";
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600FDE0 RID: 64992 RVA: 0x004039BD File Offset: 0x00401BBD
		// (set) Token: 0x0600FDE1 RID: 64993 RVA: 0x004039C5 File Offset: 0x00401BC5
		public IRoot root { get; set; }

		// Token: 0x0600FDE2 RID: 64994 RVA: 0x004039CE File Offset: 0x00401BCE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FDE3 RID: 64995 RVA: 0x004039F4 File Offset: 0x00401BF4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
