using System;

namespace core.config.new_starmaplist
{
	// Token: 0x02002525 RID: 9509
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x060126C4 RID: 75460 RVA: 0x004B8E46 File Offset: 0x004B7046
		public override string fileName
		{
			get
			{
				return "new_starmaplist";
			}
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x060126C5 RID: 75461 RVA: 0x004B8E4D File Offset: 0x004B704D
		// (set) Token: 0x060126C6 RID: 75462 RVA: 0x004B8E55 File Offset: 0x004B7055
		public IRoot root { get; set; }

		// Token: 0x060126C7 RID: 75463 RVA: 0x004B8E5E File Offset: 0x004B705E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x060126C8 RID: 75464 RVA: 0x004B8E84 File Offset: 0x004B7084
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
