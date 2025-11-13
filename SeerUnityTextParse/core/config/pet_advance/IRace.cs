using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F48 RID: 8008
	public class IRace
	{
		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x0600F03A RID: 61498 RVA: 0x003F48B5 File Offset: 0x003F2AB5
		// (set) Token: 0x0600F03B RID: 61499 RVA: 0x003F48BD File Offset: 0x003F2ABD
		public int[] NewRace { get; set; }

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x0600F03C RID: 61500 RVA: 0x003F48C6 File Offset: 0x003F2AC6
		// (set) Token: 0x0600F03D RID: 61501 RVA: 0x003F48CE File Offset: 0x003F2ACE
		public int[] OldRace { get; set; }

		// Token: 0x0600F03E RID: 61502 RVA: 0x003F48D8 File Offset: 0x003F2AD8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.NewRace = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.NewRace[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.OldRace = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.OldRace[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
