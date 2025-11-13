using System;

namespace core.config.Wishskin
{
	// Token: 0x02001EE8 RID: 7912
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x0600ECDE RID: 60638 RVA: 0x003F09FA File Offset: 0x003EEBFA
		public override string fileName
		{
			get
			{
				return "Wishskin";
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x0600ECDF RID: 60639 RVA: 0x003F0A01 File Offset: 0x003EEC01
		// (set) Token: 0x0600ECE0 RID: 60640 RVA: 0x003F0A09 File Offset: 0x003EEC09
		public IWishskins Wishskins { get; set; }

		// Token: 0x0600ECE1 RID: 60641 RVA: 0x003F0A12 File Offset: 0x003EEC12
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Wishskins = new IWishskins();
				this.Wishskins.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600ECE2 RID: 60642 RVA: 0x003F0A38 File Offset: 0x003EEC38
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
