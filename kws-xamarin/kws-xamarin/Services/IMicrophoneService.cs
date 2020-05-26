using System.Threading.Tasks;

namespace kws_xamarin
{
    public interface IMicrophoneService
    {
        Task<bool> GetPermissionsAsync();
        void OnRequestPermissionsResult(bool isGranted);
    }
}