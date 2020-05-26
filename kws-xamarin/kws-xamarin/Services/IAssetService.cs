using System.Threading.Tasks;

namespace kws_xamarin
{
    public interface IAssetService
    {
        string GetAssetPath(string filename);
    }
}