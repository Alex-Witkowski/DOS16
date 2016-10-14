using System.Threading.Tasks;

namespace UwpWorkshop.MvvmLightDemo.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}