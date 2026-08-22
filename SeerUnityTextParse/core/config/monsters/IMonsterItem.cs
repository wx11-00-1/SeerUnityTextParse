using System;
using System.Text;

namespace core.config.monsters
{
	public class IMonsterItem
	{
		public string DefName { get; set; }

		public ILearnableMoves ExtraMoves { get; set; }

		public ILearnableMoves LearnableMoves { get; set; }

		public IMoveItem Move { get; set; }

		public ILearnableMoves ShowExtraMoves { get; set; }

		public ILearnableMoves SpExtraMoves { get; set; }

		public int Atk { get; set; }

		public int CharacterAttrParam { get; set; }

		public int Combo { get; set; }

		public int Def { get; set; }

		public int EvolvesTo { get; set; }

		public int EvolvFlag { get; set; }

		public int EvolvingLv { get; set; }

		public int FreeForbidden { get; set; }

		public int Gender { get; set; }

		public int HP { get; set; }

		public int ID { get; set; }

		public int isFlyPet { get; set; }

		public int isRidePet { get; set; }

		public int PetClass { get; set; }

		public int RealId { get; set; }

		public int SpAtk { get; set; }

		public int Spd { get; set; }

		public int SpDef { get; set; }

		public int Support { get; set; }

		public int Transform { get; set; }

		public int Type { get; set; }

		public int Vip { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Atk = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			CharacterAttrParam = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Combo = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Def = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num2 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num2 > 0 && num + num2 <= bytes.Length)
			{
				DefName = Encoding.UTF8.GetString(bytes, num, num2);
				num += num2;
			}
			else
			{
				DefName = string.Empty;
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			EvolvFlag = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			EvolvesTo = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			EvolvingLv = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num >= bytes.Length)
			{
				return;
			}
			if (bytes[num++] != 0)
			{
				ExtraMoves = new ILearnableMoves();
				ExtraMoves.Parse(bytes, ref num);
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			FreeForbidden = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Gender = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			HP = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			ID = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num >= bytes.Length)
			{
				return;
			}
			if (bytes[num++] != 0)
			{
				LearnableMoves = new ILearnableMoves();
				LearnableMoves.Parse(bytes, ref num);
			}
			if (num >= bytes.Length)
			{
				return;
			}
			if (bytes[num++] != 0)
			{
				Move = new IMoveItem();
				Move.Parse(bytes, ref num);
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			PetClass = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			RealId = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num >= bytes.Length)
			{
				return;
			}
			if (bytes[num++] != 0)
			{
				ShowExtraMoves = new ILearnableMoves();
				ShowExtraMoves.Parse(bytes, ref num);
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			SpAtk = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			SpDef = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num >= bytes.Length)
			{
				return;
			}
			if (bytes[num++] != 0)
			{
				SpExtraMoves = new ILearnableMoves();
				SpExtraMoves.Parse(bytes, ref num);
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Spd = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Support = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Transform = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Type = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Vip = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 <= bytes.Length)
			{
				isFlyPet = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					isRidePet = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
