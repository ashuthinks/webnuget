// <auto-generated />
namespace NuGetGallery.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class PackageStatistics : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(PackageStatistics));
        
        string IMigrationMetadata.Id
        {
            get { return "201310281909048_PackageStatistics"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
