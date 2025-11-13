using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001950 RID: 6480
	public class PetEffectInfo
	{
		// Token: 0x0600CBE9 RID: 52201 RVA: 0x003B3178 File Offset: 0x003B1378
		private int checkAdd(ByteArray b)
		{
			byte b2 = b.ReadUnsignedByte();
			if (b2 != 0)
			{
				return (int)b2 * 256;
			}
			return 0;
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x003B3198 File Offset: 0x003B1398
		public PetEffectInfo(ByteArray data)
		{
			if (data == null)
			{
				return;
			}
			this.args_all.Clear();
			this.itemId = (int)data.ReadUnsignedInt();
			this.status = (int)data.ReadUnsignedByte();
			this.leftCount = (int)data.ReadUnsignedByte();
			this.effectID = (int)data.ReadUnsignedShort();
			this.argsCache = data.ReadBytes(16);
			data.position -= 16;
			int num = (int)data.ReadUnsignedByte();
			num += this.checkAdd(data);
			int num2 = (int)data.ReadUnsignedByte();
			num2 += this.checkAdd(data);
			int num3 = (int)data.ReadUnsignedByte();
			num3 += this.checkAdd(data);
			int num4 = (int)data.ReadUnsignedByte();
			num4 += this.checkAdd(data);
			int num5 = (int)data.ReadUnsignedByte();
			num5 += this.checkAdd(data);
			int num6 = (int)data.ReadUnsignedByte();
			num6 += this.checkAdd(data);
			int num7 = (int)data.ReadUnsignedByte();
			num7 += this.checkAdd(data);
			int num8 = (int)data.ReadUnsignedByte();
			num8 += this.checkAdd(data);
			List<int> list = new List<int>
			{
				num2,
				num3,
				num4,
				num5,
				num6,
				num7,
				num8
			};
			if (this.status == 3)
			{
				this.args_all[num] = num2;
			}
			this.args_all[num3] = num4;
			this.args_all[num5] = num6;
			this.args_all[num7] = num8;
			if (num2 == 0 && num3 == 0 && num4 == 0 && num5 == 0 && num6 == 0)
			{
				this.args = num.ToString() + " " + 0.ToString();
			}
			else
			{
				this.args = num.ToString();
				for (int i = 6; i >= 0; i--)
				{
					if (list[i] > 0)
					{
						for (int j = 0; j <= i; j++)
						{
							this.args = this.args + " " + list[j].ToString();
						}
						break;
					}
				}
			}
			this.args_6 = string.Concat(new string[]
			{
				num2.ToString(),
				" ",
				num3.ToString(),
				" ",
				num4.ToString(),
				" ",
				num5.ToString(),
				" ",
				num6.ToString(),
				" ",
				num.ToString()
			});
			if (this.effectID == 171)
			{
				this.addArray.Add(num);
				this.addArray.Add(num2);
				this.addArray.Add(num3);
				this.addArray.Add(num4);
				this.addArray.Add(num5);
				this.addArray.Add(num6);
				int num9 = num7;
				this.levelArray.Add(num9 % 16);
				num9 -= num9 % 16;
				num9 /= 16;
				this.levelArray.Add(num9 % 16);
				num9 -= num9 % 16;
				num9 /= 16;
				this.levelArray.Add(num9 % 16);
				num9 = num8;
				this.levelArray.Add(num9 % 16);
				num9 -= num9 % 16;
				num9 /= 16;
				this.levelArray.Add(num9 % 16);
				num9 -= num9 % 16;
				num9 /= 16;
				this.levelArray.Add(num9 % 16);
			}
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x003B3554 File Offset: 0x003B1754
		public int[] getTeamTechAdd(int type)
		{
			if (this.effectID == 171)
			{
				int num = this.addArray[type];
				int num2 = this.levelArray[type];
				return new int[]
				{
					num,
					num2
				};
			}
			return new int[2];
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x003B359D File Offset: 0x003B179D
		public List<int> getTeamAddArray()
		{
			return this.addArray;
		}

		// Token: 0x0600CBED RID: 52205 RVA: 0x003B35A8 File Offset: 0x003B17A8
		internal void GetSaveByteArray(ByteArray data)
		{
			data.WriteSignedInt(this.itemId);
			data.WriteUnsignedByte((byte)this.status);
			data.WriteUnsignedByte((byte)this.leftCount);
			data.WriteUnsignedShort((ushort)this.effectID);
			data.WriteBytes(this.argsCache, 0);
		}

		// Token: 0x0400E17C RID: 57724
		public int itemId;

		// Token: 0x0400E17D RID: 57725
		public int status;

		// Token: 0x0400E17E RID: 57726
		public int leftCount;

		// Token: 0x0400E17F RID: 57727
		public int effectID;

		// Token: 0x0400E180 RID: 57728
		private byte[] argsCache;

		// Token: 0x0400E181 RID: 57729
		public string args;

		// Token: 0x0400E182 RID: 57730
		public Dictionary<int, int> args_all = new Dictionary<int, int>();

		// Token: 0x0400E183 RID: 57731
		public string args_6;

		// Token: 0x0400E184 RID: 57732
		private List<int> addArray = new List<int>();

		// Token: 0x0400E185 RID: 57733
		private List<int> levelArray = new List<int>();
	}
}
