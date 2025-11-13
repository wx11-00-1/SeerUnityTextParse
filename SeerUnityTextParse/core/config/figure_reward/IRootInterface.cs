using System;

namespace core.config.figure_reward
{
	// Token: 0x0200203C RID: 8252
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x0600FC07 RID: 64519 RVA: 0x00401723 File Offset: 0x003FF923
		public override string fileName
		{
			get
			{
				return "figure_reward";
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x0600FC08 RID: 64520 RVA: 0x0040172A File Offset: 0x003FF92A
		// (set) Token: 0x0600FC09 RID: 64521 RVA: 0x00401732 File Offset: 0x003FF932
		public IRoot root { get; set; }

		// Token: 0x0600FC0A RID: 64522 RVA: 0x0040173B File Offset: 0x003FF93B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FC0B RID: 64523 RVA: 0x00401760 File Offset: 0x003FF960
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
