using System;

namespace core.config.journey_level
{
	// Token: 0x02002584 RID: 9604
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06012AD1 RID: 76497 RVA: 0x004BE256 File Offset: 0x004BC456
		public override string fileName
		{
			get
			{
				return "journey_level";
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x06012AD2 RID: 76498 RVA: 0x004BE25D File Offset: 0x004BC45D
		// (set) Token: 0x06012AD3 RID: 76499 RVA: 0x004BE265 File Offset: 0x004BC465
		public IRoot root { get; set; }

		// Token: 0x06012AD4 RID: 76500 RVA: 0x004BE26E File Offset: 0x004BC46E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06012AD5 RID: 76501 RVA: 0x004BE294 File Offset: 0x004BC494
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
