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
	public partial class RuinsSettings : IDefaultVariablesResolver
	{
		partial void OnDataDeserialized(RuinsSettingsSerializable serializable, Database.Loader loader);

		public static RuinsSettings Create(RuinsSettingsSerializable serializable, Database.Loader loader)
		{
			return serializable == null ? DefaultValue : new RuinsSettings(serializable, loader);
		}

		private RuinsSettings(RuinsSettingsSerializable serializable, Database.Loader loader)
		{
			var variableResolver = new VariableResolver(this);
			_maxSatelliteCells = new Expressions.IntToInt(serializable.MaxSatelliteCells, 0, 1000, variableResolver) { ParamName1 = "level" };
			MaxSatelliteCells = _maxSatelliteCells.Evaluate;
			CreditsMultiplier = Utilites.MathEx.Clamp(serializable.CreditsMultiplier, 0, 100);
			FuelMin = Utilites.MathEx.Clamp(serializable.FuelMin, 0, 100);
			FuelMax = Utilites.MathEx.Clamp(serializable.FuelMax, 0, 100);
			SatelliteChance = Utilites.MathEx.Clamp(serializable.SatelliteChance, 1, 100);
			SatelliteCount = Utilites.MathEx.Clamp(serializable.SatelliteCount, 0, 10);
			_componentLevel = new Expressions.IntToInt(serializable.ComponentLevel, 0, 1000, variableResolver) { ParamName1 = "level" };
			ComponentLevel = _componentLevel.Evaluate;
			ComponentMin = Utilites.MathEx.Clamp(serializable.ComponentMin, 0, 20);
			ComponentMax = Utilites.MathEx.Clamp(serializable.ComponentMax, 0, 20);
			StarsMin = Utilites.MathEx.Clamp(serializable.StarsMin, 0, 10);
			StarsMax = Utilites.MathEx.Clamp(serializable.StarsMax, 0, 10);
			FleetSizeMultiplier = Utilites.MathEx.Clamp(serializable.FleetSizeMultiplier, 1, 10);

			OnDataDeserialized(serializable, loader);
		}

		private readonly Expressions.IntToInt _maxSatelliteCells;
		public delegate int MaxSatelliteCellsDelegate(int level);
		public MaxSatelliteCellsDelegate MaxSatelliteCells { get; private set; }
		public int CreditsMultiplier { get; private set; }
		public int FuelMin { get; private set; }
		public int FuelMax { get; private set; }
		public int SatelliteChance { get; private set; }
		public int SatelliteCount { get; private set; }
		private readonly Expressions.IntToInt _componentLevel;
		public delegate int ComponentLevelDelegate(int level);
		public ComponentLevelDelegate ComponentLevel { get; private set; }
		public int ComponentMin { get; private set; }
		public int ComponentMax { get; private set; }
		public int StarsMin { get; private set; }
		public int StarsMax { get; private set; }
		public int FleetSizeMultiplier { get; private set; }

		public static RuinsSettings DefaultValue { get; private set; }

		private class VariableResolver : IVariableResolver
		{
			private RuinsSettings _context;

			public VariableResolver(RuinsSettings context)
			{
				_context = context;
			}

			public IFunction<Variant> ResolveFunction(string name)
            {
				if (name == "MaxSatelliteCells") return _context._maxSatelliteCells;
				if (name == "ComponentLevel") return _context._componentLevel;
				return ((IVariableResolver)_context).ResolveFunction(name);
			}

			public Expression<Variant> ResolveVariable(string name)
			{
				if (name == "CreditsMultiplier") return GetCreditsMultiplier;
				if (name == "FuelMin") return GetFuelMin;
				if (name == "FuelMax") return GetFuelMax;
				if (name == "SatelliteChance") return GetSatelliteChance;
				if (name == "SatelliteCount") return GetSatelliteCount;
				if (name == "ComponentMin") return GetComponentMin;
				if (name == "ComponentMax") return GetComponentMax;
				if (name == "StarsMin") return GetStarsMin;
				if (name == "StarsMax") return GetStarsMax;
				if (name == "FleetSizeMultiplier") return GetFleetSizeMultiplier;
				return ((IVariableResolver)_context).ResolveVariable(name);
			}

			private Variant GetCreditsMultiplier() => _context.CreditsMultiplier;
			private Variant GetFuelMin() => _context.FuelMin;
			private Variant GetFuelMax() => _context.FuelMax;
			private Variant GetSatelliteChance() => _context.SatelliteChance;
			private Variant GetSatelliteCount() => _context.SatelliteCount;
			private Variant GetComponentMin() => _context.ComponentMin;
			private Variant GetComponentMax() => _context.ComponentMax;
			private Variant GetStarsMin() => _context.StarsMin;
			private Variant GetStarsMax() => _context.StarsMax;
			private Variant GetFleetSizeMultiplier() => _context.FleetSizeMultiplier;
		}
	}
}
