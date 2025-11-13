using System;

namespace core.config.hide_moves
{
	// Token: 0x0200202A RID: 8234
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600FB6B RID: 64363 RVA: 0x00400BE6 File Offset: 0x003FEDE6
		public override string fileName
		{
			get
			{
				return "hide_moves";
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600FB6C RID: 64364 RVA: 0x00400BED File Offset: 0x003FEDED
		// (set) Token: 0x0600FB6D RID: 64365 RVA: 0x00400BF5 File Offset: 0x003FEDF5
		public IRoot root { get; set; }

		// Token: 0x0600FB6E RID: 64366 RVA: 0x00400BFE File Offset: 0x003FEDFE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FB6F RID: 64367 RVA: 0x00400C24 File Offset: 0x003FEE24
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
