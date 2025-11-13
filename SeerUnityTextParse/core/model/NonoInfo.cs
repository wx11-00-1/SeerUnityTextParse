using System;
using System.Collections.Generic;


namespace core.model
{
	// Token: 0x02001947 RID: 6471
	public class NonoInfo
	{
		// Token: 0x0600CBCB RID: 52171 RVA: 0x003B2918 File Offset: 0x003B0B18
		public NonoInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.userID = (int)data.ReadUnsignedInt();
				int num = (int)data.ReadUnsignedInt();
				if (num == 0)
				{
					return;
				}
				for (int i = 0; i < 32; i++)
				{
					this.flag.Add(KTool.getBit(num, i) != 0);
				}
				num = (int)data.ReadUnsignedInt();
				for (int j = 0; j < 32; j++)
				{
					this.state.Add(KTool.getBit(num, j) != 0);
				}
				this.nick = data.ReadUTFByte(16);
				this.superNono = (data.ReadUnsignedInt() > 0U);
				this.color = (int)data.ReadUnsignedInt();
				this.power = (int)(data.ReadUnsignedInt() / 1000U);
				this.mate = (int)(data.ReadUnsignedInt() / 1000U);
				this.iq = (int)data.ReadUnsignedInt();
				this.ai = (int)data.ReadUnsignedShort();
				this.birth = (int)(data.ReadUnsignedInt() * 1000U);
				this.chargeTime = (int)data.ReadUnsignedInt();
				for (int k = 0; k < 20; k++)
				{
					num = (int)data.ReadUnsignedByte();
					for (int l = 0; l < 8; l++)
					{
						this.func.Add(KTool.getBit(num, l) != 0);
					}
				}
				this.superEnergy = (int)data.ReadUnsignedInt();
				this.superLevel = (int)data.ReadUnsignedInt();
				this.superStage = (int)data.ReadUnsignedInt();
				//this.superStage = Mathf.Clamp(this.superStage, 1, 5);
				int value = (int)data.ReadUnsignedByte();
				this.isExtremeNono = (KTool.getBit(value, 1) != 0);
				if (data.Length < 4)
				{
					return;
				}
				this.changeToPet = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0600CBCC RID: 52172 RVA: 0x003B2AD9 File Offset: 0x003B0CD9
		public int getMateLevel()
		{
			if (this.mate <= 30)
			{
				return 1;
			}
			if (this.mate >= 31 && this.mate <= 69)
			{
				return 2;
			}
			return 3;
		}

		// Token: 0x0600CBCD RID: 52173 RVA: 0x003B2AFE File Offset: 0x003B0CFE
		public int getPowerLevel()
		{
			if (this.power <= 30)
			{
				return 1;
			}
			if (this.power >= 31 && this.power <= 69)
			{
				return 2;
			}
			return 3;
		}

		// Token: 0x0400E12D RID: 57645
		public int userID;

		// Token: 0x0400E12E RID: 57646
		public List<bool> flag = new List<bool>();

		// Token: 0x0400E12F RID: 57647
		public List<bool> state = new List<bool>();

		// Token: 0x0400E130 RID: 57648
		public string nick;

		// Token: 0x0400E131 RID: 57649
		public bool superNono;

		// Token: 0x0400E132 RID: 57650
		public int color;

		// Token: 0x0400E133 RID: 57651
		public int power;

		// Token: 0x0400E134 RID: 57652
		public int mate;

		// Token: 0x0400E135 RID: 57653
		public int iq;

		// Token: 0x0400E136 RID: 57654
		public int ai;

		// Token: 0x0400E137 RID: 57655
		public int birth;

		// Token: 0x0400E138 RID: 57656
		public int chargeTime;

		// Token: 0x0400E139 RID: 57657
		public List<bool> func = new List<bool>();

		// Token: 0x0400E13A RID: 57658
		public int superEnergy;

		// Token: 0x0400E13B RID: 57659
		public int superLevel;

		// Token: 0x0400E13C RID: 57660
		public int superStage;

		// Token: 0x0400E13D RID: 57661
		public int changeToPet;

		// Token: 0x0400E13E RID: 57662
		public bool isExtremeNono;

		// Token: 0x0400E13F RID: 57663
		public int flyStyle;

		// Token: 0x0400E140 RID: 57664
		//public Vector2 point;
	}
}
