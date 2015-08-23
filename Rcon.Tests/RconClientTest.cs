// <copyright file="RconClientTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rcon;
using Rcon.Commands;

namespace Rcon.Tests
{
    /// <summary>Diese Klasse enthält parametrisierte Komponententests für RconClient.</summary>
    [PexClass(typeof(RconClient))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RconClientTest
    {
        /// <summary>Test-Stub für Connect(String, Int32, String)</summary>
        [PexMethod]
        public bool ConnectTest(
            [PexAssumeUnderTest]RconClient target,
            string host,
            int port,
            string password
        )
        {
            bool result = target.Connect(host, port, password);
            return result;
            // TODO: Assertionen zu Methode RconClientTest.ConnectTest(RconClient, String, Int32, String) hinzufügen
        }

        /// <summary>Test-Stub für .ctor()</summary>
        [PexMethod]
        public RconClient ConstructorTest()
        {
            RconClient target = new RconClient();
            return target;
            // TODO: Assertionen zu Methode RconClientTest.ConstructorTest() hinzufügen
        }

        /// <summary>Test-Stub für Disconnect()</summary>
        [PexMethod]
        public void DisconnectTest([PexAssumeUnderTest]RconClient target)
        {
            target.Disconnect();
            // TODO: Assertionen zu Methode RconClientTest.DisconnectTest(RconClient) hinzufügen
        }

        /// <summary>Test-Stub für ExecuteCommandAsync(Command, EventHandler`1&lt;CommandExecutedEventArgs&gt;)</summary>
        [PexMethod]
        public void ExecuteCommandAsyncTest(
            [PexAssumeUnderTest]RconClient target,
            Command command,
            EventHandler<CommandExecutedEventArgs> callback
        )
        {
            target.ExecuteCommandAsync(command, callback);
            // TODO: Assertionen zu Methode RconClientTest.ExecuteCommandAsyncTest(RconClient, Command, EventHandler`1<CommandExecutedEventArgs>) hinzufügen
        }

        /// <summary>Test-Stub für ExecuteLowPrioCommandAsync(Command, EventHandler`1&lt;CommandExecutedEventArgs&gt;)</summary>
        [PexMethod]
        public void ExecuteLowPrioCommandAsyncTest(
            [PexAssumeUnderTest]RconClient target,
            Command command,
            EventHandler<CommandExecutedEventArgs> callback
        )
        {
            target.ExecuteLowPrioCommandAsync(command, callback);
            // TODO: Assertionen zu Methode RconClientTest.ExecuteLowPrioCommandAsyncTest(RconClient, Command, EventHandler`1<CommandExecutedEventArgs>) hinzufügen
        }

        /// <summary>Test-Stub für get_IsConnected()</summary>
        [PexMethod]
        public bool IsConnectedGetTest([PexAssumeUnderTest]RconClient target)
        {
            bool result = target.IsConnected;
            return result;
            // TODO: Assertionen zu Methode RconClientTest.IsConnectedGetTest(RconClient) hinzufügen
        }
    }
}
