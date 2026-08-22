namespace core.config.itemsOptimize
{
	public class itemsOptimizeCatItem13Def : ItemData
	{
		public int catID;

		public int ID;

		public string Name;

		public int Max;

		public int Bean;

		public int Hide;

		public int isSpecial;

		public int purpose;

		public int Sort;

		public float speed;

		public string type;

		public int UseMax;

		public int VipOnly;

		public int wd;

		public override int GetID()
		{
			return ID;
		}

		public override string GetName()
		{
			return Name;
		}

		public override int GetMax()
		{
			return Max;
		}

		public override int GetCatID()
		{
			return catID;
		}

		public override int GetBean()
		{
			return Bean;
		}

		public override bool IsHide()
		{
			return Hide != 0;
		}

		public override bool IsSpecial()
		{
			return isSpecial != 0;
		}

		public override int Getpurpose()
		{
			return purpose;
		}

		public override int GetSort()
		{
			return Sort;
		}

		public override float Getspeed()
		{
			return speed;
		}

		public override string Gettype()
		{
			return type;
		}

		public override int GetUseMax()
		{
			return UseMax;
		}

		public override bool IsSuper()
		{
			return VipOnly != 0;
		}

		public override int Getwd()
		{
			return wd;
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isSpecial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			speed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
