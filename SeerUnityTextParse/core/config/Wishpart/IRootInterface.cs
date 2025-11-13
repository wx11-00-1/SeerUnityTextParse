using System;

namespace core.config.Wishpart
{
	// Token: 0x02001EEE RID: 7918
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x0600ED04 RID: 60676 RVA: 0x003F0C76 File Offset: 0x003EEE76
		public override string fileName
		{
			get
			{
				return "Wishpart";
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x0600ED05 RID: 60677 RVA: 0x003F0C7D File Offset: 0x003EEE7D
		// (set) Token: 0x0600ED06 RID: 60678 RVA: 0x003F0C85 File Offset: 0x003EEE85
		public IWishparts Wishparts { get; set; }

		// Token: 0x0600ED07 RID: 60679 RVA: 0x003F0C8E File Offset: 0x003EEE8E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Wishparts = new IWishparts();
				this.Wishparts.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600ED08 RID: 60680 RVA: 0x003F0CB4 File Offset: 0x003EEEB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
