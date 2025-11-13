using System;

namespace core.config.pet_skin
{
	// Token: 0x02001F3B RID: 7995
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x0600EFC6 RID: 61382 RVA: 0x003F404E File Offset: 0x003F224E
		public override string fileName
		{
			get
			{
				return "pet_skin";
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x0600EFC7 RID: 61383 RVA: 0x003F4055 File Offset: 0x003F2255
		// (set) Token: 0x0600EFC8 RID: 61384 RVA: 0x003F405D File Offset: 0x003F225D
		public IPetSkins PetSkins { get; set; }

		// Token: 0x0600EFC9 RID: 61385 RVA: 0x003F4066 File Offset: 0x003F2266
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.PetSkins = new IPetSkins();
				this.PetSkins.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EFCA RID: 61386 RVA: 0x003F408C File Offset: 0x003F228C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
