﻿using CAFU.Core;

namespace CAFU.UnityRemoteSettings.Data.Repository
{
    public interface IRemoteSettingReader : IDataStore
    {
        bool GetBool(string key, bool defaultValue = default);
        int GetInt(string key, int defaultValue = default);
        float GetFloat(string key, float defaultValue = default);
        long GetLong(string key, long defaultValue = default);
        string GetString(string key, string defaultValue = default);
    }
}