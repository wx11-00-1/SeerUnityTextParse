using System;

namespace core.config
{
	// Token: 0x02001CCA RID: 7370
	public class IBlazeMonopolyGameInfo : IConfigItem
	{
		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x0600D5E8 RID: 54760 RVA: 0x003CC408 File Offset: 0x003CA608
		// (set) Token: 0x0600D5E9 RID: 54761 RVA: 0x003CC410 File Offset: 0x003CA610
		public string bosspic { get; set; }

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600D5EA RID: 54762 RVA: 0x003CC419 File Offset: 0x003CA619
		// (set) Token: 0x0600D5EB RID: 54763 RVA: 0x003CC421 File Offset: 0x003CA621
		public int[] bossbehavior { get; set; }

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600D5EC RID: 54764 RVA: 0x003CC42A File Offset: 0x003CA62A
		// (set) Token: 0x0600D5ED RID: 54765 RVA: 0x003CC432 File Offset: 0x003CA632
		public int[] reward { get; set; }

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x0600D5EE RID: 54766 RVA: 0x003CC43B File Offset: 0x003CA63B
		// (set) Token: 0x0600D5EF RID: 54767 RVA: 0x003CC443 File Offset: 0x003CA643
		public int bosseffects { get; set; }

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x0600D5F0 RID: 54768 RVA: 0x003CC44C File Offset: 0x003CA64C
		// (set) Token: 0x0600D5F1 RID: 54769 RVA: 0x003CC454 File Offset: 0x003CA654
		public int bosshp { get; set; }

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x0600D5F2 RID: 54770 RVA: 0x003CC45D File Offset: 0x003CA65D
		// (set) Token: 0x0600D5F3 RID: 54771 RVA: 0x003CC465 File Offset: 0x003CA665
		public float bosspicscale { get; set; }

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600D5F4 RID: 54772 RVA: 0x003CC46E File Offset: 0x003CA66E
		// (set) Token: 0x0600D5F5 RID: 54773 RVA: 0x003CC476 File Offset: 0x003CA676
		public int id { get; set; }

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x0600D5F6 RID: 54774 RVA: 0x003CC47F File Offset: 0x003CA67F
		// (set) Token: 0x0600D5F7 RID: 54775 RVA: 0x003CC487 File Offset: 0x003CA687
		public int opentime { get; set; }

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600D5F8 RID: 54776 RVA: 0x003CC490 File Offset: 0x003CA690
		// (set) Token: 0x0600D5F9 RID: 54777 RVA: 0x003CC498 File Offset: 0x003CA698
		public int playerattack { get; set; }

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600D5FA RID: 54778 RVA: 0x003CC4A1 File Offset: 0x003CA6A1
		// (set) Token: 0x0600D5FB RID: 54779 RVA: 0x003CC4A9 File Offset: 0x003CA6A9
		public int playerhp { get; set; }

		// Token: 0x0600D5FC RID: 54780 RVA: 0x003CC4B4 File Offset: 0x003CA6B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.bossbehavior = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.bossbehavior[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.bosseffects = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bosshp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bosspic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bosspicscale = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.playerattack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.playerhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.reward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
