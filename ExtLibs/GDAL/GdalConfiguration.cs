using OSGeo.GDAL;
using OSGeo.OGR;

public static class GdalConfiguration
{
    private static bool _configuredGdal = false;
    private static bool _configuredOgr = false;

    public static void ConfigureGdal()
    {
        if (!_configuredGdal)
        {
            Gdal.AllRegister();
            _configuredGdal = true;
        }
    }

    public static void ConfigureOgr()
    {
        if (!_configuredOgr)
        {
            Ogr.RegisterAll();
            _configuredOgr = true;
        }
    }
}
