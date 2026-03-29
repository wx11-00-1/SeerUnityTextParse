using System;

namespace core.config.new_starmap
{
	// Token: 0x02002528 RID: 9512
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x060126EA RID: 75498 RVA: 0x004B90D2 File Offset: 0x004B72D2
		public override string fileName
		{
			get
			{
				return "new_starmap";
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x060126EB RID: 75499 RVA: 0x004B90D9 File Offset: 0x004B72D9
		// (set) Token: 0x060126EC RID: 75500 RVA: 0x004B90E1 File Offset: 0x004B72E1
		public IRoot root { get; set; }

		// Token: 0x060126ED RID: 75501 RVA: 0x004B90EA File Offset: 0x004B72EA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x060126EE RID: 75502 RVA: 0x004B9110 File Offset: 0x004B7310
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
