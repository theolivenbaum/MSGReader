// name       : IArgument.cs
// project    : System Framelet
// created    : Jani Giannoudis - 2008.06.03
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland

namespace Itenso.Sys.Application
{
    public interface IArgument
    {
        string Name { get; }

        object Value { get; }

        object DefaultValue { get; }

        bool IsMandatory { get; }

        bool HasName { get; }

        bool IsValid { get; }

        bool IsLoaded { get; }

        void Load(string commandLineArg);
    } // interface IArgument
}