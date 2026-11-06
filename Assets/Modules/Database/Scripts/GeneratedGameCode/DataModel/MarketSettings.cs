//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System.Linq;
using GameDatabase.Enums;
using GameDatabase.Serializable;
using GameDatabase.Model;
using CodeWriter.ExpressionParser;

namespace GameDatabase.DataModel
{
	public partial class MarketSettings : IDefaultVariablesResolver
	{
		partial void OnDataDeserialized(MarketSettingsSerializable serializable, Database.Loader loader);

		public static MarketSettings Create(MarketSettingsSerializable serializable, Database.Loader loader)
		{
			return serializable == null ? DefaultValue : new MarketSettings(serializable, loader);
		}

		private MarketSettings(MarketSettingsSerializable serializable, Database.Loader loader)
		{
			var variableResolver = new VariableResolver(this);
			FuelRenewal = Utilites.MathEx.Clamp(serializable.FuelRenewal, -1f, 1000000f);
			TechRenewal = Utilites.MathEx.Clamp(serializable.TechRenewal, -1f, 1000000f);
			StarsRenewal = Utilites.MathEx.Clamp(serializable.StarsRenewal, -1f, 1000000f);
			ShipRenewal = Utilites.MathEx.Clamp(serializable.ShipRenewal, -1f, 1000000f);
			CommonComponentRenewal = Utilites.MathEx.Clamp(serializable.CommonComponentRenewal, -1f, 1000000f);
			RareComponentRenewal = Utilites.MathEx.Clamp(serializable.RareComponentRenewal, -1f, 1000000f);
			SatelliteRenewal = Utilites.MathEx.Clamp(serializable.SatelliteRenewal, -1f, 1000000f);
			_rareComponentLevel = new Expressions.IntToInt(serializable.RareComponentLevel, 0, 1000, variableResolver) { ParamName1 = "level" };
			RareComponentLevel = _rareComponentLevel.Evaluate;
			RareComponentMin = Utilites.MathEx.Clamp(serializable.RareComponentMin, 0, 20);
			RareComponentMax = Utilites.MathEx.Clamp(serializable.RareComponentMax, 0, 20);
			SatelliteCount = Utilites.MathEx.Clamp(serializable.SatelliteCount, 0, 20);
			BlackMarketMoney = Utilites.MathEx.Clamp(serializable.BlackMarketMoney, 0, 1000000);

			OnDataDeserialized(serializable, loader);
		}

		public float FuelRenewal { get; private set; }
		public float TechRenewal { get; private set; }
		public float StarsRenewal { get; private set; }
		public float ShipRenewal { get; private set; }
		public float CommonComponentRenewal { get; private set; }
		public float RareComponentRenewal { get; private set; }
		public float SatelliteRenewal { get; private set; }
		private readonly Expressions.IntToInt _rareComponentLevel;
		public delegate int RareComponentLevelDelegate(int level);
		public RareComponentLevelDelegate RareComponentLevel { get; private set; }
		public int RareComponentMin { get; private set; }
		public int RareComponentMax { get; private set; }
		public int SatelliteCount { get; private set; }
		public int BlackMarketMoney { get; private set; }

		public static MarketSettings DefaultValue { get; private set; }

		private class VariableResolver : IVariableResolver
		{
			private MarketSettings _context;

			public VariableResolver(MarketSettings context)
			{
				_context = context;
			}

			public IFunction<Variant> ResolveFunction(string name)
            {
				if (name == "RareComponentLevel") return _context._rareComponentLevel;
				return ((IVariableResolver)_context).ResolveFunction(name);
			}

			public Expression<Variant> ResolveVariable(string name)
			{
				if (name == "FuelRenewal") return GetFuelRenewal;
				if (name == "TechRenewal") return GetTechRenewal;
				if (name == "StarsRenewal") return GetStarsRenewal;
				if (name == "ShipRenewal") return GetShipRenewal;
				if (name == "CommonComponentRenewal") return GetCommonComponentRenewal;
				if (name == "RareComponentRenewal") return GetRareComponentRenewal;
				if (name == "SatelliteRenewal") return GetSatelliteRenewal;
				if (name == "RareComponentMin") return GetRareComponentMin;
				if (name == "RareComponentMax") return GetRareComponentMax;
				if (name == "SatelliteCount") return GetSatelliteCount;
				if (name == "BlackMarketMoney") return GetBlackMarketMoney;
				return ((IVariableResolver)_context).ResolveVariable(name);
			}

			private Variant GetFuelRenewal() => _context.FuelRenewal;
			private Variant GetTechRenewal() => _context.TechRenewal;
			private Variant GetStarsRenewal() => _context.StarsRenewal;
			private Variant GetShipRenewal() => _context.ShipRenewal;
			private Variant GetCommonComponentRenewal() => _context.CommonComponentRenewal;
			private Variant GetRareComponentRenewal() => _context.RareComponentRenewal;
			private Variant GetSatelliteRenewal() => _context.SatelliteRenewal;
			private Variant GetRareComponentMin() => _context.RareComponentMin;
			private Variant GetRareComponentMax() => _context.RareComponentMax;
			private Variant GetSatelliteCount() => _context.SatelliteCount;
			private Variant GetBlackMarketMoney() => _context.BlackMarketMoney;
		}
	}
}
