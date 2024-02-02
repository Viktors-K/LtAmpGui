﻿using LtAmpDotNet.Lib;
using LtAmpDotNet.Tests.Mock;
using System.CommandLine;

namespace LtAmpDotNet.Cli.Commands
{
    internal abstract class BaseCommandDefinition : Command, IDisposable
    {
        internal LtAmplifier? Amp;

        protected BaseCommandDefinition(string name, string? description = null) : base(name, description) { }

        internal virtual async Task Open()
        {
            Amp = new LtAmplifier(new MockHidDevice());
            await Amp.OpenAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

