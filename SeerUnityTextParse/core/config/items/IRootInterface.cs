using System;

namespace core.config.items
{
	// Token: 0x02002020 RID: 8224
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x0600FB07 RID: 64263 RVA: 0x00400452 File Offset: 0x003FE652
		public override string fileName
		{
			get
			{
				return "items";
			}
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x0600FB08 RID: 64264 RVA: 0x00400459 File Offset: 0x003FE659
		// (set) Token: 0x0600FB09 RID: 64265 RVA: 0x00400461 File Offset: 0x003FE661
		public IItems Items { get; set; }

		// Token: 0x0600FB0A RID: 64266 RVA: 0x0040046A File Offset: 0x003FE66A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.Items = new IItems();
				this.Items.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FB0B RID: 64267 RVA: 0x0040049C File Offset: 0x003FE69C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400F566 RID: 62822
		private bool b;
	}
}
