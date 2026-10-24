using DatabaseMigration.v1.Enums;

namespace DatabaseMigration.v1
{
    public partial class DatabaseUpgrader
    {
		partial void Migrate_7_8()
		{
            GameDiagnostics.Trace.LogWarning("Database migration: v1.7 -> v1.8");

            foreach (var satellite in Content.SatelliteList)
            {
                if (satellite.SizeClass != SizeClass.Titan) continue;

                satellite.NotAvailableInBlackMarket = true;
                satellite.NotAvailableInRuins = true;
            }
		}
    }
}
