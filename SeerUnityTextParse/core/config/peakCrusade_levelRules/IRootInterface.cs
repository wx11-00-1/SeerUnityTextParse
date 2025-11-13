using System;

namespace core.config.peakCrusade_levelRules
{
	// Token: 0x02001F78 RID: 8056
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x0600F1BC RID: 61884 RVA: 0x003F6732 File Offset: 0x003F4932
		public override string fileName
		{
			get
			{
				return "peakCrusade_levelRules";
			}
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600F1BD RID: 61885 RVA: 0x003F6739 File Offset: 0x003F4939
		// (set) Token: 0x0600F1BE RID: 61886 RVA: 0x003F6741 File Offset: 0x003F4941
		public IRoot root { get; set; }

		// Token: 0x0600F1BF RID: 61887 RVA: 0x003F674A File Offset: 0x003F494A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F1C0 RID: 61888 RVA: 0x003F677C File Offset: 0x003F497C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400F1E9 RID: 61929
		private bool b;
	}
}
