using System;

namespace core.config.Wishpet
{
	// Token: 0x02001EEB RID: 7915
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x0600ECF0 RID: 60656 RVA: 0x003F0B2A File Offset: 0x003EED2A
		public override string fileName
		{
			get
			{
				return "Wishpet";
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x0600ECF1 RID: 60657 RVA: 0x003F0B31 File Offset: 0x003EED31
		// (set) Token: 0x0600ECF2 RID: 60658 RVA: 0x003F0B39 File Offset: 0x003EED39
		public IWishpets Wishpets { get; set; }

		// Token: 0x0600ECF3 RID: 60659 RVA: 0x003F0B42 File Offset: 0x003EED42
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Wishpets = new IWishpets();
				this.Wishpets.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600ECF4 RID: 60660 RVA: 0x003F0B68 File Offset: 0x003EED68
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
