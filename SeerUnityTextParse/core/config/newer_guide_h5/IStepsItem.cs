using System;

namespace core.config.newer_guide_h5
{
	// Token: 0x02001F99 RID: 8089
	public class IStepsItem
	{
		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x0600F2D8 RID: 62168 RVA: 0x003F7BDC File Offset: 0x003F5DDC
		// (set) Token: 0x0600F2D9 RID: 62169 RVA: 0x003F7BE4 File Offset: 0x003F5DE4
		public string dependStepParam { get; set; }

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x0600F2DA RID: 62170 RVA: 0x003F7BED File Offset: 0x003F5DED
		// (set) Token: 0x0600F2DB RID: 62171 RVA: 0x003F7BF5 File Offset: 0x003F5DF5
		public string param { get; set; }

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x0600F2DC RID: 62172 RVA: 0x003F7BFE File Offset: 0x003F5DFE
		// (set) Token: 0x0600F2DD RID: 62173 RVA: 0x003F7C06 File Offset: 0x003F5E06
		public ISubstepItem[] substep { get; set; }

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x0600F2DE RID: 62174 RVA: 0x003F7C0F File Offset: 0x003F5E0F
		// (set) Token: 0x0600F2DF RID: 62175 RVA: 0x003F7C17 File Offset: 0x003F5E17
		public int conditionid { get; set; }

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x0600F2E0 RID: 62176 RVA: 0x003F7C20 File Offset: 0x003F5E20
		// (set) Token: 0x0600F2E1 RID: 62177 RVA: 0x003F7C28 File Offset: 0x003F5E28
		public int dependStep { get; set; }

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x0600F2E2 RID: 62178 RVA: 0x003F7C31 File Offset: 0x003F5E31
		// (set) Token: 0x0600F2E3 RID: 62179 RVA: 0x003F7C39 File Offset: 0x003F5E39
		public int step { get; set; }

		// Token: 0x0600F2E4 RID: 62180 RVA: 0x003F7C44 File Offset: 0x003F5E44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.conditionid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dependStep = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dependStepParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.step = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.substep = new ISubstepItem[num];
				for (int i = 0; i < num; i++)
				{
					this.substep[i] = new ISubstepItem();
					this.substep[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
