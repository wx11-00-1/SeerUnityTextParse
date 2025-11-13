using System;

namespace core.config.equip
{
	// Token: 0x02002043 RID: 8259
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0600FC39 RID: 64569 RVA: 0x00401AB7 File Offset: 0x003FFCB7
		public override string fileName
		{
			get
			{
				return "equip";
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x0600FC3A RID: 64570 RVA: 0x00401ABE File Offset: 0x003FFCBE
		// (set) Token: 0x0600FC3B RID: 64571 RVA: 0x00401AC6 File Offset: 0x003FFCC6
		public IEquips Equips { get; set; }

		// Token: 0x0600FC3C RID: 64572 RVA: 0x00401ACF File Offset: 0x003FFCCF
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Equips = new IEquips();
				this.Equips.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FC3D RID: 64573 RVA: 0x00401AF4 File Offset: 0x003FFCF4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
