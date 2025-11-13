using System;

namespace core.config.itemFilter
{
	// Token: 0x02002026 RID: 8230
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600FB53 RID: 64339 RVA: 0x00400A13 File Offset: 0x003FEC13
		public override string fileName
		{
			get
			{
				return "itemFilter";
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600FB54 RID: 64340 RVA: 0x00400A1A File Offset: 0x003FEC1A
		// (set) Token: 0x0600FB55 RID: 64341 RVA: 0x00400A22 File Offset: 0x003FEC22
		public IRoot root { get; set; }

		// Token: 0x0600FB56 RID: 64342 RVA: 0x00400A2B File Offset: 0x003FEC2B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FB57 RID: 64343 RVA: 0x00400A50 File Offset: 0x003FEC50
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
