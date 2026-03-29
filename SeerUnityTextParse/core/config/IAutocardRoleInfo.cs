using System;

namespace core.config
{
	// Token: 0x0200213D RID: 8509
	public class IAutocardRoleInfo : IConfigItem
	{
		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x0600FCCE RID: 64718 RVA: 0x0047D514 File Offset: 0x0047B714
		// (set) Token: 0x0600FCCF RID: 64719 RVA: 0x0047D51C File Offset: 0x0047B71C
		public string BuffId { get; set; }

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x0600FCD0 RID: 64720 RVA: 0x0047D525 File Offset: 0x0047B725
		// (set) Token: 0x0600FCD1 RID: 64721 RVA: 0x0047D52D File Offset: 0x0047B72D
		public string BuffParam { get; set; }

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600FCD2 RID: 64722 RVA: 0x0047D536 File Offset: 0x0047B736
		// (set) Token: 0x0600FCD3 RID: 64723 RVA: 0x0047D53E File Offset: 0x0047B73E
		public string desc { get; set; }

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x0600FCD4 RID: 64724 RVA: 0x0047D547 File Offset: 0x0047B747
		// (set) Token: 0x0600FCD5 RID: 64725 RVA: 0x0047D54F File Offset: 0x0047B74F
		public string name { get; set; }

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x0600FCD6 RID: 64726 RVA: 0x0047D558 File Offset: 0x0047B758
		// (set) Token: 0x0600FCD7 RID: 64727 RVA: 0x0047D560 File Offset: 0x0047B760
		public string skillName { get; set; }

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600FCD8 RID: 64728 RVA: 0x0047D569 File Offset: 0x0047B769
		// (set) Token: 0x0600FCD9 RID: 64729 RVA: 0x0047D571 File Offset: 0x0047B771
		public string skillTxt { get; set; }

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x0600FCDA RID: 64730 RVA: 0x0047D57A File Offset: 0x0047B77A
		// (set) Token: 0x0600FCDB RID: 64731 RVA: 0x0047D582 File Offset: 0x0047B782
		public string skillUpgrade { get; set; }

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600FCDC RID: 64732 RVA: 0x0047D58B File Offset: 0x0047B78B
		// (set) Token: 0x0600FCDD RID: 64733 RVA: 0x0047D593 File Offset: 0x0047B793
		public int CountNum { get; set; }

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x0600FCDE RID: 64734 RVA: 0x0047D59C File Offset: 0x0047B79C
		// (set) Token: 0x0600FCDF RID: 64735 RVA: 0x0047D5A4 File Offset: 0x0047B7A4
		public int Display { get; set; }

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600FCE0 RID: 64736 RVA: 0x0047D5AD File Offset: 0x0047B7AD
		// (set) Token: 0x0600FCE1 RID: 64737 RVA: 0x0047D5B5 File Offset: 0x0047B7B5
		public int health { get; set; }

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x0600FCE2 RID: 64738 RVA: 0x0047D5BE File Offset: 0x0047B7BE
		// (set) Token: 0x0600FCE3 RID: 64739 RVA: 0x0047D5C6 File Offset: 0x0047B7C6
		public int id { get; set; }

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x0600FCE4 RID: 64740 RVA: 0x0047D5CF File Offset: 0x0047B7CF
		// (set) Token: 0x0600FCE5 RID: 64741 RVA: 0x0047D5D7 File Offset: 0x0047B7D7
		public int picID { get; set; }

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x0600FCE6 RID: 64742 RVA: 0x0047D5E0 File Offset: 0x0047B7E0
		// (set) Token: 0x0600FCE7 RID: 64743 RVA: 0x0047D5E8 File Offset: 0x0047B7E8
		public int skillCostNum { get; set; }

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600FCE8 RID: 64744 RVA: 0x0047D5F1 File Offset: 0x0047B7F1
		// (set) Token: 0x0600FCE9 RID: 64745 RVA: 0x0047D5F9 File Offset: 0x0047B7F9
		public int skillGameLimit { get; set; }

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600FCEA RID: 64746 RVA: 0x0047D602 File Offset: 0x0047B802
		// (set) Token: 0x0600FCEB RID: 64747 RVA: 0x0047D60A File Offset: 0x0047B80A
		public int skillID { get; set; }

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x0600FCEC RID: 64748 RVA: 0x0047D613 File Offset: 0x0047B813
		// (set) Token: 0x0600FCED RID: 64749 RVA: 0x0047D61B File Offset: 0x0047B81B
		public int skillRoundLimit { get; set; }

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x0600FCEE RID: 64750 RVA: 0x0047D624 File Offset: 0x0047B824
		// (set) Token: 0x0600FCEF RID: 64751 RVA: 0x0047D62C File Offset: 0x0047B82C
		public int skillType { get; set; }

		// Token: 0x0600FCF0 RID: 64752 RVA: 0x0047D638 File Offset: 0x0047B838
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BuffId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BuffParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.CountNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Display = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.health = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.picID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skillCostNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skillGameLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skillID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skillName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skillRoundLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skillTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skillType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skillUpgrade = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
