using System;
using CAFU.Core;
using UnityEngine;

namespace CAFU.UnityRemoteSettings.Data.Repository
{
    public interface IRemoteSettingEventHandler : IDataStore
    {
        void AddUpdated(RemoteSettings.UpdatedEventHandler updatedEventHandler);
        void RemoveUpdated(RemoteSettings.UpdatedEventHandler updatedEventHandler);
        void AddCompleted(Action<bool, bool, int> completedEventHandler);
        void RemoveUpdated(Action<bool, bool, int> completedEventHandler);
        void AddBeforeFetchFromServer(Action beforeFetchFromServerEventHandler);
        void RemoveBeforeFetchFromServer(Action beforeFetchFromServerEventHandler);
    }
}