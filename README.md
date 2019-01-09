# CAFU Unity RemoteSettings

## What

* Wrapper for [Unity RemoteSettings](https://docs.unity3d.com/Manual/UnityAnalyticsRemoteSettings.html)

## Requirement

* Unity 2018.3

## Install

```shell
yarn add "umm/cafu_unity_remotesettings#^1.0.0"
```

## Usage

`UnityRemoteSettings` class provides wrapper methods to access `UnityEngine.RemoteSettings`.

Provide interfaces splitted by feature.

### `IRemoteSettingReader`

* `GetBool`
* `GetInt`
* `GetFloat`
* `GetString`

Note: `GetLong` method was not worked fine.

### `IRemoteSettingController`

* `GetCount`
* `GetKeys`
* `HasKey`
* `ForceUpdate`
* `WasLastUpdatedFromServer`

### `IRemoteSettingEventHandler`

* `AddUpdated`
* `RemoveUpdated`
* `AddCompleted`
* `RemoveUpdated`
* `AddBeforeFetchFromServer`
* `RemoveBeforeFetchFromServer`

## Tests

You must setup Unity Analytics.

See [manual](https://docs.unity3d.com/Manual/UnityAnalyticsSetup.html).

Some test cases needs KeyValue pair listed below.

| Key | Type | Value |
| --- | --- | --- |
| BoolValue | Boolean | `true` |
| IntValue | Integer | `1` |
| FloatValue | Float | `0.1` |
| StringValue | String | `value` |

## Contribution

Please **DO NOT** commit changes for changes below fields in `ProjectSettings/ProjectSettings.asset`

* `cloudProjectId`
* `projectName`
* `organizationId`

## License

Copyright (c) 2019 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)
