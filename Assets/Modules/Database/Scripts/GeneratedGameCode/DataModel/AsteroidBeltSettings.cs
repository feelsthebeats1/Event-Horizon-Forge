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

namespace GameDatabase.DataModel
{
	public partial class AsteroidBeltSettings 
	{
		partial void OnDataDeserialized(AsteroidBeltSettingsSerializable serializable, Database.Loader loader);

		public static AsteroidBeltSettings Create(AsteroidBeltSettingsSerializable serializable, Database.Loader loader)
		{
			return serializable == null ? DefaultValue : new AsteroidBeltSettings(serializable, loader);
		}

		private AsteroidBeltSettings(AsteroidBeltSettingsSerializable serializable, Database.Loader loader)
		{
			MeteoriteChance = UnityEngine.Mathf.Clamp(serializable.MeteoriteChance, -2147483648, 2147483647);
			ContainerChance = UnityEngine.Mathf.Clamp(serializable.ContainerChance, -2147483648, 2147483647);
			ShipWreckChance = UnityEngine.Mathf.Clamp(serializable.ShipWreckChance, -2147483648, 2147483647);
			OutpostChance = UnityEngine.Mathf.Clamp(serializable.OutpostChance, -2147483648, 2147483647);

			OnDataDeserialized(serializable, loader);
		}

		public int MeteoriteChance { get; private set; }
		public int ContainerChance { get; private set; }
		public int ShipWreckChance { get; private set; }
		public int OutpostChance { get; private set; }

		public static AsteroidBeltSettings DefaultValue { get; private set; }= new(new(), null);
	}
}
