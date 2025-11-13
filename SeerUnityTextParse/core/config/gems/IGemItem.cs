using System;

namespace core.config.gems
{
	// Token: 0x0200202C RID: 8236
	public class IGemItem
	{
		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x0600FB77 RID: 64375 RVA: 0x00400CC2 File Offset: 0x003FEEC2
		// (set) Token: 0x0600FB78 RID: 64376 RVA: 0x00400CCA File Offset: 0x003FEECA
		public string Des { get; set; }

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600FB79 RID: 64377 RVA: 0x00400CD3 File Offset: 0x003FEED3
		// (set) Token: 0x0600FB7A RID: 64378 RVA: 0x00400CDB File Offset: 0x003FEEDB
		public string Name { get; set; }

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x0600FB7B RID: 64379 RVA: 0x00400CE4 File Offset: 0x003FEEE4
		// (set) Token: 0x0600FB7C RID: 64380 RVA: 0x00400CEC File Offset: 0x003FEEEC
		public ISkillEffectsItem[] SkillEffects { get; set; }

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x0600FB7D RID: 64381 RVA: 0x00400CF5 File Offset: 0x003FEEF5
		// (set) Token: 0x0600FB7E RID: 64382 RVA: 0x00400CFD File Offset: 0x003FEEFD
		public int Category { get; set; }

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x0600FB7F RID: 64383 RVA: 0x00400D06 File Offset: 0x003FEF06
		// (set) Token: 0x0600FB80 RID: 64384 RVA: 0x00400D0E File Offset: 0x003FEF0E
		public int DecomposeProb { get; set; }

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x0600FB81 RID: 64385 RVA: 0x00400D17 File Offset: 0x003FEF17
		// (set) Token: 0x0600FB82 RID: 64386 RVA: 0x00400D1F File Offset: 0x003FEF1F
		public int EquitLv1Cnt1 { get; set; }

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x0600FB83 RID: 64387 RVA: 0x00400D28 File Offset: 0x003FEF28
		// (set) Token: 0x0600FB84 RID: 64388 RVA: 0x00400D30 File Offset: 0x003FEF30
		public int ID { get; set; }

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x0600FB85 RID: 64389 RVA: 0x00400D39 File Offset: 0x003FEF39
		// (set) Token: 0x0600FB86 RID: 64390 RVA: 0x00400D41 File Offset: 0x003FEF41
		public int Lv { get; set; }

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x0600FB87 RID: 64391 RVA: 0x00400D4A File Offset: 0x003FEF4A
		// (set) Token: 0x0600FB88 RID: 64392 RVA: 0x00400D52 File Offset: 0x003FEF52
		public int UpgradeGemId { get; set; }

		// Token: 0x0600FB89 RID: 64393 RVA: 0x00400D5C File Offset: 0x003FEF5C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Category = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.DecomposeProb = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.EquitLv1Cnt1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SkillEffects = new ISkillEffectsItem[num];
				for (int i = 0; i < num; i++)
				{
					this.SkillEffects[i] = new ISkillEffectsItem();
					this.SkillEffects[i].Parse(bytes, ref byteIndex);
				}
			}
			this.UpgradeGemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
