//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace MICore.Xml.LaunchOptions {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class AndroidLaunchOptions {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Package;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LaunchActivity;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SDKRoot;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NDKRoot;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IntermediateDirectory;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LogcatServiceId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Attach;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SourceRoots;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(65534)]
        public int JVMPort;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("localhost")]
        public string JVMHost;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetArchitectureSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsolutePrefixSOLibSearchPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool WaitDynamicLibLoad;
        
        public AndroidLaunchOptions() {
            this.Attach = false;
            this.SourceRoots = "";
            this.JVMPort = 65534;
            this.JVMHost = "localhost";
            this.WaitDynamicLibLoad = true;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum TargetArchitecture {
        
        /// <remarks/>
        x86,
        
        /// <remarks/>
        arm,
        
        /// <remarks/>
        arm64,
        
        /// <remarks/>
        mips,
        
        /// <remarks/>
        x64,
        
        /// <remarks/>
        amd64,
        
        /// <remarks/>
        x86_64,
        
        /// <remarks/>
        X86,
        
        /// <remarks/>
        ARM,
        
        /// <remarks/>
        ARM64,
        
        /// <remarks/>
        MIPS,
        
        /// <remarks/>
        X64,
        
        /// <remarks/>
        AMD64,
        
        /// <remarks/>
        X86_64,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum MIMode {
        
        /// <remarks/>
        gdb,
        
        /// <remarks/>
        lldb,
        
        /// <remarks/>
        clrdbg,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class EnvironmentEntry {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class Command {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IgnoreFailures;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IgnoreFailuresSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public partial class BaseLaunchOptions {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Command[] SetupCommands;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Command[] CustomLaunchSetupCommands;
        
        /// <remarks/>
        public BaseLaunchOptionsLaunchCompleteCommand LaunchCompleteCommand;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaunchCompleteCommandSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExePath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExeArguments;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WorkingDirectory;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VisualizerFile;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ShowDisplayString;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShowDisplayStringSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ProcessId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProcessIdSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CoreDumpPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DebugChildProcesses;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DebugChildProcessesSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetArchitectureSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsolutePrefixSOLibSearchPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool WaitDynamicLibLoad;
        
        public BaseLaunchOptions() {
            this.WaitDynamicLibLoad = true;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum BaseLaunchOptionsLaunchCompleteCommand {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exec-run")]
        execrun,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exec-continue")]
        execcontinue,
        
        /// <remarks/>
        None,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class IOSLaunchOptions {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemoteMachineName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int vcremotePort;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IOSLaunchOptionsIOSDebugTarget IOSDebugTarget;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeviceUdid;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IOSLaunchOptionsSecure Secure;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TargetArchitecture TargetArchitecture;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetArchitectureSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsolutePrefixSOLibSearchPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalSOLibSearchPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MIMode MIMode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MIModeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool WaitDynamicLibLoad;
        
        public IOSLaunchOptions() {
            this.WaitDynamicLibLoad = true;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum IOSLaunchOptionsIOSDebugTarget {
        
        /// <remarks/>
        Device,
        
        /// <remarks/>
        Simulator,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    public enum IOSLaunchOptionsSecure {
        
        /// <remarks/>
        True,
        
        /// <remarks/>
        False,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class LocalLaunchOptions : BaseLaunchOptions {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public EnvironmentEntry[] Environment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MIDebuggerPath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MIDebuggerServerAddress;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DebugServer;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DebugServerArgs;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServerStarted;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FilterStdout;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterStdoutSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FilterStderr;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterStderrSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ServerLaunchTimeout;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServerLaunchTimeoutSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExternalConsole;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalConsoleSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class PipeLaunchOptions : BaseLaunchOptions {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public EnvironmentEntry[] PipeEnvironment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipePath;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipeArguments;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipeCommandArguments;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PipeCwd;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class TcpLaunchOptions : BaseLaunchOptions {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Hostname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Port;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Secure;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecureSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/vstudio/MDDDebuggerOptions/2014", IsNullable=false)]
    public partial class SSHLaunchOptions : BaseLaunchOptions {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetMachine;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartRemoteDebuggerCommand;
    }
}