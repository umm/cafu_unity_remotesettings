using System;
using System.Collections.Generic;
using CAFU.UnityRemoteSettings.Data.Repository;
using UnityEngine;

namespace CAFU.UnityRemoteSettings.Data.DataStore
{
    public class UnityRemoteSettings :
        IRemoteSettingController,
        IRemoteSettingReader,
        IRemoteSettingEventHandler
    {
        public int GetCount()
        {
            return RemoteSettings.GetCount();
        }

        public IEnumerable<string> GetKeys()
        {
            return RemoteSettings.GetKeys();
        }

        public bool HasKey(string key)
        {
            return RemoteSettings.HasKey(key);
        }

        public void ForceUpdate()
        {
            RemoteSettings.ForceUpdate();
        }

        public bool WasLastUpdatedFromServer()
        {
            return RemoteSettings.WasLastUpdatedFromServer();
        }

        public bool GetBool(string key, bool defaultValue = default)
        {
            return RemoteSettings.GetBool(key, defaultValue);
        }

        public int GetInt(string key, int defaultValue = default)
        {
            return RemoteSettings.GetInt(key, defaultValue);
        }

        public float GetFloat(string key, float defaultValue = default)
        {
            return RemoteSettings.GetFloat(key, defaultValue);
        }

        public long GetLong(string key, long defaultValue = default)
        {
            return RemoteSettings.GetLong(key, defaultValue);
        }

        public string GetString(string key, string defaultValue = default)
        {
            return RemoteSettings.GetString(key, defaultValue);
        }

        public void AddUpdated(RemoteSettings.UpdatedEventHandler updatedEventHandler)
        {
            RemoteSettings.Updated += updatedEventHandler;
        }

        public void RemoveUpdated(RemoteSettings.UpdatedEventHandler updatedEventHandler)
        {
            RemoteSettings.Updated -= updatedEventHandler;
        }

        public void AddCompleted(Action<bool, bool, int> completedEventHandler)
        {
            RemoteSettings.Completed += completedEventHandler;
        }

        public void RemoveUpdated(Action<bool, bool, int> completedEventHandler)
        {
            RemoteSettings.Completed -= completedEventHandler;
        }

        public void AddBeforeFetchFromServer(Action beforeFetchFromServerEventHandler)
        {
            RemoteSettings.BeforeFetchFromServer += beforeFetchFromServerEventHandler;
        }

        public void RemoveBeforeFetchFromServer(Action beforeFetchFromServerEventHandler)
        {
            RemoteSettings.BeforeFetchFromServer -= beforeFetchFromServerEventHandler;
        }
    }
}