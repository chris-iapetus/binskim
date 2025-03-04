﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.CodeAnalysis.IL.Rules
{
    internal static class RuleIds
    {
        // Analysis check ids
        public const string LoadImageAboveFourGigabyteAddress = "BA2001";

        public const string DoNotIncorporateVulnerableDependencies = "BA2002";

        // 2004 open. Previously for specific ATL implementation verification

        // Id gap relates to unported analysis
        public const string EnableSecureSourceCodeHashing = "BA2004";

        public const string DoNotShipVulnerableBinaries = "BA2005";
        public const string BuildWithSecureTools = "BA2006";
        public const string EnableCriticalCompilerWarnings = "BA2007";
        public const string EnableControlFlowGuard = "BA2008";
        public const string EnableAddressSpaceLayoutRandomization = "BA2009";
        public const string DoNotMarkImportsSectionAsExecutable = "BA2010";
        public const string EnableStackProtection = "BA2011";
        public const string DoNotModifyStackProtectionCookie = "BA2012";
        public const string InitializeStackProtection = "BA2013";
        public const string DoNotDisableStackProtectionForFunctions = "BA2014";
        public const string EnableHighEntropyVirtualAddresses = "BA2015";
        public const string MarkImageAsNXCompatible = "BA2016";

        // 2017 open. Previously for 'do not link static crypto' check

        public const string EnableSafeSEH = "BA2018";
        public const string DoNotMarkWritableSectionsAsShared = "BA2019";

        // 2020 open. Previously for 'do not use vb6' check

        public const string DoNotMarkWritableSectionsAsExecutable = "BA2021";
        public const string SignSecurely = "BA2022";

        public const string EnableSpectreMitigations = "BA2024";
        public const string EnableShadowStack = "BA2025";

        // Renamed from 'EnableAdditionalSdlSecurityChecks' as of 1.9.3.
        public const string EnableMicrosoftCompilerSdlSwitch = "BA2026";
        public const string EnableSourceLink = "BA2027";

        // ELF Checks
        public const string EnablePositionIndependentExecutable = "BA3001";

        public const string DoNotMarkStackAsExecutable = "BA3002";
        public const string EnableStackProtector = "BA3003";
        public const string GenerateRequiredSymbolFormat = "BA3004";
        public const string EnableStackClashProtection = "BA3005";
        public const string EnableNonExecutableStack = "BA3006";

        // Skipping some check namespace (BA3004-3009) for future checks
        public const string EnableReadOnlyRelocations = "BA3010";

        public const string EnableBindNow = "BA3011";

        // BA3012-3029 -- saved for future non-compiler/language specific checks.
        // Compiler/Language specific checks follow.
        public const string UseGccCheckedFunctions = "BA3030";
        public const string EnableClangSafeStack = "BA3031";

        // Reporting checks
        public const string ReportPortableExecutableCompilerData = "BA4001";
        public const string ReportElfOrMachoCompilerData = "BA4002";

        // MachO Checks
        public const string EnablePositionIndependentExecutableMachO = "BA5001";
        public const string DoNotAllowExecutableStack = "BA5002";

        // Performance (not security) checks
        public const string DisableIncrementalLinkingInReleaseBuilds = "BA6001";
        public const string EliminateDuplicateStrings = "BA6002";
        // public const string RuntimeTypeInformation = "BA6003"; // reserved rule id
        public const string EnableComdatFolding = "BA6004";
        public const string EnableOptimizeReferences = "BA6005";
        public const string EnableLinkTimeCodeGeneration = "BA6006";
    }
}
