using System.Collections;
using CAFU.UnityRemoteSettings.Data.Repository;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace CAFU.UnityRemoteSettings.Data.DataStore
{
    public class ReaderTest
    {
        private IRemoteSettingReader RemoteSettingReader { get; set; }
        private IRemoteSettingController RemoteSettingController { get; set; }

        [SetUp]
        public void SetUp()
        {
            // Cloud Project Id が設定されていない場合は RemoteSettings が未設定と見なす
            if (string.IsNullOrEmpty(Application.cloudProjectId))
            {
                Assert.Fail("Unity Analytics has not been setup.");
            }
            var unityRemoteSettings = new UnityRemoteSettings();
            RemoteSettingReader = unityRemoteSettings;
            RemoteSettingController = unityRemoteSettings;
        }

        [UnityTest]
        public IEnumerator キーが存在しデフォルト値が渡されている場合()
        {
            Assert.True(RemoteSettingController.HasKey("BoolValue"));
            Assert.True(RemoteSettingController.HasKey("IntValue"));
            Assert.True(RemoteSettingController.HasKey("FloatValue"));
            Assert.True(RemoteSettingController.HasKey("LongValue"));
            Assert.True(RemoteSettingController.HasKey("StringValue"));
            Assert.True(RemoteSettingReader.GetBool("BoolValue"));
            Assert.AreEqual(1, RemoteSettingReader.GetInt("IntValue", 2));
            Assert.AreEqual(0.1f, RemoteSettingReader.GetFloat("FloatValue", 0.2f));
            Assert.AreEqual(10L, RemoteSettingReader.GetLong("LongValue", 20L));
            Assert.AreEqual("value", RemoteSettingReader.GetString("StringValue", "valuevalue"));
            yield return null;
        }

        [UnityTest]
        public IEnumerator キーが存在しデフォルト値が渡されていない場合()
        {
            Assert.True(RemoteSettingController.HasKey("BoolValue"));
            Assert.True(RemoteSettingController.HasKey("IntValue"));
            Assert.True(RemoteSettingController.HasKey("FloatValue"));
            Assert.True(RemoteSettingController.HasKey("LongValue"));
            Assert.True(RemoteSettingController.HasKey("StringValue"));
            Assert.True(RemoteSettingReader.GetBool("BoolValue"));
            Assert.AreEqual(1, RemoteSettingReader.GetInt("IntValue"));
            Assert.AreEqual(0.1f, RemoteSettingReader.GetFloat("FloatValue"));
            Assert.AreEqual(10L, RemoteSettingReader.GetLong("LongValue"));
            Assert.AreEqual("value", RemoteSettingReader.GetString("StringValue"));
            yield return null;
        }

        [UnityTest]
        public IEnumerator キーが存在せずデフォルト値が渡されている場合()
        {
            Assert.False(RemoteSettingController.HasKey("NotExistsBoolValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsIntValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsFloatValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsLongValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsStringValue"));
            Assert.True(RemoteSettingReader.GetBool("NotExistsBoolValue", true));
            Assert.AreEqual(1, RemoteSettingReader.GetInt("NotExistsIntValue", 1));
            Assert.AreEqual(0.1f, RemoteSettingReader.GetFloat("NotExistsFloatValue", 0.1f));
            Assert.AreEqual(10L, RemoteSettingReader.GetLong("NotExistsLongValue", 10L));
            Assert.AreEqual("value", RemoteSettingReader.GetString("NotExistsStringValue", "value"));
            yield return null;
        }

        [UnityTest]
        public IEnumerator キーが存在せずデフォルト値が渡されていない場合()
        {
            Assert.False(RemoteSettingController.HasKey("NotExistsBoolValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsIntValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsFloatValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsLongValue"));
            Assert.False(RemoteSettingController.HasKey("NotExistsStringValue"));
            Assert.False(RemoteSettingReader.GetBool("NotExistsBoolValue"));
            Assert.AreEqual(default(int), RemoteSettingReader.GetInt("NotExistsIntValue"));
            Assert.AreEqual(default(float), RemoteSettingReader.GetFloat("NotExistsFloatValue"));
            Assert.AreEqual(default(long), RemoteSettingReader.GetLong("NotExistsLongValue"));
            Assert.AreEqual(default(string), RemoteSettingReader.GetString("NotExistsStringValue"));
            yield return null;
        }
    }
}