using System;

namespace core.config
{
	// Token: 0x02001D82 RID: 7554
	public class ILlsCookingLvlInfo : IConfigItem
	{
		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x0600DD6E RID: 56686 RVA: 0x003D5830 File Offset: 0x003D3A30
		// (set) Token: 0x0600DD6F RID: 56687 RVA: 0x003D5838 File Offset: 0x003D3A38
		public string task { get; set; }

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600DD70 RID: 56688 RVA: 0x003D5841 File Offset: 0x003D3A41
		// (set) Token: 0x0600DD71 RID: 56689 RVA: 0x003D5849 File Offset: 0x003D3A49
		public int[] target { get; set; }

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x0600DD72 RID: 56690 RVA: 0x003D5852 File Offset: 0x003D3A52
		// (set) Token: 0x0600DD73 RID: 56691 RVA: 0x003D585A File Offset: 0x003D3A5A
		public int afterchat { get; set; }

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x0600DD74 RID: 56692 RVA: 0x003D5863 File Offset: 0x003D3A63
		// (set) Token: 0x0600DD75 RID: 56693 RVA: 0x003D586B File Offset: 0x003D3A6B
		public int afterguide { get; set; }

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x0600DD76 RID: 56694 RVA: 0x003D5874 File Offset: 0x003D3A74
		// (set) Token: 0x0600DD77 RID: 56695 RVA: 0x003D587C File Offset: 0x003D3A7C
		public float cooldown { get; set; }

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x0600DD78 RID: 56696 RVA: 0x003D5885 File Offset: 0x003D3A85
		// (set) Token: 0x0600DD79 RID: 56697 RVA: 0x003D588D File Offset: 0x003D3A8D
		public int countdown { get; set; }

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x0600DD7A RID: 56698 RVA: 0x003D5896 File Offset: 0x003D3A96
		// (set) Token: 0x0600DD7B RID: 56699 RVA: 0x003D589E File Offset: 0x003D3A9E
		public int groupid { get; set; }

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x0600DD7C RID: 56700 RVA: 0x003D58A7 File Offset: 0x003D3AA7
		// (set) Token: 0x0600DD7D RID: 56701 RVA: 0x003D58AF File Offset: 0x003D3AAF
		public int id { get; set; }

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x0600DD7E RID: 56702 RVA: 0x003D58B8 File Offset: 0x003D3AB8
		// (set) Token: 0x0600DD7F RID: 56703 RVA: 0x003D58C0 File Offset: 0x003D3AC0
		public int lvlunlock { get; set; }

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x0600DD80 RID: 56704 RVA: 0x003D58C9 File Offset: 0x003D3AC9
		// (set) Token: 0x0600DD81 RID: 56705 RVA: 0x003D58D1 File Offset: 0x003D3AD1
		public int prechat { get; set; }

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x0600DD82 RID: 56706 RVA: 0x003D58DA File Offset: 0x003D3ADA
		// (set) Token: 0x0600DD83 RID: 56707 RVA: 0x003D58E2 File Offset: 0x003D3AE2
		public int preguide { get; set; }

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600DD84 RID: 56708 RVA: 0x003D58EB File Offset: 0x003D3AEB
		// (set) Token: 0x0600DD85 RID: 56709 RVA: 0x003D58F3 File Offset: 0x003D3AF3
		public int rule { get; set; }

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x0600DD86 RID: 56710 RVA: 0x003D58FC File Offset: 0x003D3AFC
		// (set) Token: 0x0600DD87 RID: 56711 RVA: 0x003D5904 File Offset: 0x003D3B04
		public int waiting { get; set; }

		// Token: 0x0600DD88 RID: 56712 RVA: 0x003D5910 File Offset: 0x003D3B10
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.afterchat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.afterguide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cooldown = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.countdown = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.groupid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lvlunlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.prechat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.preguide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rule = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.target = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.target[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.task = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.waiting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
