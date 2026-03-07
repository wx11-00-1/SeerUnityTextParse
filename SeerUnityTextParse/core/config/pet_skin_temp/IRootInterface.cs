using System;

namespace core.config.pet_skin_temp
{
	// Token: 0x020021FF RID: 8703
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x06010B53 RID: 68435 RVA: 0x0045C462 File Offset: 0x0045A662
		public override string fileName
		{
			get
			{
				return "pet_skin_temp";
			}
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06010B54 RID: 68436 RVA: 0x0045C469 File Offset: 0x0045A669
		// (set) Token: 0x06010B55 RID: 68437 RVA: 0x0045C471 File Offset: 0x0045A671
		public IPetSkins PetSkins { get; set; }

		// Token: 0x06010B56 RID: 68438 RVA: 0x0045C47A File Offset: 0x0045A67A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.PetSkins = new IPetSkins();
				this.PetSkins.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06010B57 RID: 68439 RVA: 0x0045C4A0 File Offset: 0x0045A6A0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
