using System;

namespace core.config.pass_task
{
	// Token: 0x02002506 RID: 9478
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x060125B0 RID: 75184 RVA: 0x004B75FA File Offset: 0x004B57FA
		public override string fileName
		{
			get
			{
				return "pass_task";
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x060125B1 RID: 75185 RVA: 0x004B7601 File Offset: 0x004B5801
		// (set) Token: 0x060125B2 RID: 75186 RVA: 0x004B7609 File Offset: 0x004B5809
		public IRoot root { get; set; }

		// Token: 0x060125B3 RID: 75187 RVA: 0x004B7612 File Offset: 0x004B5812
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x060125B4 RID: 75188 RVA: 0x004B7638 File Offset: 0x004B5838
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
