using System;

namespace core.config.Attirerecycle
{
	// Token: 0x02002071 RID: 8305
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600FD99 RID: 64921 RVA: 0x004034E2 File Offset: 0x004016E2
		public override string fileName
		{
			get
			{
				return "Attirerecycle";
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x0600FD9A RID: 64922 RVA: 0x004034E9 File Offset: 0x004016E9
		// (set) Token: 0x0600FD9B RID: 64923 RVA: 0x004034F1 File Offset: 0x004016F1
		public IAttirerecycles Attirerecycles { get; set; }

		// Token: 0x0600FD9C RID: 64924 RVA: 0x004034FA File Offset: 0x004016FA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Attirerecycles = new IAttirerecycles();
				this.Attirerecycles.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FD9D RID: 64925 RVA: 0x00403520 File Offset: 0x00401720
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
