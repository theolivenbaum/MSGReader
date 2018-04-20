﻿// name       : IRtfFont.cs
// project    : RTF Framelet
// created    : Leon Poyyayil - 2008.05.20
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland

namespace Itenso.Rtf
{
    public interface IRtfFont
    {
        string Id { get; }

        RtfFontKind Kind { get; }

        RtfFontPitch Pitch { get; }

        int CharSet { get; }

        int CodePage { get; }

        string Name { get; }
    }
}