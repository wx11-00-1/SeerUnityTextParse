using System;

namespace core.config.noHalfPets
{
	// Token: 0x02001F82 RID: 8066
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x0600F1F2 RID: 61938 RVA: 0x003F6B18 File Offset: 0x003F4D18
		public override string fileName
		{
			get
			{
				return "noHalfPets";
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x0600F1F3 RID: 61939 RVA: 0x003F6B1F File Offset: 0x003F4D1F
		// (set) Token: 0x0600F1F4 RID: 61940 RVA: 0x003F6B27 File Offset: 0x003F4D27
		public int[] pets { get; set; }

		// Token: 0x0600F1F5 RID: 61941 RVA: 0x003F6B30 File Offset: 0x003F4D30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.pets = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.pets[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F1F6 RID: 61942 RVA: 0x003F6B84 File Offset: 0x003F4D84
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400F1F8 RID: 61944
		private bool b;
	}
}
