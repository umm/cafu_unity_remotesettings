using System.Collections.Generic;
using CAFU.Core;

namespace CAFU.UnityRemoteSettings.Data.Repository
{
    public interface IRemoteSettingController : IDataStore
    {
        int GetCount();
        IEnumerable<string> GetKeys();
        bool HasKey(string key);
        void ForceUpdate();
        bool WasLastUpdatedFromServer();
    }
}