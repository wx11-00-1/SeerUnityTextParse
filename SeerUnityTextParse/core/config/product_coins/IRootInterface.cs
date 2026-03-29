using System;

namespace core.config.product_coins
{
	// Token: 0x020024C0 RID: 9408
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x06012366 RID: 74598 RVA: 0x004B456E File Offset: 0x004B276E
		public override string fileName
		{
			get
			{
				return "product_coins";
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x06012367 RID: 74599 RVA: 0x004B4575 File Offset: 0x004B2775
		// (set) Token: 0x06012368 RID: 74600 RVA: 0x004B457D File Offset: 0x004B277D
		public IRoot root { get; set; }

		// Token: 0x06012369 RID: 74601 RVA: 0x004B4586 File Offset: 0x004B2786
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0601236A RID: 74602 RVA: 0x004B45AC File Offset: 0x004B27AC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
